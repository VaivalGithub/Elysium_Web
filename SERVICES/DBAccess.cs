
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using SHARED;
using System;
using System.Data;
using System.IO;

namespace SERVICES
{
    public class DBAccess
    {
        public static IConfigurationRoot Configuration { get; set; }
        public static string ConnStr;

        public DBAccess(string DBName) {

            if (DBName == "Default")
            {
                ConnStr = GetAppSettingValues("ConnectionStrings", "DefaultConnection");
            }
            else if(DBName == "Coins")
            {
                ConnStr = GetAppSettingValues("ConnectionStrings", "CoinsConnection");
            }

        }    

        void OpenConection(MySqlConnection CON)
        {
            try
            {
                if (CON.State == ConnectionState.Closed)
                {
                    CON.Open();
                }
            }
            catch (Exception ex)
            {
                OpenConection(CON);
            }
        }

        public DataTable EXECUTE_DATATABLE(string QUERY)
        {
            DataTable Response = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.CommandText = QUERY;
                        Response.Load(command.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                Response = null;
            }

            return Response;
        }

        public bool EXECUTE_NON_QUERY(string QUERY)
        {
            bool Response = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.CommandText = QUERY;
                        command.ExecuteNonQuery();
                        Response = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Response = false;
            }

            return Response;
        }

        public long EXECUTE_SCALAR(string QUERY)
        {
            long Response = -1;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.CommandText = QUERY;
                        Response =  Convert.ToInt64(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Response = -1;
            }

            return Response;
        }

        public string EXECUTE_SCALAR_STRING(string QUERY)
        {
            string Response = "";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.CommandText = QUERY;
                        Response = Convert.ToString(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Response = "";
            }

            return Response;
        }

        public decimal EXECUTE_SCALAR_DECIMAL(string QUERY)
        {
            decimal Response = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.CommandText = QUERY;
                        Response = Convert.ToDecimal(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Response = 0;
            }

            return Response;
        }

        public void ExecuteStoreProcedure(string spName, MySqlParameter[] sqlParameter)
        {
            string strResponse = "";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        command.Parameters.AddRange(sqlParameter);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                //ExecuteStoreProcedure(spName, sqlParameter);
            }
        }

        public ServiceResponse<string> ExecuteStoreProcedureString(ref ServiceResponse<string> serviceResponse, string spName, MySqlParameter[] sqlParameter)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParameter != null)
                        {
                            command.Parameters.AddRange(sqlParameter);
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = command;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        serviceResponse.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        serviceResponse.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                        if (serviceResponse.Status == 1)
                        {
                            serviceResponse.Data = Convert.ToString(ds.Tables[1].Rows[0][0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //serviceResponse = ExecuteStoreProcedureString(ref serviceResponse, spName, sqlParameter);
            }
            return serviceResponse;
        }

        public ServiceResponse<DataTable> ExecuteStoreProcedureDataTable(ref ServiceResponse<DataTable> serviceResponse, string spName, MySqlParameter[] sqlParameter)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParameter != null)
                        {
                            command.Parameters.AddRange(sqlParameter);
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = command;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        serviceResponse.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        serviceResponse.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                        if (serviceResponse.Status == 1)
                        {
                            serviceResponse.Data = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //serviceResponse = ExecuteStoreProcedureDataTable(ref serviceResponse, spName, sqlParameter);
            }
            return serviceResponse;
        }

        public ServiceResponse<DataSet> ExecuteStoreProcedureDataSet(ref ServiceResponse<DataSet> serviceResponse, string spName, MySqlParameter[] sqlParameter)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParameter != null)
                        {
                            command.Parameters.AddRange(sqlParameter);
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = command;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        serviceResponse.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        serviceResponse.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                        if (serviceResponse.Status == 1)
                        {
                            DataSet dataSet = new DataSet();
                            //for(int i = 0; i < ds.Tables.Count; i++)
                            {
                                DataTable dt = ds.Tables[1].Copy();
                                dataSet.Tables.Add(dt);
                            }
                            serviceResponse.Data = dataSet;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //serviceResponse = ExecuteStoreProcedureDataSet(ref serviceResponse, spName, sqlParameter);
            }
            return serviceResponse;
        }

        public ServiceResponse<dynamic> ExecuteStoreProcedureDynamic(ref ServiceResponse<dynamic> serviceResponse, string spName, MySqlParameter[] sqlParameter)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParameter != null)
                        {
                            command.Parameters.AddRange(sqlParameter);
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = command;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        serviceResponse.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        serviceResponse.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                        if (serviceResponse.Status == 1)
                        {
                            serviceResponse.Data = Convert.ToString(ds.Tables[1].Rows[0][0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               // serviceResponse = ExecuteStoreProcedureDynamic(ref serviceResponse, spName, sqlParameter);
            }
            return serviceResponse;
        }

        public ServiceResponse<bool> ExecuteStoreProcedureStatus(ref ServiceResponse<bool> serviceResponse, string spName, MySqlParameter[] sqlParameter)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        OpenConection(connection);
                        command.Connection = connection;
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParameter != null)
                        {
                            command.Parameters.AddRange(sqlParameter);
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = command;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        serviceResponse.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        serviceResponse.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                        if (serviceResponse.Status == 1)
                        {
                            serviceResponse.Data = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //serviceResponse = ExecuteStoreProcedureStatus(ref serviceResponse, spName, sqlParameter);
            }
            return serviceResponse;
        }

        public static string GetAppSettingValues(string Section, string Key)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            return Configuration.GetSection(Section).GetSection(Key).Value;
        }
    }
}
