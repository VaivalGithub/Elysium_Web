using CORE.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using SERVICES.Service.Interfaces;
using SHARED;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace SERVICES.Service.Implementations
{
    internal class UserService : IUser
    {

        private static IConfiguration _Configuration;

        public UserService(IConfiguration _configuration)
        {
            _Configuration = _configuration;
        }


        #region Market Place

        public ServiceResponse<User> InsertOrUpdateUser(long UserID, User user)
        {
            ServiceResponse<User> Response = new ServiceResponse<User>();
            User U = new User();
            bool InsertOrUpdateCheck;
            try
            {
                DBAccess DB = new DBAccess("Default");

                MySqlParameter[] sqlParameter = new MySqlParameter[2];
                MySqlParameter P_WalletAddress = new MySqlParameter();
                P_WalletAddress.ParameterName = "P_WalletAddress";
                P_WalletAddress.Value = user.WalletAddress;
                sqlParameter[0] = P_WalletAddress;

                MySqlParameter P_Balance = new MySqlParameter();
                P_Balance.ParameterName = "P_Balance";
                P_Balance.Value = user.Balance;
                sqlParameter[1] = P_Balance;
                ServiceResponse<DataSet> DataSetResponse = new ServiceResponse<DataSet>();
                DB.ExecuteStoreProcedureDataSet(ref DataSetResponse, "SP_InsertOrUpdateUser", sqlParameter);

                if (DataSetResponse.Status == 1)
                {
                    DataTable DT = DataSetResponse.Data.Tables[0];
                    if (DT.Rows.Count > 0)
                    {

                        foreach (DataRow row in DT.Rows)
                        {
                            U.UserID = Convert.ToInt64(row["UserID"]);
                            U.UserName = row["UserName"].ToString();
                            U.WalletAddress = row["WalletAddress"].ToString();
                            U.Balance = Convert.ToDecimal(row["Balance"]);
                            U.LastLogin = Convert.ToDateTime(row["LastLogin"]);
                            U.IsActive = Convert.ToBoolean(row["IsActive"]);
                        }
                    }
                }


                if (!U.IsActive)
                {
                    Response.Data = null;
                    Response.Status = 0;
                    Response.Message = "You Are Not Allowed To Login. Please Contact With Support";
                    return Response;
                }


                Response.Data = U;
                Response.Status = DataSetResponse.Status;
                Response.Message = DataSetResponse.Message;
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<string> UpdateUserName(long UserID, User user)
        {
            ServiceResponse<string> Response = new ServiceResponse<string>();
            bool InsertOrUpdateCheck;
            User U = new User();
            try
            {
                DBAccess DB = new DBAccess("Default");

                MySqlParameter[] sqlParameter = new MySqlParameter[2];
                MySqlParameter P_UserID = new MySqlParameter();
                P_UserID.ParameterName = "P_UserID";
                P_UserID.Value = UserID;
                sqlParameter[0] = P_UserID;

                MySqlParameter P_UserName = new MySqlParameter();
                P_UserName.ParameterName = "P_UserName";
                P_UserName.Value = user.UserName;
                sqlParameter[1] = P_UserName;
                ServiceResponse<DataSet> DataSetResponse = new ServiceResponse<DataSet>();
                DB.ExecuteStoreProcedureDataSet(ref DataSetResponse, "SP_UpdateUserName", sqlParameter);

                if (DataSetResponse.Status == 1)
                {
                    DataTable DT = DataSetResponse.Data.Tables[0];
                    if (DT.Rows.Count > 0)
                    {

                        foreach (DataRow row in DT.Rows)
                        {
                            U.UserName = row["UserName"].ToString();
                        }
                    }
                }

                Response.Data = U.UserName;
                Response.Status = DataSetResponse.Status;
                Response.Message = DataSetResponse.Message;
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }


        public ServiceResponse<User> Get_User(long UserID)
        {
            ServiceResponse<User> Response = new ServiceResponse<User>();
            User U = new User();
            bool InsertOrUpdateCheck;
            try
            {
                DBAccess DB = new DBAccess("Default");

                MySqlParameter[] sqlParameter = new MySqlParameter[1];
                MySqlParameter P_UserID = new MySqlParameter();
                P_UserID.ParameterName = "P_UserID";
                P_UserID.Value = UserID;
                sqlParameter[0] = P_UserID;

                ServiceResponse<DataSet> DataSetResponse = new ServiceResponse<DataSet>();
                DB.ExecuteStoreProcedureDataSet(ref DataSetResponse, "SP_GetUser", sqlParameter);

                if (DataSetResponse.Status == 1)
                {
                    DataTable DT = DataSetResponse.Data.Tables[0];
                    if (DT.Rows.Count > 0)
                    {

                        foreach (DataRow row in DT.Rows)
                        {
                            U.UserID = Convert.ToInt64(row["UserID"]);
                            U.UserName = row["UserName"].ToString();
                            U.WalletAddress = row["WalletAddress"].ToString();
                            U.Balance = Convert.ToDecimal(row["Balance"]);
                            U.LastLogin = Convert.ToDateTime(row["LastLogin"]);
                        }
                    }
                }



                Response.Data = U;
                Response.Status = DataSetResponse.Status;
                Response.Message = DataSetResponse.Message;
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<bool> AddToWatch(long UserID, long ListingID, int IsWatched)
        {
            ServiceResponse<bool> Response = new ServiceResponse<bool>();
            string QUERY = "";
            try
            {
                DBAccess DefaultDB = new DBAccess("Default");

                if (IsWatched == 1) // Already Watched
                {
                    QUERY = @"DELETE FROM listing_watch WHERE ListingID = " + ListingID + " AND UserID = " + UserID + "";
                    Response.Message = "Listing Removed From Your Favourite List";
                }
                else
                {
                    QUERY = @"INSERT INTO listing_watch (ListingID,UserID)
						                    VALUES (" + ListingID + "," + UserID + ")";
                    Response.Message = "Listing Add To Your Favourite List";
                }

                DefaultDB.EXECUTE_NON_QUERY(QUERY);

                Response.Data = true;
                Response.Status = 1;
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<bool> SaveUserSettings(long UserID, User user)
        {
            ServiceResponse<bool> Response = new ServiceResponse<bool>();
            string QUERY = "";
            try
            {
                DBAccess DefaultDB = new DBAccess("Default");

                QUERY = @"UPDATE users
                SET Email = '" + user.Email + @"' , ItemSold = " + user.ItemSold + @" , ItemPurchased = " + user.ItemPurchased + @"
                WHERE UserID = " + UserID + "";
                DefaultDB.EXECUTE_NON_QUERY(QUERY);

                Response.Data = true;
                Response.Status = 1;
                Response.Message = "Your Setting Saved Successfully";
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        #endregion


        #region ADMIN

        public ServiceResponse<List<User>> Get_MarketUsers(long userID, int Start, int Length, string Search, string sortOrder)
        {
            ServiceResponse<List<User>> Response = new ServiceResponse<List<User>>();
            string QUERY = "";
            try
            {
                DBAccess DefaultDB = new DBAccess("Default");
                List<User> LU = new List<User>();

                QUERY = @"SELECT
                                        U.*,
                                        (SELECT COUNT(1) FROM listings WHERE UserID = U.UserID) AS NoOfAuctions
                                    FROM
                                        users U
                                    WHERE U.WalletAddress LIKE '%" + Search + "%' OR U.UserName LIKE '%" + Search + "%' " +
                                  " ORDER BY CreatedDate DESC LIMIT " + Start + " , " + Length + " ";
                DataTable dt = DefaultDB.EXECUTE_DATATABLE(QUERY);
                if (dt.Rows.Count > 0)
                {
                    LU = dt.AsEnumerable().Select(reader => new User
                    {
                        UserID = reader["UserID"] == DBNull.Value ? 0 : Convert.ToInt64(reader["UserID"]),
                        WalletAddress = reader["WalletAddress"] == DBNull.Value ? "" : reader["WalletAddress"].ToString(),
                        UserName = reader["UserName"] == DBNull.Value ? "" : reader["UserName"].ToString(),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        LastLogin = Convert.ToDateTime(reader["LastLogin"]),
                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                        NoOfAuctions = reader["NoOfAuctions"] == DBNull.Value ? 0 : Convert.ToInt64(reader["NoOfAuctions"])
                    }).ToList();
                }
                else
                {
                    Response.TotalCounts = 0;
                    Response.Message = "No Data To Show";
                }

                Response.Data = LU;
                QUERY = @"SELECT COUNT(1) FROM users";
                Response.TotalCounts = DefaultDB.EXECUTE_SCALAR(QUERY);

                Response.Status = 1;
                Response.Message = "OKAY";
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Data = null;
                Response.TotalCounts = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<bool> Disable_User(long GUID, long UserID)
        {
            ServiceResponse<bool> Response = new ServiceResponse<bool>();
            string QUERY = "";
            try
            {
                DBAccess DefaultDB = new DBAccess("Default");

                QUERY = @"UPDATE users
                SET IsActive = 0
                WHERE UserID = " + UserID + "";
                DefaultDB.EXECUTE_NON_QUERY(QUERY);

                Response.Data = true;
                Response.Status = 1;
                Response.Message = "User Disable Successfully";
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<bool> Enable_User(long GUID, long UserID)
        {
            ServiceResponse<bool> Response = new ServiceResponse<bool>();
            string QUERY = "";
            try
            {
                DBAccess DefaultDB = new DBAccess("Default");

                QUERY = @"UPDATE users
                SET IsActive = 1
                WHERE UserID = " + UserID + "";
                DefaultDB.EXECUTE_NON_QUERY(QUERY);

                Response.Data = true;
                Response.Status = 1;
                Response.Message = "User Disable Successfully";
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        #endregion


        #region API



        #endregion


        #region SOCKETS



        #endregion


        public ServiceResponse<Landing_Data> Get_Landing_Page_Data()
        {
            ServiceResponse<Landing_Data> Response = new ServiceResponse<Landing_Data>();
            string QUERY = "";
            try
            {
                DBAccess DefaultDB = new DBAccess("Default");
                Landing_Data LU = new Landing_Data();
                Landing_Data LU_Prev = new Landing_Data();

                QUERY = @"select TotalUsers, ActiveUsers,TradingVolumeMp,SoldAuctionsMp,SoldAuctionAgora,TradingVolumeAgora, LogDate,SoldTradesMp,MintedNFTsAgora from web_data order by ID desc Limit 1;";
                DataTable dt = DefaultDB.EXECUTE_DATATABLE(QUERY);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        LU.TotalUsers = row["TotalUsers"] == DBNull.Value ? 0 : Convert.ToInt64(row["TotalUsers"]);
                        LU.ActiveUsers = row["ActiveUsers"] == DBNull.Value ? 0 : Convert.ToInt64(row["ActiveUsers"]);
                        LU.TradingVolumeMp = row["TradingVolumeMp"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TradingVolumeMp"]);
                        LU.TradingVolumeAgora = row["TradingVolumeAgora"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TradingVolumeAgora"]);
                        LU.SoldAuctionsMp = row["SoldAuctionsMp"] == DBNull.Value ? 0 : Convert.ToInt64(row["SoldAuctionsMp"]);
                        LU.SoldAuctionAgora = row["SoldAuctionAgora"] == DBNull.Value ? 0 : Convert.ToInt64(row["SoldAuctionAgora"]);
                        LU.Logdate = row["LogDate"] == DBNull.Value ? "" : Convert.ToString(row["LogDate"]);
                        LU.SoldTradesMp = row["SoldTradesMp"] == DBNull.Value ? 0 : Convert.ToInt64(row["SoldTradesMp"]);
                        LU.MintedNFTsAgora = row["MintedNFTsAgora"] == DBNull.Value ? 0 : Convert.ToInt64(row["MintedNFTsAgora"]);
                    }

                    //var datetime = LU.Logdate.Split(':');
                    //var date = datetime[0];
                    var date = DateTime.UtcNow.AddDays(-1).ToString("yyyy-MM-dd HH");


                    QUERY = @"select TotalUsers, ActiveUsers,TradingVolumeMp,SoldAuctionsMp,SoldAuctionAgora,TradingVolumeAgora, LogDate,SoldTradesMp,MintedNFTsAgora from web_data_Prev where LogDate like '" + date + @"%';";
                    DataTable dt2 = DefaultDB.EXECUTE_DATATABLE(QUERY);
                    if (dt2.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt2.Rows)
                        {
                            LU_Prev.TotalUsers = row["TotalUsers"] == DBNull.Value ? 0 : Convert.ToInt64(row["TotalUsers"]);
                            LU_Prev.ActiveUsers = row["ActiveUsers"] == DBNull.Value ? 0 : Convert.ToInt64(row["ActiveUsers"]);
                            LU_Prev.TradingVolumeMp = row["TradingVolumeMp"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TradingVolumeMp"]);
                            LU_Prev.TradingVolumeAgora = row["TradingVolumeAgora"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TradingVolumeAgora"]);
                            LU_Prev.SoldAuctionsMp = row["SoldAuctionsMp"] == DBNull.Value ? 0 : Convert.ToInt64(row["SoldAuctionsMp"]);
                            LU_Prev.SoldAuctionAgora = row["SoldAuctionAgora"] == DBNull.Value ? 0 : Convert.ToInt64(row["SoldAuctionAgora"]);
                            LU_Prev.Logdate = row["LogDate"] == DBNull.Value ? "" : Convert.ToString(row["LogDate"]);
                            LU_Prev.SoldTradesMp = row["SoldTradesMp"] == DBNull.Value ? 0 : Convert.ToInt64(row["SoldTradesMp"]);
                            LU_Prev.MintedNFTsAgora = row["MintedNFTsAgora"] == DBNull.Value ? 0 : Convert.ToInt64(row["MintedNFTsAgora"]);
                        }
                    }
                    LU.TotalUsersPercentage = (decimal)((decimal)(LU.TotalUsers - LU_Prev.TotalUsers) / LU.TotalUsers) * 100;
                    LU.ActiveUsersPercentage = (decimal)((decimal)(LU.ActiveUsers - LU_Prev.ActiveUsers) / LU.ActiveUsers) * 100;
                    LU.TradingVolumeMpPercentage = (decimal)((decimal)(LU.TradingVolumeMp - LU_Prev.TradingVolumeMp) / LU.TradingVolumeMp) * 100;
                    LU.TradingVolumeAgoraPercentage = (decimal)((decimal)(LU.TradingVolumeAgora - LU_Prev.TradingVolumeAgora) / LU.TradingVolumeAgora) * 100;
                    LU.SoldAuctionsMpPercentage = (decimal)((decimal)(LU.SoldAuctionsMp - LU_Prev.SoldAuctionsMp) / LU.SoldAuctionsMp) * 100;
                    LU.SoldAuctionAgoraPercentage = (decimal)((decimal)(LU.SoldAuctionAgora - LU_Prev.SoldAuctionAgora) / LU.SoldAuctionAgora) * 100;
                    LU.SoldTradesMpPercentage = (decimal)((decimal)(LU.SoldTradesMp - LU_Prev.SoldTradesMp) / LU.SoldTradesMp) * 100;
                    LU.MintedNFTsAgoraPercentage = (decimal)((decimal)(LU.MintedNFTsAgora - LU_Prev.MintedNFTsAgora) / LU.MintedNFTsAgora) * 100;


                    Response.Data = LU;
                    Response.Status = 1;
                    Response.Message = "OKAY";
                }
                else
                {
                    Response.Data = null;
                    Response.Message = "No Data To Show";
                }
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Data = null;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<List<Auctions>> Get_Top12_Open_Auctions()
        {
            ServiceResponse<List<Auctions>> Response = new ServiceResponse<List<Auctions>>();
            string QUERY = "";
            DBAccess DefaultDB = new DBAccess("Default");
            List<Auctions> LA = new List<Auctions>();
            try
            {
                QUERY = @"SELECT
                                            COUNT(*) OVER() AS TotalCount,
                                            A.Description AS DefaultDescription,
                                            A.DappID AS DefaultDappID,
                                            A.TokenID AS DefaultTokenID,
                                            A.Image AS DefaultImage,
                                            A.AuctionID,
                                            A.UserID,
                                            A.Title AS DefaultTitle,
                                            A.ExpiryDate,
                                            A.BidStartingPrice,
                                            A.BuyNowPrice,
                                            (select (case when min(B.Price) is null then 0 else min(B.Price) end) from bids B where A.AuctionID = B.AuctionID) as MinBidPrice,
                                            (select (case when max(B.Price) is null then 0 else max(B.Price) end) from bids B where A.AuctionID = B.AuctionID) as MaxBidPrice,
                                            (select COUNT(B.BidID) from bids B where A.AuctionID = B.AuctionID) as BidsCount,
                                            A.CreatedDate,
                                            A.UpdatedDate,
                                            A.IsClosed,
                                            A.PurchasedBy,
                                            (SELECT COUNT(1) FROM auctionswatch WHERE AuctionID = A.AuctionID) AS WatchedCount,
                                       
                                            A.IsActive,
                                            GROUP_CONCAT(ATT.TokenID) AS AllTokens,
                                            GROUP_CONCAT(ATT.Title SEPARATOR '|||') AS Titles,
                                            GROUP_CONCAT(ATT.CompleteObject SEPARATOR '|||') AS CompleteObjects,
                                            GROUP_CONCAT(ATT.Image) AS Images,
                                            GROUP_CONCAT(ATT.DappID) AS DappIDs
                                            FROM auctions A
                                            INNER JOIN
                                            auction_tokens ATT ON A.AuctionID = ATT.AuctionID
                                            where A.IsActive = 1 AND A.IsClosed = 0 AND A.ExpiryDate > UTC_TIMESTAMP() and A.IsAgoraAuction = 0
																						GROUP BY A.AuctionID ORDER BY A.ExpiryDate desc limit 12";
                DataTable dt = DefaultDB.EXECUTE_DATATABLE(QUERY);
                if (dt.Rows.Count > 0)
                {
                    LA = dt.AsEnumerable().Select(reader => new Auctions
                    {
                        AuctionID = Convert.ToInt64(reader["AuctionID"]),
                        UserID = Convert.ToInt64(reader["UserID"]),
                        //UserName = reader["UserName"].ToString(),
                        Title = reader["DefaultTitle"].ToString(),
                        TokenID = Convert.ToInt64(reader["DefaultTokenID"]),
                        Image = reader["DefaultImage"].ToString(),
                        DappID = Convert.ToInt64(reader["DefaultDappID"]),
                        Description = reader["DefaultDescription"].ToString(),
                        ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]),
                        BidStartingPrice = Convert.ToDecimal(reader["BidStartingPrice"]),
                        BuyNowPrice = Convert.ToDecimal(reader["BuyNowPrice"]),
                        BidsCount = Convert.ToInt64(reader["BidsCount"]),
                        MinBidPrice = Convert.ToDecimal(reader["MinBidPrice"]),
                        MaxBidPrice = Convert.ToDecimal(reader["MaxBidPrice"]),
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                        UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]),
                        IsClosed = Convert.ToBoolean(reader["IsClosed"]),
                        PurchasedBy = Convert.ToInt64(reader["PurchasedBy"]),
                        WatchedCount = Convert.ToInt64(reader["WatchedCount"]),
                        //IsWatched = Convert.ToInt64(reader["IsWatched"]),
                        //HumanizerExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]).Humanize().ToString(),
                        //HideCount = Convert.ToInt64(reader["HideCount"]),

                        AllTokens = reader["AllTokens"].ToString(),
                        Titles = reader["Titles"].ToString(),
                        CompleteObjects = reader["CompleteObjects"].ToString(),
                        Images = reader["Images"].ToString(),
                        DappIDs = reader["DappIDs"].ToString()

                    }).Where(X => X.HideCount == 0).ToList();
                }
                Response.Data = LA;
                Response.Status = 1;
                Response.Message = "OKAY";
            }
            catch (Exception EEE)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }

        public ServiceResponse<List<SearchResult>> SearchResults(string search)
        {
            ServiceResponse<List<SearchResult>> Response = new ServiceResponse<List<SearchResult>>();
            string QUERY = "";
            DBAccess DefaultDB = new DBAccess("Default");
            SearchResult LA = new SearchResult();
            List<SearchResult> Searches = new List<SearchResult>();
            try
            {
                QUERY = @"Select ID, Title,Description,Link from veriati.search_results where Content like '%" + search + @"%';";
                DataTable dt = DefaultDB.EXECUTE_DATATABLE(QUERY);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        LA.ID = row["ID"] == DBNull.Value ? 0 : Convert.ToInt64(row["ID"]);
                        LA.Title = row["Title"] == DBNull.Value ? "" : Convert.ToString(row["Title"]);
                        LA.Description = row["Description"] == DBNull.Value ? "" : Convert.ToString(row["Description"]);
                        LA.Link = row["Link"] == DBNull.Value ? "" : Convert.ToString(row["Link"]);

                        var abc = LA.Link.Split('#');
                        var def = abc[1].Split('-');
                        
                        LA.Address = def[0];
                        Searches.Add(LA);

                    }
                }
                Response.Data = Searches;
                Response.TotalCounts = dt.Rows.Count;
                Response.Status = 1;
                Response.Message = "OKAY";
            }
            catch (Exception EEE)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }
            return Response;
        }


    }
}
