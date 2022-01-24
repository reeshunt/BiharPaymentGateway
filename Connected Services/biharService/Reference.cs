﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace biharService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="biharService.BillInterfaceSoap")]
    public interface BillInterfaceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BillDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        biharService.BillDetailsStruct BillDetails(string strCANumber, string strDivision, string strSubDivision, string strLegacyNo, string strMerchantCode, string strMerchantPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BillDetails", ReplyAction="*")]
        System.Threading.Tasks.Task<biharService.BillDetailsStruct> BillDetailsAsync(string strCANumber, string strDivision, string strSubDivision, string strLegacyNo, string strMerchantCode, string strMerchantPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PaymentDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        biharService.VendorPaymentDetails PaymentDetails(string strCANumber, string strInvoiceNo, string strDueDate, string strAmount, string strCompanyCode, string strTransactionId, string strTransactionDateTime, string strReceiptNo, string strBankRefCode, string strBankId, string strPaymentMode, string strMerchantCode, string strMerchantPassword, string strCkeckSum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PaymentDetails", ReplyAction="*")]
        System.Threading.Tasks.Task<biharService.VendorPaymentDetails> PaymentDetailsAsync(string strCANumber, string strInvoiceNo, string strDueDate, string strAmount, string strCompanyCode, string strTransactionId, string strTransactionDateTime, string strReceiptNo, string strBankRefCode, string strBankId, string strPaymentMode, string strMerchantCode, string strMerchantPassword, string strCkeckSum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PaymentReceiptDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        biharService.VendorPaymentReceipt PaymentReceiptDetails(string strTransactionId, string strMerchantCode, string strMerchantPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PaymentReceiptDetails", ReplyAction="*")]
        System.Threading.Tasks.Task<biharService.VendorPaymentReceipt> PaymentReceiptDetailsAsync(string strTransactionId, string strMerchantCode, string strMerchantPassword);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BillDetailsStruct
    {
        
        private string cANumberField;
        
        private string consumerNameField;
        
        private string lT_HTField;
        
        private string addressField;
        
        private string emailAddressField;
        
        private string mobileNumberField;
        
        private string divisionField;
        
        private string subDivisionField;
        
        private string companyNameField;
        
        private string billMonthField;
        
        private string amountField;
        
        private string dueDateField;
        
        private string invoiceNOField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CANumber
        {
            get
            {
                return this.cANumberField;
            }
            set
            {
                this.cANumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ConsumerName
        {
            get
            {
                return this.consumerNameField;
            }
            set
            {
                this.consumerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string LT_HT
        {
            get
            {
                return this.lT_HTField;
            }
            set
            {
                this.lT_HTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string MobileNumber
        {
            get
            {
                return this.mobileNumberField;
            }
            set
            {
                this.mobileNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Division
        {
            get
            {
                return this.divisionField;
            }
            set
            {
                this.divisionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string SubDivision
        {
            get
            {
                return this.subDivisionField;
            }
            set
            {
                this.subDivisionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string BillMonth
        {
            get
            {
                return this.billMonthField;
            }
            set
            {
                this.billMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string DueDate
        {
            get
            {
                return this.dueDateField;
            }
            set
            {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string InvoiceNO
        {
            get
            {
                return this.invoiceNOField;
            }
            set
            {
                this.invoiceNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class VendorPaymentReceipt
    {
        
        private string bSPDCL_Receipt_NoField;
        
        private string transaction_IdField;
        
        private string cANumberField;
        
        private string consumerNameField;
        
        private string billNoField;
        
        private string billDueDateField;
        
        private string amountPaidField;
        
        private string paymentDateTimeField;
        
        private string modePaymentField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string BSPDCL_Receipt_No
        {
            get
            {
                return this.bSPDCL_Receipt_NoField;
            }
            set
            {
                this.bSPDCL_Receipt_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Transaction_Id
        {
            get
            {
                return this.transaction_IdField;
            }
            set
            {
                this.transaction_IdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CANumber
        {
            get
            {
                return this.cANumberField;
            }
            set
            {
                this.cANumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ConsumerName
        {
            get
            {
                return this.consumerNameField;
            }
            set
            {
                this.consumerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string BillNo
        {
            get
            {
                return this.billNoField;
            }
            set
            {
                this.billNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string BillDueDate
        {
            get
            {
                return this.billDueDateField;
            }
            set
            {
                this.billDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string AmountPaid
        {
            get
            {
                return this.amountPaidField;
            }
            set
            {
                this.amountPaidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string PaymentDateTime
        {
            get
            {
                return this.paymentDateTimeField;
            }
            set
            {
                this.paymentDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ModePayment
        {
            get
            {
                return this.modePaymentField;
            }
            set
            {
                this.modePaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class VendorPaymentDetails
    {
        
        private string statusFlagField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string StatusFlag
        {
            get
            {
                return this.statusFlagField;
            }
            set
            {
                this.statusFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface BillInterfaceSoapChannel : biharService.BillInterfaceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class BillInterfaceSoapClient : System.ServiceModel.ClientBase<biharService.BillInterfaceSoap>, biharService.BillInterfaceSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BillInterfaceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(BillInterfaceSoapClient.GetBindingForEndpoint(endpointConfiguration), BillInterfaceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BillInterfaceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BillInterfaceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BillInterfaceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BillInterfaceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BillInterfaceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public biharService.BillDetailsStruct BillDetails(string strCANumber, string strDivision, string strSubDivision, string strLegacyNo, string strMerchantCode, string strMerchantPassword)
        {
            return base.Channel.BillDetails(strCANumber, strDivision, strSubDivision, strLegacyNo, strMerchantCode, strMerchantPassword);
        }
        
        public System.Threading.Tasks.Task<biharService.BillDetailsStruct> BillDetailsAsync(string strCANumber, string strDivision, string strSubDivision, string strLegacyNo, string strMerchantCode, string strMerchantPassword)
        {
            return base.Channel.BillDetailsAsync(strCANumber, strDivision, strSubDivision, strLegacyNo, strMerchantCode, strMerchantPassword);
        }
        
        public biharService.VendorPaymentDetails PaymentDetails(string strCANumber, string strInvoiceNo, string strDueDate, string strAmount, string strCompanyCode, string strTransactionId, string strTransactionDateTime, string strReceiptNo, string strBankRefCode, string strBankId, string strPaymentMode, string strMerchantCode, string strMerchantPassword, string strCkeckSum)
        {
            return base.Channel.PaymentDetails(strCANumber, strInvoiceNo, strDueDate, strAmount, strCompanyCode, strTransactionId, strTransactionDateTime, strReceiptNo, strBankRefCode, strBankId, strPaymentMode, strMerchantCode, strMerchantPassword, strCkeckSum);
        }
        
        public System.Threading.Tasks.Task<biharService.VendorPaymentDetails> PaymentDetailsAsync(string strCANumber, string strInvoiceNo, string strDueDate, string strAmount, string strCompanyCode, string strTransactionId, string strTransactionDateTime, string strReceiptNo, string strBankRefCode, string strBankId, string strPaymentMode, string strMerchantCode, string strMerchantPassword, string strCkeckSum)
        {
            return base.Channel.PaymentDetailsAsync(strCANumber, strInvoiceNo, strDueDate, strAmount, strCompanyCode, strTransactionId, strTransactionDateTime, strReceiptNo, strBankRefCode, strBankId, strPaymentMode, strMerchantCode, strMerchantPassword, strCkeckSum);
        }
        
        public biharService.VendorPaymentReceipt PaymentReceiptDetails(string strTransactionId, string strMerchantCode, string strMerchantPassword)
        {
            return base.Channel.PaymentReceiptDetails(strTransactionId, strMerchantCode, strMerchantPassword);
        }
        
        public System.Threading.Tasks.Task<biharService.VendorPaymentReceipt> PaymentReceiptDetailsAsync(string strTransactionId, string strMerchantCode, string strMerchantPassword)
        {
            return base.Channel.PaymentReceiptDetailsAsync(strTransactionId, strMerchantCode, strMerchantPassword);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BillInterfaceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BillInterfaceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BillInterfaceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://112.133.239.225/biharservice/BillInterface.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.BillInterfaceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://112.133.239.225/biharservice/BillInterface.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BillInterfaceSoap,
            
            BillInterfaceSoap12,
        }
    }
}
