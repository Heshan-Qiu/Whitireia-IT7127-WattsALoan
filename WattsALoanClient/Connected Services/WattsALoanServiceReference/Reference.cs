﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WattsALoanClient.WattsALoanServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WattsALoanService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WattsALoanService")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillingAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillingCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillingStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillingZIPCideField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateCreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
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
        public string BillingAddress {
            get {
                return this.BillingAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.BillingAddressField, value) != true)) {
                    this.BillingAddressField = value;
                    this.RaisePropertyChanged("BillingAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillingCity {
            get {
                return this.BillingCityField;
            }
            set {
                if ((object.ReferenceEquals(this.BillingCityField, value) != true)) {
                    this.BillingCityField = value;
                    this.RaisePropertyChanged("BillingCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillingState {
            get {
                return this.BillingStateField;
            }
            set {
                if ((object.ReferenceEquals(this.BillingStateField, value) != true)) {
                    this.BillingStateField = value;
                    this.RaisePropertyChanged("BillingState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillingZIPCide {
            get {
                return this.BillingZIPCideField;
            }
            set {
                if ((object.ReferenceEquals(this.BillingZIPCideField, value) != true)) {
                    this.BillingZIPCideField = value;
                    this.RaisePropertyChanged("BillingZIPCide");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateCreated {
            get {
                return this.DateCreatedField;
            }
            set {
                if ((this.DateCreatedField.Equals(value) != true)) {
                    this.DateCreatedField = value;
                    this.RaisePropertyChanged("DateCreated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WattsALoanServiceReference.IWattsALoanService")]
    public interface IWattsALoanService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWattsALoanService/GetData", ReplyAction="http://tempuri.org/IWattsALoanService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWattsALoanService/GetData", ReplyAction="http://tempuri.org/IWattsALoanService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWattsALoanService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IWattsALoanService/GetDataUsingDataContractResponse")]
        WattsALoanClient.WattsALoanServiceReference.CompositeType GetDataUsingDataContract(WattsALoanClient.WattsALoanServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWattsALoanService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IWattsALoanService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WattsALoanClient.WattsALoanServiceReference.CompositeType> GetDataUsingDataContractAsync(WattsALoanClient.WattsALoanServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWattsALoanService/InsertCustomer", ReplyAction="http://tempuri.org/IWattsALoanService/InsertCustomerResponse")]
        bool InsertCustomer(WattsALoanClient.WattsALoanServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWattsALoanService/InsertCustomer", ReplyAction="http://tempuri.org/IWattsALoanService/InsertCustomerResponse")]
        System.Threading.Tasks.Task<bool> InsertCustomerAsync(WattsALoanClient.WattsALoanServiceReference.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWattsALoanServiceChannel : WattsALoanClient.WattsALoanServiceReference.IWattsALoanService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WattsALoanServiceClient : System.ServiceModel.ClientBase<WattsALoanClient.WattsALoanServiceReference.IWattsALoanService>, WattsALoanClient.WattsALoanServiceReference.IWattsALoanService {
        
        public WattsALoanServiceClient() {
        }
        
        public WattsALoanServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WattsALoanServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WattsALoanServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WattsALoanServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WattsALoanClient.WattsALoanServiceReference.CompositeType GetDataUsingDataContract(WattsALoanClient.WattsALoanServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WattsALoanClient.WattsALoanServiceReference.CompositeType> GetDataUsingDataContractAsync(WattsALoanClient.WattsALoanServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool InsertCustomer(WattsALoanClient.WattsALoanServiceReference.Customer customer) {
            return base.Channel.InsertCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<bool> InsertCustomerAsync(WattsALoanClient.WattsALoanServiceReference.Customer customer) {
            return base.Channel.InsertCustomerAsync(customer);
        }
    }
}
