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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SOPTransaction" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SOPTransaction.svc or SOPTransaction.svc.cs at the Solution Explorer and start debugging.
    public class SOPTransaction : ISOPTransaction
    {
        //public void DoWork()
        //{
        //}

        /// <summary>
        /// Create Invoince
        /// </summary>
        /// <param name="header"></param>
        /// <param name="detail"></param>
        /// <param name="distribution"></param>
        /// <param name="commissions"></param>
        /// <param name="taxes"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateSOPTransaction(SOPHeader header, List<SOPDetail> detail, List<SOPDistribution> distribution, List<SOPCommissions> commissions, List<SOPTax> taxes, SopType soptype, string company)
        {
            SOPTransactionCreate soptran = new SOPTransactionCreate();

            return soptran.TransactionCreate(header, detail, distribution, taxes, commissions, soptype, company);
        }

    }
}
