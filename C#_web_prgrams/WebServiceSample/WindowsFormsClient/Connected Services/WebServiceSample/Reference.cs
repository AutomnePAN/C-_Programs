﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.WebServiceSample {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceSample.SampleServiceSoap")]
    public interface SampleServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 message 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReverseString", ReplyAction="*")]
        WindowsFormsClient.WebServiceSample.ReverseStringResponse ReverseString(WindowsFormsClient.WebServiceSample.ReverseStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReverseString", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.ReverseStringResponse> ReverseStringAsync(WindowsFormsClient.WebServiceSample.ReverseStringRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseString", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.WebServiceSample.ReverseStringRequestBody Body;
        
        public ReverseStringRequest() {
        }
        
        public ReverseStringRequest(WindowsFormsClient.WebServiceSample.ReverseStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReverseStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string message;
        
        public ReverseStringRequestBody() {
        }
        
        public ReverseStringRequestBody(string message) {
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseStringResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.WebServiceSample.ReverseStringResponseBody Body;
        
        public ReverseStringResponse() {
        }
        
        public ReverseStringResponse(WindowsFormsClient.WebServiceSample.ReverseStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReverseStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ReverseStringResult;
        
        public ReverseStringResponseBody() {
        }
        
        public ReverseStringResponseBody(string ReverseStringResult) {
            this.ReverseStringResult = ReverseStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleServiceSoapChannel : WindowsFormsClient.WebServiceSample.SampleServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsClient.WebServiceSample.SampleServiceSoap>, WindowsFormsClient.WebServiceSample.SampleServiceSoap {
        
        public SampleServiceSoapClient() {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.WebServiceSample.ReverseStringResponse WindowsFormsClient.WebServiceSample.SampleServiceSoap.ReverseString(WindowsFormsClient.WebServiceSample.ReverseStringRequest request) {
            return base.Channel.ReverseString(request);
        }
        
        public string ReverseString(string message) {
            WindowsFormsClient.WebServiceSample.ReverseStringRequest inValue = new WindowsFormsClient.WebServiceSample.ReverseStringRequest();
            inValue.Body = new WindowsFormsClient.WebServiceSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            WindowsFormsClient.WebServiceSample.ReverseStringResponse retVal = ((WindowsFormsClient.WebServiceSample.SampleServiceSoap)(this)).ReverseString(inValue);
            return retVal.Body.ReverseStringResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.ReverseStringResponse> WindowsFormsClient.WebServiceSample.SampleServiceSoap.ReverseStringAsync(WindowsFormsClient.WebServiceSample.ReverseStringRequest request) {
            return base.Channel.ReverseStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.ReverseStringResponse> ReverseStringAsync(string message) {
            WindowsFormsClient.WebServiceSample.ReverseStringRequest inValue = new WindowsFormsClient.WebServiceSample.ReverseStringRequest();
            inValue.Body = new WindowsFormsClient.WebServiceSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            return ((WindowsFormsClient.WebServiceSample.SampleServiceSoap)(this)).ReverseStringAsync(inValue);
        }
    }
}
