using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using eConnectIntegration;
using eConnectIntegration.GL;
using eConnectIntegration.CLASS;
using GLClass;

namespace GPServices
{
    public class GLTransaction : IGLTransaction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Header"></param>
        /// <param name="Detail"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CreateGLTransaction(GLTrasactionHeader Header, GLTransactionDetail[] Detail, string company)
        {
            GLTransactionCreate createGLTransaction = new GLTransactionCreate();
            return createGLTransaction.TransactionCreate(Header, Detail, company);
        }
    }
}
