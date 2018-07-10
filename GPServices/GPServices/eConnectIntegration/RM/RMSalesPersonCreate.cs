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
    public class RMSalesPersonCreate
    {
        public Response SalesPresonCreate(RMSalesPerson salesperson, string company)
        {
            var response = new Response();
            string SalesPersonXML;
            string server = ConfigKey.ReadSetting("SERVER");
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();

            taCreateSalesperson rmSalesPerson;
            try
            {
                rmSalesPerson = SetSalesPersonValues(salesperson);
                SalesPersonXML = SerializeSalesPerson(rmSalesPerson);
                response = eConnect.CreateGPMaster(CNX, SalesPersonXML);

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

        private taCreateSalesperson SetSalesPersonValues(RMSalesPerson salesperson)
        {
            taCreateSalesperson rmsalespersoninsert = new taCreateSalesperson();
            try
            {
                rmsalespersoninsert.SLPRSNID = salesperson.SLPRSNID;
                rmsalespersoninsert.SALSTERR = salesperson.SALSTERR;
                rmsalespersoninsert.EMPLOYID = salesperson.EMPLOYID;
                rmsalespersoninsert.VENDORID = salesperson.VEDORID;
                rmsalespersoninsert.SLPRSNFN = salesperson.SLPRSNFN;
                rmsalespersoninsert.SPRSNSMN = salesperson.SPRSNSMN;
                rmsalespersoninsert.SPRSNSLN = salesperson.SPRSNSLN;
                rmsalespersoninsert.ADDRESS1 = salesperson.ADDRESS1;
                rmsalespersoninsert.ADDRESS2 = salesperson.ADDRESS2;
                rmsalespersoninsert.ADDRESS3 = salesperson.ADDRESS3;
                rmsalespersoninsert.CITY = salesperson.CITY;
                rmsalespersoninsert.STATE = salesperson.STATE;
                rmsalespersoninsert.ZIP = salesperson.ZIP;
                rmsalespersoninsert.COUNTRY = salesperson.COUNTRY;
                rmsalespersoninsert.PHONE1 = salesperson.PHONE1;
                rmsalespersoninsert.PHONE2 = salesperson.PHONE2;
                rmsalespersoninsert.PHONE3 = salesperson.PHONE3;
                rmsalespersoninsert.FAX = salesperson.FAX;
                rmsalespersoninsert.INACTIVE = salesperson.INACTIVE.GetValueOrDefault();
                rmsalespersoninsert.COMMCODE = salesperson.COMMCODE;
                rmsalespersoninsert.COMPRCNT = salesperson.COMPRCNT.GetValueOrDefault();
                rmsalespersoninsert.STDCPRCT = salesperson.STDCPRCT.GetValueOrDefault();
                rmsalespersoninsert.COMAPPTO = salesperson.COMAPPTO.GetValueOrDefault();
                rmsalespersoninsert.COSTTODT = salesperson.COSTTODT.GetValueOrDefault();
                rmsalespersoninsert.CSTLSTYR = salesperson.CSTLSTYR.GetValueOrDefault();
                rmsalespersoninsert.TTLCOMTD = salesperson.TTLCOMTD.GetValueOrDefault();
                rmsalespersoninsert.TTLCOMLY = salesperson.TTLCOMLY.GetValueOrDefault();
                rmsalespersoninsert.COMSLTDT = salesperson.COMSLTDT.GetValueOrDefault();
                rmsalespersoninsert.COMSLLYR = salesperson.COMSLLYR.GetValueOrDefault();
                rmsalespersoninsert.NCOMSLTD = salesperson.NCOMSLTD.GetValueOrDefault();
                rmsalespersoninsert.NCOMSLYR = salesperson.NCOMSLYR.GetValueOrDefault();
                rmsalespersoninsert.KPCALHST = salesperson.KPCALHST.GetValueOrDefault();

                if (salesperson.MODIFDT != null)
                {
                    rmsalespersoninsert.MODIFDT = salesperson.MODIFDT.GetValueOrDefault().ToShortDateString();
                }

                if (salesperson.CREATDDT != null)
                {
                    rmsalespersoninsert.CREATDDT = salesperson.CREATDDT.GetValueOrDefault().ToShortDateString();
                }

                rmsalespersoninsert.COMMDEST = salesperson.COMMDEST.GetValueOrDefault();
                rmsalespersoninsert.UpdateIfExists = salesperson.UpdateIfExists.GetValueOrDefault();
                rmsalespersoninsert.RequesterTrx = salesperson.RequesterTrx.GetValueOrDefault();


                return rmsalespersoninsert;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string SerializeSalesPerson(taCreateSalesperson salesperson)
        {
            try
            {
                RMSalespersonMasterType salespersonType = new RMSalespersonMasterType();
                eConnectType eConnect = new eConnectType();
                salespersonType.taCreateSalesperson = salesperson;

                RMSalespersonMasterType[] rmsalesperson = { salespersonType };

                eConnect.RMSalespersonMasterType = rmsalesperson;

                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);

                string SalespersonEntity = xmldoc.OuterXml;
                return SalespersonEntity;
            }
            catch(XmlException)
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
