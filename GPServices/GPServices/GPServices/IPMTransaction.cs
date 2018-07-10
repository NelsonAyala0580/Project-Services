using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PMClass;
using eConnectIntegration.CLASS;

namespace GPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPMTransaction
    {

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        Response CreateUpdateVendor(PMVendor vendor, string company);
        [OperationContract]
        Response CreatePMTransaction(PMTransactionHeader Transaction, PMTransactionDist[] Distribution, PMTransactionTax[] Taxes, string company);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
