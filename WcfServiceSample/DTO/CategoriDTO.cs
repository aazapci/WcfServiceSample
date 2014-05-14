using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WcfServiceSample.DTO
{
    [DataContract]
    public class CategoriDTO
    {
        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int CatID { get; set; }
        

    }
}