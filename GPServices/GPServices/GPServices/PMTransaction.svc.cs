using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using eConnectIntegration;
using eConnectIntegration.PM;
using eConnectIntegration.CLASS;
using PMClass;


namespace GPServices
{
    public class PMTransaction : IPMTransaction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateUpdateVendor(PMVendor vendor, string company)
        {
            PMVendorCreateUpdate createVendor = new PMVendorCreateUpdate();
            return createVendor.VendorCreateUpdate(vendor, company);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Transaction"></param>
        /// <param name="Distribution"></param>
        /// <param name="Taxes"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreatePMTransaction (PMTransactionHeader Transaction, PMTransactionDist[] Distribution, PMTransactionTax[] Taxes, string company)
        {
            PMTransactionCreate createPMTransaction = new PMTransactionCreate();
            return createPMTransaction.TransactionCreate(Transaction, Distribution, Taxes,company);
        }
    }
}
