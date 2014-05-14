﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFAServiceSample.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfServiceSample.CompositeType GetDataUsingDataContract(WcfServiceSample.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfServiceSample.CompositeType> GetDataUsingDataContractAsync(WcfServiceSample.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToplamaYap", ReplyAction="http://tempuri.org/IService1/ToplamaYapResponse")]
        string ToplamaYap(int sayi1, int sayi2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToplamaYap", ReplyAction="http://tempuri.org/IService1/ToplamaYapResponse")]
        System.Threading.Tasks.Task<string> ToplamaYapAsync(int sayi1, int sayi2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OgrenciEkle", ReplyAction="http://tempuri.org/IService1/OgrenciEkleResponse")]
        WcfServiceSample.Ogrenci OgrenciEkle(WcfServiceSample.Ogrenci instance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OgrenciEkle", ReplyAction="http://tempuri.org/IService1/OgrenciEkleResponse")]
        System.Threading.Tasks.Task<WcfServiceSample.Ogrenci> OgrenciEkleAsync(WcfServiceSample.Ogrenci instance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategoriSelect", ReplyAction="http://tempuri.org/IService1/KategoriSelectResponse")]
        WcfServiceSample.DTO.CategoriDTO KategoriSelect(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategoriSelect", ReplyAction="http://tempuri.org/IService1/KategoriSelectResponse")]
        System.Threading.Tasks.Task<WcfServiceSample.DTO.CategoriDTO> KategoriSelectAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrunSelect", ReplyAction="http://tempuri.org/IService1/UrunSelectResponse")]
        WcfServiceSample.DTO.ProductDTO UrunSelect(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrunSelect", ReplyAction="http://tempuri.org/IService1/UrunSelectResponse")]
        System.Threading.Tasks.Task<WcfServiceSample.DTO.ProductDTO> UrunSelectAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kategoriSec", ReplyAction="http://tempuri.org/IService1/kategoriSecResponse")]
        WcfServiceSample.DTO.CategoriDTO[] kategoriSec();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kategoriSec", ReplyAction="http://tempuri.org/IService1/kategoriSecResponse")]
        System.Threading.Tasks.Task<WcfServiceSample.DTO.CategoriDTO[]> kategoriSecAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrunSec", ReplyAction="http://tempuri.org/IService1/UrunSecResponse")]
        WcfServiceSample.DTO.ProductDTO[] UrunSec(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UrunSec", ReplyAction="http://tempuri.org/IService1/UrunSecResponse")]
        System.Threading.Tasks.Task<WcfServiceSample.DTO.ProductDTO[]> UrunSecAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/productUpdate", ReplyAction="http://tempuri.org/IService1/productUpdateResponse")]
        int productUpdate(WcfServiceSample.DTO.ProductDTO instance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/productUpdate", ReplyAction="http://tempuri.org/IService1/productUpdateResponse")]
        System.Threading.Tasks.Task<int> productUpdateAsync(WcfServiceSample.DTO.ProductDTO instance);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WFAServiceSample.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WFAServiceSample.ServiceReference1.IService1>, WFAServiceSample.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfServiceSample.CompositeType GetDataUsingDataContract(WcfServiceSample.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfServiceSample.CompositeType> GetDataUsingDataContractAsync(WcfServiceSample.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string ToplamaYap(int sayi1, int sayi2) {
            return base.Channel.ToplamaYap(sayi1, sayi2);
        }
        
        public System.Threading.Tasks.Task<string> ToplamaYapAsync(int sayi1, int sayi2) {
            return base.Channel.ToplamaYapAsync(sayi1, sayi2);
        }
        
        public WcfServiceSample.Ogrenci OgrenciEkle(WcfServiceSample.Ogrenci instance) {
            return base.Channel.OgrenciEkle(instance);
        }
        
        public System.Threading.Tasks.Task<WcfServiceSample.Ogrenci> OgrenciEkleAsync(WcfServiceSample.Ogrenci instance) {
            return base.Channel.OgrenciEkleAsync(instance);
        }
        
        public WcfServiceSample.DTO.CategoriDTO KategoriSelect(int id) {
            return base.Channel.KategoriSelect(id);
        }
        
        public System.Threading.Tasks.Task<WcfServiceSample.DTO.CategoriDTO> KategoriSelectAsync(int id) {
            return base.Channel.KategoriSelectAsync(id);
        }
        
        public WcfServiceSample.DTO.ProductDTO UrunSelect(int id) {
            return base.Channel.UrunSelect(id);
        }
        
        public System.Threading.Tasks.Task<WcfServiceSample.DTO.ProductDTO> UrunSelectAsync(int id) {
            return base.Channel.UrunSelectAsync(id);
        }
        
        public WcfServiceSample.DTO.CategoriDTO[] kategoriSec() {
            return base.Channel.kategoriSec();
        }
        
        public System.Threading.Tasks.Task<WcfServiceSample.DTO.CategoriDTO[]> kategoriSecAsync() {
            return base.Channel.kategoriSecAsync();
        }
        
        public WcfServiceSample.DTO.ProductDTO[] UrunSec(int id) {
            return base.Channel.UrunSec(id);
        }
        
        public System.Threading.Tasks.Task<WcfServiceSample.DTO.ProductDTO[]> UrunSecAsync(int id) {
            return base.Channel.UrunSecAsync(id);
        }
        
        public int productUpdate(WcfServiceSample.DTO.ProductDTO instance) {
            return base.Channel.productUpdate(instance);
        }
        
        public System.Threading.Tasks.Task<int> productUpdateAsync(WcfServiceSample.DTO.ProductDTO instance) {
            return base.Channel.productUpdateAsync(instance);
        }
    }
}