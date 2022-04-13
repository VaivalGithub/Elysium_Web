using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Models.Authentication
{
   public class AccountSession
    {
        public string PYR_WalletAddress { get; set; }
        public string VeChain_WalletAddress { get; set; }
        public string UserID { get; set; }
        public string VeriAti_UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string TwoFactorEnabled { get; set; }
        public string TwoFactorValidated { get; set; }
        public string IsTNCAccepted { get; set; }
    }
}
