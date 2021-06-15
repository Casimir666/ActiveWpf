// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Communication.CommunicationUtils
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;

namespace ATPlatform.Common.Communication
{
  public static class CommunicationUtils
  {
    private static readonly string _wildCard = "*";

    public static byte[] GetSocketIdentityByTenant(byte identity, byte tenant) => new byte[2]
    {
      identity,
      tenant
    };

    public static byte[] GetSocketIdentityByPlatform(
      byte identity,
      byte tenant,
      string platformAddress)
    {
      byte[] bytes = Encoding.UTF8.GetBytes(platformAddress);
      byte[] numArray = new byte[2 + bytes.Length];
      numArray[0] = identity;
      numArray[1] = tenant;
      bytes.CopyTo((Array) numArray, 2);
      return numArray;
    }

    public static string GetSocketIdentity(byte[] identityBytes) => Encoding.ASCII.GetString(identityBytes);

    public static Uri GetApplicationUriByPlatformHost(
      ClientApplicationIds application,
      string platformHost)
    {
      string sectionName = application.ToString();
      string uriString = (string) null;
      object section = ConfigurationManager.GetSection(sectionName);
      string lower = platformHost.ToLower();
      if (section != null)
      {
        NameValueCollection nameValueCollection = section as NameValueCollection;
        Dictionary<string, string> dictionary = ((IEnumerable<string>) nameValueCollection.AllKeys).Select<string, string>((Func<string, string>) (k => k.ToLower())).ToDictionary<string, string, string>((Func<string, string>) (t => t), (Func<string, string>) (t => nameValueCollection[t]));
        if (dictionary.ContainsKey(lower))
          uriString = dictionary[lower].ToString();
        else if (dictionary.ContainsKey(CommunicationUtils._wildCard))
          uriString = dictionary[CommunicationUtils._wildCard].ToString();
      }
      return uriString == null ? (Uri) null : new Uri(uriString);
    }

    public static bool ValidateAddress(string address)
    {
      try
      {
        Uri uri = new Uri(address);
        IPAddress.TryParse(uri.Host, out IPAddress _);
        Dns.GetHostAddresses(uri.Host);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
