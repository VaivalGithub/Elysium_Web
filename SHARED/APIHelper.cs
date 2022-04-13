using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SHARED
{
    public class APIHelper
    {

        //POST Call
        public string APIPostCall(string RequestURL, string RerquestType, string AppPath, string Filter = "", Object Data = null)
        {
            String Result = String.Empty;
            try
            {
                var ByteArray = Encoding.ASCII.GetBytes(Filter);
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                if (RerquestType == "HttpWebRequest")
                {
                    Uri URL = new Uri(RequestURL);
                    var Request = (HttpWebRequest)WebRequest.Create(URL);
                    Request.Timeout = 180000;
                    var ByteArrayData = Encoding.ASCII.GetBytes(Filter);

                    Request.Method = "POST";
                    Request.ContentType = "application/json; charset=UTF-8";
                    Request.Accept = "application/json";

                    Request.Headers["api-key"] = "veChain2RxsiIvEtuaPxxvP6eTs98fr55K4xJye3IqEJWhk";

                    Request.ContentLength = ByteArrayData.Length;

                    using (var stream = Request.GetRequestStream())
                    {
                        stream.Write(ByteArrayData, 0, ByteArrayData.Length);
                    }

                    var Response = (HttpWebResponse)Request.GetResponse();
                    Result = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                }
                else if (RerquestType == "WebClient")
                {
                    using (var C = new WebClient())
                    {
                        var Values = new NameValueCollection();
                        Values["Filter"] = Filter;
                        var Res = C.UploadValues(RequestURL, Values);
                        Result = Encoding.Default.GetString(Res);
                    }
                }
                else if (RerquestType == "HttpClient")
                {
                    var client = new HttpClient();

                    var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("pqpUserName", "admin"),
                        new KeyValuePair<string, string>("password", "test@123")
                    };

                    var content = new FormUrlEncodedContent(pairs);

                    var response = client.PostAsync("youruri", content).Result;

                    if (response.IsSuccessStatusCode)
                    {


                    }
                }
            }
            catch(Exception EEEE) {
            
            
            }

            return Result;
        }

        //GET CALL 
        public string APIGetCall(string RequestURL, string RerquestType, string AppPath)
        {
            String Result = String.Empty;
            try
            {
                string URL_Request = RequestURL;

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;

                if (RerquestType == "HttpWebRequest")
                {
                    HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URL_Request);
                    Request.Timeout = 180000;
                    Request.AutomaticDecompression = DecompressionMethods.GZip;
                    Request.Headers["api-key"] = "veChain2RxsiIvEtuaPxxvP6eTs98fr55K4xJye3IqEJWhk";

                    using (HttpWebResponse Response = (HttpWebResponse)Request.GetResponse())
                    using (Stream Stream = Response.GetResponseStream())
                    using (StreamReader Reader = new StreamReader(Stream))
                    {
                        Result = Reader.ReadToEnd();
                    }
                }
                else if (RerquestType == "WebClient")
                {
                   
                    using (var client = new WebClient())
                    {
                        Result = client.DownloadString(URL_Request);
                    }
                }
                else if (RerquestType == "HttpClient")
                {
                    using (var Client = new HttpClient())
                    {

                    }
                }

            }
            catch(Exception EEE) {
                Result = "";
            }

            return Result;
        }

        public string APIPostCall_P(string RequestURL, string RerquestType, string AppPath, string Filter = "", Object Data = null)
        {
            String Result = String.Empty;
            try
            {
                var ByteArray = Encoding.ASCII.GetBytes(Filter);
                ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                if (RerquestType == "HttpWebRequest")
                {
                    Uri URL = new Uri(RequestURL);
                    var Request = (HttpWebRequest)WebRequest.Create(URL);
                    Request.Timeout = 180000;
                    var ByteArrayData = Encoding.ASCII.GetBytes(Filter);

                    Request.Method = "POST";
                    Request.ContentType = "application/json; charset=UTF-8";
                    Request.Accept = "application/json";

                    Request.Headers["Authorization"] = "Bearer SK-47RFEA2F-3QAPRUPT-FXEPWUUL-BVJF4MHR";

                    Request.ContentLength = ByteArrayData.Length;

                    using (var stream = Request.GetRequestStream())
                    {
                        stream.Write(ByteArrayData, 0, ByteArrayData.Length);
                    }

                    var Response = (HttpWebResponse)Request.GetResponse();
                    Result = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                }
                else if (RerquestType == "WebClient")
                {
                    using (var C = new WebClient())
                    {
                        var Values = new NameValueCollection();
                        Values["Filter"] = Filter;
                        var Res = C.UploadValues(RequestURL, Values);
                        Result = Encoding.Default.GetString(Res);
                    }
                }
                else if (RerquestType == "HttpClient")
                {
                    var client = new HttpClient();

                    var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("pqpUserName", "admin"),
                        new KeyValuePair<string, string>("password", "test@123")
                    };

                    var content = new FormUrlEncodedContent(pairs);

                    var response = client.PostAsync("youruri", content).Result;

                    if (response.IsSuccessStatusCode)
                    {


                    }
                }
            }
            catch (Exception EEEE)
            {
                Result = EEEE.Message;
            }

            return Result;
        }

        //GET CALL 
        public string APIGetCall_P(string RequestURL, string RerquestType, string AppPath)
        {
            String Result = String.Empty;
            try
            {
                string URL_Request = RequestURL;

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                if (RerquestType == "HttpWebRequest")
                {
                    HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URL_Request);
                    Request.Timeout = 180000;
                    Request.AutomaticDecompression = DecompressionMethods.GZip;
                    Request.Headers["Authorization"] = "Bearer SK-47RFEA2F-3QAPRUPT-FXEPWUUL-BVJF4MHR";

                    using (HttpWebResponse Response = (HttpWebResponse)Request.GetResponse())
                    using (Stream Stream = Response.GetResponseStream())
                    using (StreamReader Reader = new StreamReader(Stream))
                    {
                        Result = Reader.ReadToEnd();
                    }
                }
                else if (RerquestType == "WebClient")
                {

                    using (var client = new WebClient())
                    {
                        Result = client.DownloadString(URL_Request);
                    }
                }
                else if (RerquestType == "HttpClient")
                {
                    using (var Client = new HttpClient())
                    {

                    }
                }

            }
            catch (Exception EEE)
            {
                Result = "";
            }

            return Result;
        }

        public string APIPatchCall_Land(string RequestURL, string RerquestType, string AppPath, string Filter = "", Object Data = null)
        {
            String Result = String.Empty;
            try
            {
                var ByteArray = Encoding.ASCII.GetBytes(Filter);
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                if (RerquestType == "HttpWebRequest")
                {
                    Uri URL = new Uri(RequestURL);
                    var Request = (HttpWebRequest)WebRequest.Create(URL);
                    Request.Timeout = 180000;
                    var ByteArrayData = Encoding.ASCII.GetBytes(Filter);

                    Request.Method = "PATCH";
                    Request.ContentType = "application/json; charset=UTF-8";
                    Request.Accept = "application/json";

                    Request.Headers["Authorization"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjYwYWU1MDliZmMyMDVlMmRiMGViODgxZCIsInR5cGUiOiJhZG1pbiIsImlhdCI6MTYyNzQ5NTQxMSwiZXhwIjoxNjU5MDUzMDExfQ.eRAGABLCD99SSekPTqn9EyPykWg9wLQhOdmYsKis5LQ";

                    Request.ContentLength = ByteArrayData.Length;

                    using (var stream = Request.GetRequestStream())
                    {
                        stream.Write(ByteArrayData, 0, ByteArrayData.Length);
                    }

                    var Response = (HttpWebResponse)Request.GetResponse();
                    Result = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                }
            }
            catch (WebException EEEE)
            {
                try
                {
                    Result = new StreamReader(EEEE.Response.GetResponseStream()).ReadToEnd();
                }
                catch (Exception ex)
                {
                    Result = EEEE.Message;
                }
            }

            return Result;
        }

        public string APIPostCall_Land(string RequestURL, string RerquestType, string AppPath, string Filter = "", Object Data = null)
        {
            String Result = String.Empty;
            try
            {
                var ByteArray = Encoding.ASCII.GetBytes(Filter);
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                if (RerquestType == "HttpWebRequest")
                {
                    Uri URL = new Uri(RequestURL);
                    var Request = (HttpWebRequest)WebRequest.Create(URL);
                    Request.Timeout = 180000;
                    var ByteArrayData = Encoding.ASCII.GetBytes(Filter);

                    Request.Method = "POST";
                    Request.ContentType = "application/json; charset=UTF-8";
                    Request.Accept = "application/json";

                    Request.Headers["Authorization"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjYwYWU1MDliZmMyMDVlMmRiMGViODgxZCIsInR5cGUiOiJhZG1pbiIsImlhdCI6MTYyNzQ5NTQxMSwiZXhwIjoxNjU5MDUzMDExfQ.eRAGABLCD99SSekPTqn9EyPykWg9wLQhOdmYsKis5LQ";

                    Request.ContentLength = ByteArrayData.Length;

                    using (var stream = Request.GetRequestStream())
                    {
                        stream.Write(ByteArrayData, 0, ByteArrayData.Length);
                    }

                    var Response = (HttpWebResponse)Request.GetResponse();
                    Result = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                }
            }
            catch (Exception EEEE)
            {
                Result = EEEE.Message;
            }

            return Result;
        }


    }
}
