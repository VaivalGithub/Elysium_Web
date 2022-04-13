using CORE.Models;
using SHARED;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVICES.Service.Interfaces
{
    public interface IUser
    {

        #region Market Place

        ServiceResponse<User> InsertOrUpdateUser(long userID, User user);
        ServiceResponse<string> UpdateUserName(long userID, User user);
         ServiceResponse<User> Get_User(long UserID);
        ServiceResponse<bool> AddToWatch(long UserID, long ListingID, int IsWatched);
        ServiceResponse<bool> SaveUserSettings(long UserID, User user);


        #endregion


        #region ADMIN

        ServiceResponse<List<User>> Get_MarketUsers(long userID, int start, int length, string search, string sortOrder);
        ServiceResponse<bool> Disable_User(long gUID, long userID);
        ServiceResponse<bool> Enable_User(long GUID, long UserID);

        #endregion

        #region Landing Page Data
        ServiceResponse<Landing_Data> Get_Landing_Page_Data();
        ServiceResponse<List<Auctions>> Get_Top12_Open_Auctions();
        #endregion

        #region Search Result
        public ServiceResponse<List<SearchResult>> SearchResults(string search);
        #endregion


    }
}
