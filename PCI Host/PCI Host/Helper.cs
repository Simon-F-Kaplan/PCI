using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCI_Host
{
    public class Helper
    {
        public enum Response
        {
            Success = 0,
            Failure = -1
        }

        public enum ProcessorType_Response
        {
            /// <summary>
            /// Paypal Payflow Processor
            /// </summary>
            pflResponse,
            /// <summary>
            /// CyberSource Processor
            /// </summary>
            cybResponse,
            /// <summary>
            /// Star Card Processor 
            /// </summary>
            strResponse,
            /// <summary>
            /// Authorize.Net Processor
            /// </summary>
            anetResponse,
            /// <summary>
            /// Moneris Response
            /// </summary>
            monResponse,
            /// <summary>
            /// PSiGate Response
            /// </summary>
            psiResponse,
            /// <summary>
            /// Paymentech Orbital Processor
            /// </summary>
            ponResponse,
            /// <summary>
            /// Paypal Website PaymentPro Processor
            /// </summary>
            wproResponse,
            /// <summary>
            /// SecureNet Processor
            /// </summary>
            snetResponse,
            /// <summary>
            /// Planet Payment iPay Processor
            /// </summary>
            ipayResponse,
            /// <summary>
            /// Prism Pay Processor
            /// </summary>
            prismpayResponse,
            /// <summary>
            /// WorldPay Processor
            /// </summary>
            worldpayResponse,
            /// <summary>
            /// Optimal Processor
            /// </summary>
            optimalResponse,
            /// <summary>
            /// Global Collect Processor
            /// </summary>
            globalcResponse,
            /// <summary>
            /// Rakuten Processor
            /// </summary>
            rakutenResponse,
            /// <summary>
            /// Ogone Processor
            /// </summary>
            ogoneResponse,
            /// <summary>
            /// 3D Secure response
            /// </summary>
            3dsecResponse,
            /// <summary>
            /// Message Dispatch response
            /// </summary>
            msgDispatchResponse, 
            /// <summary>
            /// File Dispatch response
            /// </summary>
            fileDispatchResponse
        }
    }
}