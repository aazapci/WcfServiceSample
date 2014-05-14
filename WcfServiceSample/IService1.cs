using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceSample.Model;
using WcfServiceSample.DTO;

namespace WcfServiceSample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string ToplamaYap(int sayi1, int sayi2);

        [OperationContract]
        Ogrenci OgrenciEkle(Ogrenci instance);
        // TODO: Add your service operations here

        [OperationContract]
        CategoriesDTO KategoriSelect(int ID);

        [OperationContract]
        ProductDTO ProductSelectByID(int ID);

        [OperationContract]
        List<CategoriesDTO> GetAllCategories();

        [OperationContract]
        List<ProductDTO> ProductSelectByCategoryID(int categoryID);

        [OperationContract]
        int ProductUpdate(ProductDTO instance);

        [OperationContract]
        int ProductDelete(int ID);

        [OperationContract]
        int ProductAdd(ProductDTO instance);

        [OperationContract]
        List<ProductDTO> ProductSelect();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Ogrenci
    {
        [DataMember]
        public string Ad { get; set; }

        [DataMember]
        public string Soyad { get; set; }
    }
}
