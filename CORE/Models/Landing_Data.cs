using System;

namespace CORE.Models
{
    public class Landing_Data
    {
        public long TotalUsers { get; set; }
        public decimal TotalUsersPercentage { get; set; }
        public long ActiveUsers { get; set; }
        public decimal ActiveUsersPercentage { get; set; }
        public decimal TradingVolumeMp { get; set; }
        public decimal TradingVolumeMpPercentage { get; set; }
        public decimal TradingVolumeAgora { get; set; }
        public decimal TradingVolumeAgoraPercentage { get; set; }

        public long SoldAuctionsMp { get; set; }
        public decimal SoldAuctionsMpPercentage { get; set; }

        public long SoldAuctionAgora { get; set; }
        public decimal SoldAuctionAgoraPercentage { get; set; }

        public string Logdate { get; set; }
        public long SoldTradesMp { get; set; }
        public decimal SoldTradesMpPercentage { get; set; }

        public long MintedNFTsAgora { get; set; }
        public decimal MintedNFTsAgoraPercentage { get; set; }

    }
}
