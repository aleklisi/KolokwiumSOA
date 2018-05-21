﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StargateALELIS.FighterServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fighter", Namespace="http://schemas.datacontract.org/2004/07/ModelALELIS")]
    [System.SerializableAttribute()]
    public partial class Fighter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PowerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ShieldField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        public int Power {
            get {
                return this.PowerField;
            }
            set {
                if ((this.PowerField.Equals(value) != true)) {
                    this.PowerField = value;
                    this.RaisePropertyChanged("Power");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Shield {
            get {
                return this.ShieldField;
            }
            set {
                if ((this.ShieldField.Equals(value) != true)) {
                    this.ShieldField = value;
                    this.RaisePropertyChanged("Shield");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FighterServiceReference.IFighterService")]
    public interface IFighterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFighterService/GetFighter", ReplyAction="http://tempuri.org/IFighterService/GetFighterResponse")]
        StargateALELIS.FighterServiceReference.Fighter GetFighter(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFighterService/GetFighter", ReplyAction="http://tempuri.org/IFighterService/GetFighterResponse")]
        System.Threading.Tasks.Task<StargateALELIS.FighterServiceReference.Fighter> GetFighterAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFighterService/CreateFighter", ReplyAction="http://tempuri.org/IFighterService/CreateFighterResponse")]
        string CreateFighter(StargateALELIS.FighterServiceReference.Fighter fighter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFighterService/CreateFighter", ReplyAction="http://tempuri.org/IFighterService/CreateFighterResponse")]
        System.Threading.Tasks.Task<string> CreateFighterAsync(StargateALELIS.FighterServiceReference.Fighter fighter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFighterService/GetAllFighters", ReplyAction="http://tempuri.org/IFighterService/GetAllFightersResponse")]
        StargateALELIS.FighterServiceReference.Fighter[] GetAllFighters();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFighterService/GetAllFighters", ReplyAction="http://tempuri.org/IFighterService/GetAllFightersResponse")]
        System.Threading.Tasks.Task<StargateALELIS.FighterServiceReference.Fighter[]> GetAllFightersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFighterServiceChannel : StargateALELIS.FighterServiceReference.IFighterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FighterServiceClient : System.ServiceModel.ClientBase<StargateALELIS.FighterServiceReference.IFighterService>, StargateALELIS.FighterServiceReference.IFighterService {
        
        public FighterServiceClient() {
        }
        
        public FighterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FighterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FighterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FighterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StargateALELIS.FighterServiceReference.Fighter GetFighter(string name) {
            return base.Channel.GetFighter(name);
        }
        
        public System.Threading.Tasks.Task<StargateALELIS.FighterServiceReference.Fighter> GetFighterAsync(string name) {
            return base.Channel.GetFighterAsync(name);
        }
        
        public string CreateFighter(StargateALELIS.FighterServiceReference.Fighter fighter) {
            return base.Channel.CreateFighter(fighter);
        }
        
        public System.Threading.Tasks.Task<string> CreateFighterAsync(StargateALELIS.FighterServiceReference.Fighter fighter) {
            return base.Channel.CreateFighterAsync(fighter);
        }
        
        public StargateALELIS.FighterServiceReference.Fighter[] GetAllFighters() {
            return base.Channel.GetAllFighters();
        }
        
        public System.Threading.Tasks.Task<StargateALELIS.FighterServiceReference.Fighter[]> GetAllFightersAsync() {
            return base.Channel.GetAllFightersAsync();
        }
    }
}