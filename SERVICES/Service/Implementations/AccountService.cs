using CORE.Models;
using Microsoft.Extensions.Configuration;
using SERVICES.Service.Interfaces;
using SHARED;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SERVICES.Service.Implementations
{
    internal class AccountService : IAccount
    {

        private static IConfiguration _Configuration;
        private static ConcurrentDictionary<string, object> _locks = new ConcurrentDictionary<string, object>();

        public AccountService(IConfiguration _configuration)
        {
            _Configuration = _configuration;
        }


        public ServiceResponse<Account> AdminAuth(Account account)
        {
            ServiceResponse<Account> Response = new ServiceResponse<Account>();
            Account A = new Account();
            try
            {
                string QUERY = "";
                DBAccess DB = new DBAccess("Default");

                QUERY = @"SELECT * FROM account WHERE Email = '" + account.Email + "' AND Password = '" + account.Password + "'";

                DataTable DT = DB.EXECUTE_DATATABLE(QUERY);

                if (DT.Rows.Count > 0)
                {

                    foreach (DataRow row in DT.Rows)
                    {
                        A.AccountID = Convert.ToInt64(row["AccountID"]);
                        A.UserName = row["UserName"].ToString();
                        A.LastLogin = Convert.ToDateTime(row["LastLogin"]);
                        A.Email = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();
                        A.CreatedDate = Convert.ToDateTime(row["CreatedDate"]);
                        A.UpdatedDate = Convert.ToDateTime(row["UpdatedDate"]);
                        A.CreatedBy = Convert.ToInt64(row["CreatedBy"]);
                    }
                }

                if (A.AccountID != null && A.AccountID != 0)
                {
                    Response.Status = 1;
                    Response.Message = "Successfully Login";
                }
                else
                {
                    Response.Status = 0;
                    Response.Message = "Invalid Login";
                }


                Response.Data = A;
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = "Something Went Wrong";
            }
            finally { }

            return Response;
        }


    }
}
