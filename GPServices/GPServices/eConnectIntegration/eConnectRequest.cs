using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Dynamics.GP.eConnect;
using Microsoft.Dynamics.GP.eConnect.Serialization;
using PMClass;
using eConnectIntegration.CLASS;

namespace eConnectIntegration
{
    public class eConnectRequest
    {
        public Response CreateGPMaster(string strCNX, string strXML)
        {
            var eConnCall = new eConnectMethods();
            var response = new Response();
            try
            {
                response.SUCCESS = eConnCall.CreateEntity(strCNX, strXML);
                
                response.MESSAGE = "EXITO";
                return response;
            }
            catch (eConnectException ex)
            {
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace;


                if (ex.InnerException != null)
                {
                    response.STACK += ex.InnerException.Message;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace;


                if (ex.InnerException != null)
                {
                    response.STACK += ex.InnerException.Message;
                }
                return response;
            }
            finally
            {
                eConnCall.Dispose();
            }
        }

        public Response CreateGPTransaction(string strCNX, string strXML)
        {
            var eConnCall = new eConnectMethods();
            var response = new Response();
            try
            {
                response.MESSAGE = eConnCall.CreateTransactionEntity(strCNX, strXML);
                response.SUCCESS = true;
                return response;
            }
            catch (eConnectException ex)
            {
                response.SUCCESS = false;
                response.MESSAGE = ex.Message + " - " +strXML; ;
                response.STACK = ex.StackTrace;

                if (ex.InnerException !=null)
                {
                    response.STACK += ex.InnerException.Message;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace;
                if (ex.InnerException != null)
                {
                    response.STACK += ex.InnerException.Message;
                }
                return response;
            }
            finally
            {
                eConnCall.Dispose();
            }
        }
    }
}
