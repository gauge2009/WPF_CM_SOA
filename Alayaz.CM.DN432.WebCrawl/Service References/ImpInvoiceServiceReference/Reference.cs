﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://IBiz.v.jr.com/", ConfigurationName="ImpInvoiceServiceReference.ISyncImportInvoiceService")]
    public interface ISyncImportInvoiceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool Fetch(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="", ReplyAction="*")]
        System.IAsyncResult BeginFetch(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool EndFetch(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool Inject(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="", ReplyAction="*")]
        System.IAsyncResult BeginInject(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool EndInject(System.IAsyncResult result);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://IBiz.v.jr.com/")]
    public partial class users : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime regdateField;
        
        private bool regdateFieldSpecified;
        
        private string passwordField;
        
        private int roleidField;
        
        private ushort statusField;
        
        private string useridField;
        
        private string usernameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime regdate {
            get {
                return this.regdateField;
            }
            set {
                this.regdateField = value;
                this.RaisePropertyChanged("regdate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool regdateSpecified {
            get {
                return this.regdateFieldSpecified;
            }
            set {
                this.regdateFieldSpecified = value;
                this.RaisePropertyChanged("regdateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int roleid {
            get {
                return this.roleidField;
            }
            set {
                this.roleidField = value;
                this.RaisePropertyChanged("roleid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public ushort status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string userid {
            get {
                return this.useridField;
            }
            set {
                this.useridField = value;
                this.RaisePropertyChanged("userid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("username");
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
    public interface ISyncImportInvoiceServiceChannel : Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.ISyncImportInvoiceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FetchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public FetchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InjectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public InjectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SyncImportInvoiceServiceClient : System.ServiceModel.ClientBase<Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.ISyncImportInvoiceService>, Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.ISyncImportInvoiceService {
        
        private BeginOperationDelegate onBeginFetchDelegate;
        
        private EndOperationDelegate onEndFetchDelegate;
        
        private System.Threading.SendOrPostCallback onFetchCompletedDelegate;
        
        private BeginOperationDelegate onBeginInjectDelegate;
        
        private EndOperationDelegate onEndInjectDelegate;
        
        private System.Threading.SendOrPostCallback onInjectCompletedDelegate;
        
        public SyncImportInvoiceServiceClient() {
        }
        
        public SyncImportInvoiceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SyncImportInvoiceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncImportInvoiceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncImportInvoiceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<FetchCompletedEventArgs> FetchCompleted;
        
        public event System.EventHandler<InjectCompletedEventArgs> InjectCompleted;
        
        public bool Fetch(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0) {
            return base.Channel.Fetch(arg0);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginFetch(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginFetch(arg0, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndFetch(System.IAsyncResult result) {
            return base.Channel.EndFetch(result);
        }
        
        private System.IAsyncResult OnBeginFetch(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0 = ((Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users)(inValues[0]));
            return this.BeginFetch(arg0, callback, asyncState);
        }
        
        private object[] OnEndFetch(System.IAsyncResult result) {
            bool retVal = this.EndFetch(result);
            return new object[] {
                    retVal};
        }
        
        private void OnFetchCompleted(object state) {
            if ((this.FetchCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.FetchCompleted(this, new FetchCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void FetchAsync(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0) {
            this.FetchAsync(arg0, null);
        }
        
        public void FetchAsync(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0, object userState) {
            if ((this.onBeginFetchDelegate == null)) {
                this.onBeginFetchDelegate = new BeginOperationDelegate(this.OnBeginFetch);
            }
            if ((this.onEndFetchDelegate == null)) {
                this.onEndFetchDelegate = new EndOperationDelegate(this.OnEndFetch);
            }
            if ((this.onFetchCompletedDelegate == null)) {
                this.onFetchCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFetchCompleted);
            }
            base.InvokeAsync(this.onBeginFetchDelegate, new object[] {
                        arg0}, this.onEndFetchDelegate, this.onFetchCompletedDelegate, userState);
        }
        
        public bool Inject(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0) {
            return base.Channel.Inject(arg0);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginInject(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginInject(arg0, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndInject(System.IAsyncResult result) {
            return base.Channel.EndInject(result);
        }
        
        private System.IAsyncResult OnBeginInject(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0 = ((Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users)(inValues[0]));
            return this.BeginInject(arg0, callback, asyncState);
        }
        
        private object[] OnEndInject(System.IAsyncResult result) {
            bool retVal = this.EndInject(result);
            return new object[] {
                    retVal};
        }
        
        private void OnInjectCompleted(object state) {
            if ((this.InjectCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.InjectCompleted(this, new InjectCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void InjectAsync(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0) {
            this.InjectAsync(arg0, null);
        }
        
        public void InjectAsync(Alayaz.CM.DN432.WebCrawl.ImpInvoiceServiceReference.users arg0, object userState) {
            if ((this.onBeginInjectDelegate == null)) {
                this.onBeginInjectDelegate = new BeginOperationDelegate(this.OnBeginInject);
            }
            if ((this.onEndInjectDelegate == null)) {
                this.onEndInjectDelegate = new EndOperationDelegate(this.OnEndInject);
            }
            if ((this.onInjectCompletedDelegate == null)) {
                this.onInjectCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnInjectCompleted);
            }
            base.InvokeAsync(this.onBeginInjectDelegate, new object[] {
                        arg0}, this.onEndInjectDelegate, this.onInjectCompletedDelegate, userState);
        }
    }
}
