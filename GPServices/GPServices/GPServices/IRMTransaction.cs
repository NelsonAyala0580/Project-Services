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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRMTransaction" in both code and config file together.
    [ServiceContract]
    public interface IRMTransaction
    {

        [OperationContract]
        Response CreateUpdateCustomer(RMCustomer customer, RMParentID parent, List<RMParentIDChild> children, string company);

        [OperationContract]
        Response CreateCustomerClass(RMCustomerClass customerclass, string company);

        [OperationContract]
        Response CreateSalesPerson(RMSalesPerson salesperson, string company);

        [OperationContract]
        Response CreateRMTransaction(RMTransactionHeader header, RMTransactionDist[] Distrib, RMDocumentTaxes[] Tax, string company);

        [OperationContract]
        Response CreateCashReceipt(RMCashReceipt cashreceipt, RMTransactionDist[] Distrib, string company);

        [OperationContract]
        Response ApplyPaymentTransaction(RMApply rmapply, string company);

        [OperationContract]
        Response UnApplyTransaction(RMUnapply rmunapply, string company);

        [OperationContract]
        Response VoidTransaction(RMVoidTransaction rmvoid, string company);
    }
}
