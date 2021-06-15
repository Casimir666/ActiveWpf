// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication.WebPlatformAuthenticationMapper
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using ActivTrades.ActivTrader.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ActivTrades.ActivTrader.Authentication.WebPlatformAuthentication
{
  internal static class WebPlatformAuthenticationMapper
  {
    internal static Account Map(this TradingAccount tradingAccount) => new Account()
    {
      AccountId = tradingAccount.AccountNumber,
      Balance = tradingAccount.Balance,
      IsDemoAccount = tradingAccount.IsDemoAccount,
      Name = tradingAccount.UserName,
      Platform = tradingAccount.Platform,
      Status = tradingAccount.Status
    };

    internal static AuthenticationResult Map(
      this Responsedata responseData,
      string authSessionId,
      string authId)
    {
      return new AuthenticationResult()
      {
        Accounts = responseData.TradingAccounts != null ? (IReadOnlyCollection<Account>) new ReadOnlyCollection<Account>((IList<Account>) responseData.TradingAccounts.Select<TradingAccount, Account>((Func<TradingAccount, Account>) (ta => ta.Map())).ToList<Account>()) : (IReadOnlyCollection<Account>) new ReadOnlyCollection<Account>((IList<Account>) new List<Account>()),
        Token = responseData.Key,
        LsMarketDataAdapter = responseData.LsMarketDataAdapter,
        LsMarketDataAdapterSet = responseData.LsMarketDataAdapterSet,
        LsMarketDataHost = responseData.LsMarketDataHost,
        LsTradingAdapter = responseData.LsTradingAdapter,
        LsTradingAdapterSet = responseData.LsTradingAdapterSet,
        LsTradingHost = responseData.LsTradingHost,
        SelectedAccountId = responseData.User.AccountNumber,
        SessionId = authSessionId,
        AuthId = authId
      };
    }

    internal static void Update(
      this AuthenticationResult authenticationResult,
      int account,
      SwitchAccountResult switchAccountResult)
    {
      authenticationResult.SelectedAccountId = account;
      authenticationResult.AuthId = switchAccountResult.AuthId;
      authenticationResult.LsMarketDataAdapter = switchAccountResult.Response.Data.LsMarketDataAdapter;
      authenticationResult.LsMarketDataAdapterSet = switchAccountResult.Response.Data.LsMarketDataAdapterSet;
      authenticationResult.LsMarketDataHost = switchAccountResult.Response.Data.LsMarketDataHost;
      authenticationResult.LsTradingAdapter = switchAccountResult.Response.Data.LsTradingAdapter;
      authenticationResult.LsTradingAdapterSet = switchAccountResult.Response.Data.LsTradingAdapterSet;
      authenticationResult.LsTradingHost = switchAccountResult.Response.Data.LsTradingHost;
    }
  }
}
