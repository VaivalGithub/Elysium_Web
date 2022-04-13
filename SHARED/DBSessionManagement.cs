using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace SHARED
{
    public class DBSessionManagement
    {

        private readonly IDistributedCache _cache;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DBSessionManagement(IDistributedCache cache, IHttpContextAccessor httpContextAccessor)
        {
            _cache = cache;
            _httpContextAccessor = httpContextAccessor;
        }
        public AccountSessions SessionData
        {
            get
            {
                string cookie = _httpContextAccessor.HttpContext.Request.Cookies["GeneralCookie"];
                AccountSessions _accountSession = new AccountSessions();
                if (cookie != null)
                {
                    var decryptedKey = Encryption.Decrypt(cookie);
                    var dbSesion = _cache.GetString($"UserSession-{decryptedKey.Split("|||")[0]}{cookie}");
                    if (!string.IsNullOrEmpty(dbSesion))
                    {
                        _accountSession = JsonConvert.DeserializeObject<AccountSessions>(dbSesion);

                        var isTwoFactorValidated = _accountSession.TwoFactorValidated;
                        if (isTwoFactorValidated != "1")
                        {
                            return new AccountSessions() { Email = null, Image = null, IP = null, IsTNCAccepted = null, PYR_WalletAddress = null, TwoFactorEnabled = null, TwoFactorValidated = null, UserID = null, UserName = null, VeChain_WalletAddress = null };
                        }

                        _accountSession.IP = decryptedKey.Split("|||").Length > 2 ? decryptedKey.Split("|||")[2] : "";
                    }
                    return _accountSession;
                }
                else
                {
                    return _accountSession;
                }
            }
        }
    }

    public class AccountSessions
    {
        public string PYR_WalletAddress { get; set; }
        public string VeChain_WalletAddress { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string TwoFactorEnabled { get; set; }
        public string TwoFactorValidated { get; set; }
        public string IsTNCAccepted { get; set; }
        public string IP { get; set; }

    }

}
