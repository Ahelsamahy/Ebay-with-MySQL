﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFEbayClient.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UnsuccessfullLoginFault", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
    [System.SerializableAttribute()]
    public partial class UnsuccessfullLoginFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
    [System.SerializableAttribute()]
    public partial class ServiceData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDetails {
            get {
                return this.ErrorDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDetailsField, value) != true)) {
                    this.ErrorDetailsField = value;
                    this.RaisePropertyChanged("ErrorDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Curr_priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Curr_price {
            get {
                return this.Curr_priceField;
            }
            set {
                if ((this.Curr_priceField.Equals(value) != true)) {
                    this.Curr_priceField = value;
                    this.RaisePropertyChanged("Curr_price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string License_plateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarID {
            get {
                return this.CarIDField;
            }
            set {
                if ((this.CarIDField.Equals(value) != true)) {
                    this.CarIDField = value;
                    this.RaisePropertyChanged("CarID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string License_plate {
            get {
                return this.License_plateField;
            }
            set {
                if ((object.ReferenceEquals(this.License_plateField, value) != true)) {
                    this.License_plateField = value;
                    this.RaisePropertyChanged("License_plate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="users", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
    [System.SerializableAttribute()]
    public partial class users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName {
            get {
                return this.SecondNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNameField, value) != true)) {
                    this.SecondNameField = value;
                    this.RaisePropertyChanged("SecondName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFEbayClient.ServiceReference2.UnsuccessfullLoginFault), Action="http://tempuri.org/IService1/loginUnsuccessfullLoginFaultFault", Name="UnsuccessfullLoginFault", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
        string login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestConnection", ReplyAction="http://tempuri.org/IService1/TestConnectionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFEbayClient.ServiceReference2.ServiceData), Action="http://tempuri.org/IService1/TestConnectionServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFEbayServer")]
        WCFEbayClient.ServiceReference2.ServiceData TestConnection(string strConnectionString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestConnection", ReplyAction="http://tempuri.org/IService1/TestConnectionResponse")]
        System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.ServiceData> TestConnectionAsync(string strConnectionString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/bye", ReplyAction="http://tempuri.org/IService1/byeResponse")]
        string bye();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/bye", ReplyAction="http://tempuri.org/IService1/byeResponse")]
        System.Threading.Tasks.Task<string> byeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        string Add(string name, string code, int price, string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task<string> AddAsync(string name, string code, int price, string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/List", ReplyAction="http://tempuri.org/IService1/ListResponse")]
        WCFEbayClient.ServiceReference2.Product[] List();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/List", ReplyAction="http://tempuri.org/IService1/ListResponse")]
        System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.Product[]> ListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Bid", ReplyAction="http://tempuri.org/IService1/BidResponse")]
        string Bid(string code, int price, string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Bid", ReplyAction="http://tempuri.org/IService1/BidResponse")]
        System.Threading.Tasks.Task<string> BidAsync(string code, int price, string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCars", ReplyAction="http://tempuri.org/IService1/GetCarsResponse")]
        WCFEbayClient.ServiceReference2.Car GetCars(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCars", ReplyAction="http://tempuri.org/IService1/GetCarsResponse")]
        System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.Car> GetCarsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveCars", ReplyAction="http://tempuri.org/IService1/SaveCarsResponse")]
        void SaveCars(WCFEbayClient.ServiceReference2.Car employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveCars", ReplyAction="http://tempuri.org/IService1/SaveCarsResponse")]
        System.Threading.Tasks.Task SaveCarsAsync(WCFEbayClient.ServiceReference2.Car employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCars", ReplyAction="http://tempuri.org/IService1/DeleteCarsResponse")]
        void DeleteCars(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCars", ReplyAction="http://tempuri.org/IService1/DeleteCarsResponse")]
        System.Threading.Tasks.Task DeleteCarsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/allCars", ReplyAction="http://tempuri.org/IService1/allCarsResponse")]
        WCFEbayClient.ServiceReference2.Car[] allCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/allCars", ReplyAction="http://tempuri.org/IService1/allCarsResponse")]
        System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.Car[]> allCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveUsers", ReplyAction="http://tempuri.org/IService1/SaveUsersResponse")]
        void SaveUsers(WCFEbayClient.ServiceReference2.users normalUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveUsers", ReplyAction="http://tempuri.org/IService1/SaveUsersResponse")]
        System.Threading.Tasks.Task SaveUsersAsync(WCFEbayClient.ServiceReference2.users normalUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUsers", ReplyAction="http://tempuri.org/IService1/DeleteUsersResponse")]
        void DeleteUsers(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUsers", ReplyAction="http://tempuri.org/IService1/DeleteUsersResponse")]
        System.Threading.Tasks.Task DeleteUsersAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        WCFEbayClient.ServiceReference2.users GetUsers(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.users> GetUsersAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/allUsers", ReplyAction="http://tempuri.org/IService1/allUsersResponse")]
        WCFEbayClient.ServiceReference2.users[] allUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/allUsers", ReplyAction="http://tempuri.org/IService1/allUsersResponse")]
        System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.users[]> allUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFEbayClient.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFEbayClient.ServiceReference2.IService1>, WCFEbayClient.ServiceReference2.IService1 {
        
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
        
        public string login(string username, string password) {
            return base.Channel.login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(string username, string password) {
            return base.Channel.loginAsync(username, password);
        }
        
        public WCFEbayClient.ServiceReference2.ServiceData TestConnection(string strConnectionString) {
            return base.Channel.TestConnection(strConnectionString);
        }
        
        public System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.ServiceData> TestConnectionAsync(string strConnectionString) {
            return base.Channel.TestConnectionAsync(strConnectionString);
        }
        
        public string bye() {
            return base.Channel.bye();
        }
        
        public System.Threading.Tasks.Task<string> byeAsync() {
            return base.Channel.byeAsync();
        }
        
        public string Add(string name, string code, int price, string uid) {
            return base.Channel.Add(name, code, price, uid);
        }
        
        public System.Threading.Tasks.Task<string> AddAsync(string name, string code, int price, string uid) {
            return base.Channel.AddAsync(name, code, price, uid);
        }
        
        public WCFEbayClient.ServiceReference2.Product[] List() {
            return base.Channel.List();
        }
        
        public System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.Product[]> ListAsync() {
            return base.Channel.ListAsync();
        }
        
        public string Bid(string code, int price, string uid) {
            return base.Channel.Bid(code, price, uid);
        }
        
        public System.Threading.Tasks.Task<string> BidAsync(string code, int price, string uid) {
            return base.Channel.BidAsync(code, price, uid);
        }
        
        public WCFEbayClient.ServiceReference2.Car GetCars(int id) {
            return base.Channel.GetCars(id);
        }
        
        public System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.Car> GetCarsAsync(int id) {
            return base.Channel.GetCarsAsync(id);
        }
        
        public void SaveCars(WCFEbayClient.ServiceReference2.Car employee) {
            base.Channel.SaveCars(employee);
        }
        
        public System.Threading.Tasks.Task SaveCarsAsync(WCFEbayClient.ServiceReference2.Car employee) {
            return base.Channel.SaveCarsAsync(employee);
        }
        
        public void DeleteCars(int id) {
            base.Channel.DeleteCars(id);
        }
        
        public System.Threading.Tasks.Task DeleteCarsAsync(int id) {
            return base.Channel.DeleteCarsAsync(id);
        }
        
        public WCFEbayClient.ServiceReference2.Car[] allCars() {
            return base.Channel.allCars();
        }
        
        public System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.Car[]> allCarsAsync() {
            return base.Channel.allCarsAsync();
        }
        
        public void SaveUsers(WCFEbayClient.ServiceReference2.users normalUser) {
            base.Channel.SaveUsers(normalUser);
        }
        
        public System.Threading.Tasks.Task SaveUsersAsync(WCFEbayClient.ServiceReference2.users normalUser) {
            return base.Channel.SaveUsersAsync(normalUser);
        }
        
        public void DeleteUsers(int id) {
            base.Channel.DeleteUsers(id);
        }
        
        public System.Threading.Tasks.Task DeleteUsersAsync(int id) {
            return base.Channel.DeleteUsersAsync(id);
        }
        
        public WCFEbayClient.ServiceReference2.users GetUsers(int id) {
            return base.Channel.GetUsers(id);
        }
        
        public System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.users> GetUsersAsync(int id) {
            return base.Channel.GetUsersAsync(id);
        }
        
        public WCFEbayClient.ServiceReference2.users[] allUsers() {
            return base.Channel.allUsers();
        }
        
        public System.Threading.Tasks.Task<WCFEbayClient.ServiceReference2.users[]> allUsersAsync() {
            return base.Channel.allUsersAsync();
        }
    }
}