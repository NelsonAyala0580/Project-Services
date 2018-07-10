using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using eConnectIntegration;
using eConnectIntegration.RM;
using eConnectIntegration.CLASS;
using RMClass;

namespace GPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RMTransaction" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RMTransaction.svc or RMTransaction.svc.cs at the Solution Explorer and start debugging.
    public class RMTransaction : IRMTransaction
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="parent"></param>
        /// <param name="children"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateUpdateCustomer(RMCustomer customer, RMParentID parent, List<RMParentIDChild> children, string company)
        {
            RMCustomerCreateUpdate createCustomer = new RMCustomerCreateUpdate();
            return createCustomer.CustomerCreateUpdate(customer, parent, children, company);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerclass"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateCustomerClass(RMCustomerClass customerclass, string company)
        {
            RMCustomerClassCreate createclass = new RMCustomerClassCreate();
            return createclass.CustomerClassCreate(customerclass, company);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="salesperson"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateSalesPerson(RMSalesPerson salesperson, string company)
        {
            RMSalesPersonCreate salespersoncreate = new RMSalesPersonCreate();
            return salespersoncreate.SalesPresonCreate(salesperson, company);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="header"></param>
        /// <param name="Distrib"></param>
        /// <param name="Tax"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateRMTransaction (RMTransactionHeader header, RMTransactionDist[] Distrib, RMDocumentTaxes[] Tax, string company)
        {
            RMTransactionCreate rmTranCreate = new RMTransactionCreate();
            return rmTranCreate.TransactionCreate(header, Distrib, Tax, company);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cashreceipt"></param>
        /// <param name="Distrib"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateCashReceipt (RMCashReceipt cashreceipt, RMTransactionDist[] Distrib, string company)
        {
            RMTransactionCreate rmtranCash = new RMTransactionCreate();
            return rmtranCash.CashReceiptCreate(cashreceipt, Distrib, company);
        }

        public Response ApplyPaymentTransaction(RMApply rmapply, string company)
        {
            RMTransactionCreate rmtran = new RMTransactionCreate();
            return rmtran.ApplyTransaction(rmapply, company);
        }
        public Response UnApplyTransaction(RMUnapply rmunapply, string company)
        {
            RMTransactionCreate rmtran = new RMTransactionCreate();
            return rmtran.UnApplyTransaction(rmunapply, company);
        }

        public Response VoidTransaction (RMVoidTransaction rmvoid, string company)
        {
            RMTransactionCreate rmtran = new RMTransactionCreate();
            return rmtran.VoidTransaction(rmvoid, company);
        }
    }
}
