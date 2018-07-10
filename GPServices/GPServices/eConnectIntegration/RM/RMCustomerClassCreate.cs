using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Dynamics.GP.eConnect;
using Microsoft.Dynamics.GP.eConnect.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;
using System.Web;
using System.Configuration;
using System.Configuration.Assemblies;
using eConnectIntegration.CLASS;
using RMClass;

namespace eConnectIntegration.RM
{
    public class RMCustomerClassCreate
    {
        public Response CustomerClassCreate(RMCustomerClass customerClass, string company)
        {
            var response = new Response();
            string CustomerCLassXML;
            string server = ConfigKey.ReadSetting("SERVER");
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            taCreateCustomerClass rmCustomerClass;
            try
            {
                rmCustomerClass = SetCustomerClassValues(customerClass);
                CustomerCLassXML = SerializeCustomerClass(rmCustomerClass);
                response = eConnect.CreateGPMaster(CNX, CustomerCLassXML);

                return response;
            }
            catch (Exception ex)
            {
                response = new Response();
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace;
                return response;
            }
        }

        private taCreateCustomerClass SetCustomerClassValues(RMCustomerClass customerClass)
        {
            taCreateCustomerClass rmCustomerClass = new taCreateCustomerClass();
            try
            {
                rmCustomerClass.CLASSID = customerClass.CLASSID;
                rmCustomerClass.CLASDSCR = customerClass.CLASDSCR;
                rmCustomerClass.CRLMTTYP = customerClass.CRLMTTYP.GetValueOrDefault();
                rmCustomerClass.CRLMTAMT = customerClass.CRLMTAMT.GetValueOrDefault();
                rmCustomerClass.CRLMTPER = customerClass.CRLMTPER.GetValueOrDefault();
                rmCustomerClass.CRLMTPAM = customerClass.CRLMTPAM.GetValueOrDefault();
                rmCustomerClass.DEFLTCLS = customerClass.DEFLTCLS.GetValueOrDefault();
                rmCustomerClass.BALNCTYP = customerClass.BALNCTYP.GetValueOrDefault();
                rmCustomerClass.CHEKBKID = customerClass.CHEKBKID;
                rmCustomerClass.TAXSCHID = customerClass.TAXSCHID;
                rmCustomerClass.SHIPMTHD = customerClass.SHIPMTHD;
                rmCustomerClass.PYMTRMID = customerClass.PYMTRMID;
                rmCustomerClass.CUSTDISC = customerClass.CUSTDISC.GetValueOrDefault();
                rmCustomerClass.MINPYTYP = customerClass.MINPYTYP.GetValueOrDefault();
                rmCustomerClass.MINPYDLR = customerClass.MINPYDLR.GetValueOrDefault();
                rmCustomerClass.MINPYPCT = customerClass.MINPYPCT.GetValueOrDefault();
                rmCustomerClass.MXWOFTYP = customerClass.MXWOFTYP.GetValueOrDefault();
                rmCustomerClass.MXWROFAM = customerClass.MXWROFAM.GetValueOrDefault();
                rmCustomerClass.FNCHATYP = customerClass.FNCHATYP.GetValueOrDefault();
                rmCustomerClass.FINCHDLR = customerClass.FINCHDLR.GetValueOrDefault();
                rmCustomerClass.FNCHPCNT = customerClass.FNCHPCNT.GetValueOrDefault();
                rmCustomerClass.PRCLEVEL = customerClass.PRCLEVEL;
                rmCustomerClass.CURNCYID = customerClass.CURNCYID;
                rmCustomerClass.RATETPID = customerClass.RATETPID;
                rmCustomerClass.DEFCACTY = customerClass.DEFCACTY.GetValueOrDefault();
                rmCustomerClass.CASHACCT = customerClass.CASHACCT;
                rmCustomerClass.ACCTRECACCT = customerClass.ACCTRECACCT;
                rmCustomerClass.SALESACCT = customerClass.SALESACCT;
                rmCustomerClass.COSTOFSALESACCT = customerClass.COSTOFSALESACCT;
                rmCustomerClass.IVACCT = customerClass.IVACCT;
                rmCustomerClass.TERMDISCTAKENACCT = customerClass.TERMDISCTAKENACCT;
                rmCustomerClass.TERMDISCAVAILACCT = customerClass.TERMDISCAVAILACCT;
                rmCustomerClass.FINCHRGACCT = customerClass.FINCHRGACCT;
                rmCustomerClass.SALESORDERRETACCT = customerClass.SALESORDERRETACCT;
                rmCustomerClass.SALSTERR = customerClass.SALSTERR;
                rmCustomerClass.SLPRSNID = customerClass.SLPRSNID;
                rmCustomerClass.STMTCYCL = customerClass.STMTCYCL.GetValueOrDefault();
                rmCustomerClass.KPCALHST = customerClass.KPCALHST.GetValueOrDefault();
                rmCustomerClass.KPDSTHST = customerClass.KPDSTHST.GetValueOrDefault();
                rmCustomerClass.KPERHIST = customerClass.KPERHIST.GetValueOrDefault();
                rmCustomerClass.KPTRXHST = customerClass.KPTRXHST.GetValueOrDefault();
                rmCustomerClass.DISGRPER = customerClass.DISGRPER.GetValueOrDefault();
                rmCustomerClass.DUEGRPER = customerClass.DUEGRPER.GetValueOrDefault();
                rmCustomerClass.Revalue_Customer = customerClass.Revalue_Customer.GetValueOrDefault();
                rmCustomerClass.Post_Results_To = customerClass.Post_Results_To.GetValueOrDefault();
                rmCustomerClass.ORDERFULFILLDEFAULT = customerClass.ORDERFULFILLDEFAULT.GetValueOrDefault();
                rmCustomerClass.CUSTPRIORITY = customerClass.CUSTPRIORITY.GetValueOrDefault();
                rmCustomerClass.RMOvrpymtWrtoffAcct = customerClass.RMOvrpymtWrtoffAcct;
                rmCustomerClass.RequesterTrx = customerClass.RequesterTrx.GetValueOrDefault();

                return rmCustomerClass;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private string SerializeCustomerClass(taCreateCustomerClass customerClass)
        {
            try
            {
                RMCustomerClassType classType = new RMCustomerClassType();
                eConnectType eConnect = new eConnectType();
                classType.taCreateCustomerClass = customerClass;
                RMCustomerClassType[] rmClassType = { classType };

                eConnect.RMCustomerClassType = rmClassType;

                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);

                string CustomerClassEntity = xmldoc.OuterXml;

                return CustomerClassEntity;


            }
            catch (XmlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
