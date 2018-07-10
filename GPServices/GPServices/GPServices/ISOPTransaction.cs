using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using eConnectIntegration;
using eConnectIntegration.SOP;
using eConnectIntegration.CLASS;
using SOPClass;
using Microsoft.Dynamics.GP.eConnect;

namespace GPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISOPTransaction" in both code and config file together.
    [ServiceContract]
    public interface ISOPTransaction
    {
        //[OperationContract]
        //void DoWork();


        /// <summary>
        /// Create Invoice
        /// </summary>
        /// <param name="header"></param>
        /// <param name="detail"></param>
        /// <param name="distribution"></param>
        /// <param name="commissions"></param>
        /// <param name="taxes"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        [OperationContract]
        Response CreateSOPTransaction(SOPHeader header, List<SOPDetail> detail, List<SOPDistribution> distribution, List<SOPCommissions> commissions, List<SOPTax> taxes, SopType soptype, string company);
    }
}
