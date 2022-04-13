using System;

namespace CORE.Models
{
    public class User
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string WalletAddress { get; set; }
        public decimal Balance { get; set; }

        public string Email { get; set; }
        public bool ItemSold { get; set; }
        public bool ItemPurchased { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime Last_NFT_Updated { get; set; }
        
        public long NoOfBids { get; set; }
        public long NoOfAuctions { get; set; }
        public bool IsActive { get; set; }
    }
}
