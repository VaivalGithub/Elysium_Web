using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SHARED
{
    [DataContract]
    public class ServiceResponse<T>
    {
        [DataMember]
        public T Data { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string Message { get; set; }
        public long TotalCounts { get; set; }

        [DataMember]
        public bool Code { get; set; }

        public ServiceResponse() { }

        public ServiceResponse(ref T data)
        {
            this.Data = data;
        }
    }
}
