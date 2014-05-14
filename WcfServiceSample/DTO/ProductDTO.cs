using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WcfServiceSample.DTO
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public int CategoryID { get; set; }

        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public int UnitsInStock { get; set; }
    }
}