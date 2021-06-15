// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Authentication.Models;
using ATPlatform.Common.Utils.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication
{
  public class WebPlatformAuthentication : IPlatformAuthentication
  {
    private const string _accountNumberOrEmailRequestName = "AccountNumberOrEmail";
    private const string _preferredAccountNumberName = "PreferredAccountNumber";
    private const string _passwordRequestName = "Password";
    private const string _requestVerificationTokenRequestName = "__RequestVerificationToken";
    private const string _accountNumberRequestName = "AccountNumber";
    private const string _clientType = "ClientType";
    private const string _platformRequestName = "Platform";
    private const string _wpSessionCookieName = "WPSession";
    private const string _wpWPAuthCookieName = "WPAuth";
    private readonly ILogger _logger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly Uri WpUri;
    private readonly string _antiForgAddress;
    private readonly string _loginAddress;
    private readonly string _logoutAddress;
    private readonly string _switchAccountAddress;

    public WebPlatformAuthentication()
    {
      string wpHost = ApplicationSettings.WpHost;
      string wpAntForg = ApplicationSettings.WpAntForg;
      string wpLogin = ApplicationSettings.WpLogin;
      string wpLogout = ApplicationSettings.WpLogout;
      this._antiForgAddress = wpHost + "/" + wpAntForg;
      this._loginAddress = wpHost + "/" + wpLogin;
      this._logoutAddress = wpHost + "/" + wpLogout;
      this.WpUri = new Uri(wpHost);
    }

    public WebPlatformAuthentication(string webPlatformHost)
    {
      string wpAntForg = ApplicationSettings.WpAntForg;
      string wpLogin = ApplicationSettings.WpLogin;
      string wpLogout = ApplicationSettings.WpLogout;
      string wpSwitchAccount = ApplicationSettings.WpSwitchAccount;
      this._antiForgAddress = webPlatformHost + "/" + wpAntForg;
      this._loginAddress = webPlatformHost + "/" + wpLogin;
      this._logoutAddress = webPlatformHost + "/" + wpLogout;
      this._switchAccountAddress = webPlatformHost + "/" + wpSwitchAccount;
      this.WpUri = new Uri(webPlatformHost);
    }

    public async Task<AuthenticationResult> LoginAsync(
      string email,
      string password,
      int account)
    {
      return await this.LoginPostAsync(email, password, (string) null, account);
    }

    public async Task<AuthenticationResult> LoginAsync(
      int account,
      string password,
      string platform)
    {
      return await this.LoginPostAsync(account.ToString(), password, platform, account);
    }

    public async Task LogoutAsync(IAuthenticatedSession session) => await this.LogoutPostAsync(session);

    private async Task<AuthenticationResult> LoginPostAsync(
      string accountNumberOrEmail,
      string password,
      string platform,
      int preferredAccountNumber)
    {
      LoginResult loginResult = (LoginResult) null;
      string authSession = (string) null;
      string authId = (string) null;
      AuthenticationResult authenticationResult1;
      using (ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication.WebClient client = new ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication.WebClient())
      {
        string antiForgeryToken = await this.GetAntiForgeryToken((System.Net.WebClient) client);
        if (antiForgeryToken != null)
        {
          NameValueCollection data = new NameValueCollection()
          {
            {
              "AccountNumberOrEmail",
              accountNumberOrEmail
            },
            {
              "Password",
              password
            },
            {
              "PreferredAccountNumber",
              preferredAccountNumber.ToString()
            },
            {
              "__RequestVerificationToken",
              antiForgeryToken
            },
            {
              "ClientType",
              ApplicationSettings.ClientType
            }
          };
          if (!string.IsNullOrEmpty(platform))
            data.Add("Platform", platform);
          byte[] bytes = await client.UploadValuesTaskAsync(this._loginAddress, data);
          if (bytes != null)
          {
            loginResult = JsonConvert.DeserializeObject<LoginResult>(Encoding.UTF8.GetString(bytes));
            authSession = client.GetCookie(this.WpUri, "WPSession");
            authId = client.GetCookie(this.WpUri, "WPAuth");
          }
        }
        LoginResult loginResult1 = loginResult;
        AuthenticationResult authenticationResult2;
        if (loginResult1 == null)
        {
          authenticationResult2 = (AuthenticationResult) null;
        }
        else
        {
          Responsedata responsedata = loginResult1.Responsedata;
          authenticationResult2 = responsedata != null ? responsedata.Map(authSession, authId) : (AuthenticationResult) null;
        }
        AuthenticationResult authenticationResult3 = authenticationResult2;
        if (authenticationResult3 == null)
          throw new UnauthorizedAccessException(string.Format("{0} login failed.", (object) preferredAccountNumber));
        if (authenticationResult3.SelectedAccountId != preferredAccountNumber)
          throw new UnauthorizedAccessException(string.Format("{0} login failed. Current selected account is {1}.", (object) preferredAccountNumber, (object) authenticationResult3.SelectedAccountId));
        authenticationResult1 = authenticationResult3;
      }
      loginResult = (LoginResult) null;
      authSession = (string) null;
      authId = (string) null;
      return authenticationResult1;
    }

    private async Task LogoutPostAsync(IAuthenticatedSession session)
    {
      using (ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication.WebClient client = new ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthentication.WebClient())
      {
        string antiForgeryToken = await this.GetAntiForgeryToken((System.Net.WebClient) client);
        if (antiForgeryToken != null)
        {
          client.AddCookie(this.WpUri, new Cookie("WPSession", session.SessionId));
          client.AddCookie(this.WpUri, new Cookie("WPAuth", session.AuthId));
          client.AddCookie(this.WpUri, new Cookie("__RequestVerificationToken", antiForgeryToken));
          NameValueCollection data = new NameValueCollection()
          {
            {
              "__RequestVerificationToken",
              antiForgeryToken
            }
          };
          byte[] numArray = await client.UploadValuesTaskAsync(this._logoutAddress, data);
        }
      }
    }

    private async Task<string> GetAntiForgeryToken(System.Net.WebClient client)
    {
      string str = await client.DownloadStringTaskAsync(this._antiForgAddress);
      if (str != null)
      {
        ForgeryTokenResponse forgeryTokenResponse = JsonConvert.DeserializeObject<ForgeryTokenResponse>(str);
        if (forgeryTokenResponse != null && forgeryTokenResponse.ForgeryToken != null)
          return forgeryTokenResponse.ForgeryToken;
      }
      return (string) null;
    }

    private class WebClient : System.Net.WebClient
    {
      private readonly CookieContainer _cookieContainer = new CookieContainer();

      protected override WebRequest GetWebRequest(Uri address)
      {
        WebRequest webRequest = base.GetWebRequest(address);
        if (webRequest is HttpWebRequest)
          (webRequest as HttpWebRequest).CookieContainer = this._cookieContainer;
        return webRequest;
      }

      public string GetCookie(Uri uri, string name)
      {
        string str = (string) null;
        foreach (object cookie1 in this._cookieContainer.GetCookies(uri))
        {
          if (cookie1 is Cookie cookie && cookie.Name == name)
          {
            str = cookie.Value;
            break;
          }
        }
        return str;
      }

      public void AddCookie(Uri uri, Cookie cookie) => this._cookieContainer.Add(uri, cookie);
    }
  }
}
