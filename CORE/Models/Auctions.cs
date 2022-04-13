using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Models
{
    public class Auctions
    {
        public long AuctionID { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string AuctionOwner_Wallet { get; set; }
        public string AuctionOwner_Wallet_PYR { get; set; }
        public long CategoryID { get; set; }
        public long AuctionOwner { get; set; }
        public long Bidder { get; set; }
        public string BestBidderWallet { get; set; }
        public string BestBidderUserName { get; set; }
        public string CategoryName { get; set; }
        public long TokenID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal BidStartingPrice { get; set; }
        public decimal BuyNowPrice { get; set; }
        public decimal MinBidPrice { get; set; }
        public decimal MaxBidPrice { get; set; }
        public decimal BidPrice { get; set; }
        public decimal MinimumHigherBid { get; set; }

        public bool IsClosed { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long PurchasedBy { get; set; }
        public decimal PurchasedPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public string HumanizerExpiryDate { get; set; }
        public string UTCExpiryDate { get; set; }
        public long BidsCount { get; set; }
        public long WatchedCount { get; set; }
        public long HideCount { get; set; }
        public long IsWatched { get; set; }
        public User Auction_Owner { get; set; }
        public User Purchase_Owner { get; set; }
        public long BidID { get; set; }
        public bool Status { get; set; }
        public bool IsActive { get; set; }
        public bool CancelRequest { get; set; }
        public bool BuyNowRequest { get; set; }
        public long DappID { get; set; }
        public decimal MinimumBidRise { get; set; }
        public decimal MaxAutoBid { get; set; }

        //public List<Token> Tokens { get; set; }

        public string AllTokens { get; set; }
        public string Titles { get; set; }
        public string CompleteObjects { get; set; }
        public string Images { get; set; }
        public string DappIDs { get; set; }
        public bool IsAgora { get; set; }
        public string PinCode { get; set; }  //for validation
        public string TwoFactorCode { get; set; }  //for validation
        public List<string> TokenIDs { get; set; }  //to receive tokens array
        public long TotalCount { get; set; }
        public decimal ArtID { get; set; }
    }
}
