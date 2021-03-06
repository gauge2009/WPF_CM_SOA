﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alayaz.SOA.IService.TestClient.ServiceRefConsole {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.alayaz.com/", ConfigurationName="ServiceRefConsole.IFileReader")]
    public interface IFileReader {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.alayaz.com/IFileReader/Read", ReplyAction="http://www.alayaz.com/IFileReader/ReadResponse")]
        string Read(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.alayaz.com/IFileReader/Write", ReplyAction="http://www.alayaz.com/IFileReader/WriteResponse")]
        void Write(string fileName, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.alayaz.com/IFileReader/JustStart", ReplyAction="http://www.alayaz.com/IFileReader/JustStartResponse")]
        void JustStart(string appName, string param);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileReaderChannel : Alayaz.SOA.IService.TestClient.ServiceRefConsole.IFileReader, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileReaderClient : System.ServiceModel.ClientBase<Alayaz.SOA.IService.TestClient.ServiceRefConsole.IFileReader>, Alayaz.SOA.IService.TestClient.ServiceRefConsole.IFileReader {
        
        public FileReaderClient() {
        }
        
        public FileReaderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileReaderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileReaderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileReaderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Read(string fileName) {
            return base.Channel.Read(fileName);
        }
        
        public void Write(string fileName, string content) {
            base.Channel.Write(fileName, content);
        }
        
        public void JustStart(string appName, string param) {
            base.Channel.JustStart(appName, param);
        }
    }
}
