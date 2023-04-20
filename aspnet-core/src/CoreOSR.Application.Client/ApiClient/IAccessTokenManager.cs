﻿using System;
using System.Threading.Tasks;
using CoreOSR.ApiClient.Models;

namespace CoreOSR.ApiClient
{
    public interface IAccessTokenManager
    {
        string GetAccessToken();

        string GetEncryptedAccessToken();

        Task<AbpAuthenticateResultModel> LoginAsync();

        Task<(string accessToken, string encryptedAccessToken)> RefreshTokenAsync();

        void Logout();

        bool IsUserLoggedIn { get; }

        bool IsRefreshTokenExpired { get; }

        AbpAuthenticateResultModel AuthenticateResult { get; set; }

        DateTime AccessTokenRetrieveTime { get; set; }
    }
}