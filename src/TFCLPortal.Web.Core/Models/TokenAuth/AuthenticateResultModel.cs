﻿namespace TFCLPortal.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public long UserId { get; set; }
        public string branchcode { get; set; }
        public string AndroidID { get; set; }
    }
}
