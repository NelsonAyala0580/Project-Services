using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using eConnectIntegration.GL;
using eConnectIntegration.CLASS;
using GLClass;

namespace GPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGLTransaction" in both code and config file together.
    [ServiceContract]
    public interface IGLTransaction
    {
        [OperationContract]
        Response CreateGLTransaction(GLTrasactionHeader Header, GLTransactionDetail[] Detail, string company);
    }
}
