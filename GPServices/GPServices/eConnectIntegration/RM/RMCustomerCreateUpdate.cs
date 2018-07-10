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
    public class RMCustomerCreateUpdate
    {
        public Response CustomerCreateUpdate(RMCustomer customer, RMParentID parent, List<RMParentIDChild> children, string company)
        {
            var response = new Response();

            string CustomerXML;
            string server = ConfigKey.ReadSetting("SERVER");
            //var server = Properties.Settings.Default.SERVER.ToString();
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();

            taUpdateCreateCustomerRcd rmCustomerCreateUpdate;
            taCreateParentID rmparent;
            taParentIDChild_ItemsTaParentIDChild[] rmchildren;

            try
            { 
                rmCustomerCreateUpdate = SetCustomerValues(customer);

                if (children.Count > 0)
                {
                    rmchildren = SetParentChildValues(children);
                    CustomerXML = SerializeCustomerChild(rmCustomerCreateUpdate, rmchildren);
                }
                else if(children.Count == 0 && ! string.IsNullOrEmpty(parent.CPRCSTNM))
                {
                    rmparent = SetParentValues(parent);
                    CustomerXML = SerializeCustomerParent(rmCustomerCreateUpdate, rmparent);
                }
                else
                {
                    CustomerXML = SerializeCustomer(rmCustomerCreateUpdate);
                }

                //CustomerXML = SerializeCustomer(rmCustomerCreateUpdate, rmparent, rmchildren);
                response = eConnect.CreateGPMaster(CNX, CustomerXML);

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

        private taUpdateCreateCustomerRcd SetCustomerValues(RMCustomer customer)
        {
            var pmCustomer = new taUpdateCreateCustomerRcd();
            try
            {
                pmCustomer.CUSTNMBR = customer.CUSTNMBR;
                pmCustomer.HOLD = customer.HOLD.GetValueOrDefault();
                pmCustomer.INACTIVE = customer.INACTIVE.GetValueOrDefault();
                pmCustomer.CUSTNAME = customer.CUSTNAME;
                pmCustomer.SHRTNAME = customer.SHRTNAME;
                pmCustomer.STMTNAME = customer.STMTNAME;
                pmCustomer.CUSTCLAS = customer.CUSTCLASS;
                pmCustomer.ADRSCODE = customer.ADRSCODE;
                pmCustomer.CNTCPRSN = customer.CNTCPRSN;
                pmCustomer.ADDRESS1 = customer.ADDRESS1;
                pmCustomer.ADDRESS2 = customer.ADDRESS2;
                pmCustomer.ADDRESS3 = customer.ADDRESS3;
                pmCustomer.CITY = customer.CITY;
                pmCustomer.STATE = customer.STATE;
                pmCustomer.ZIPCODE = customer.ZIPCODE;
                pmCustomer.CCode = customer.CCode;
                pmCustomer.COUNTRY = customer.COUNTRY;
                pmCustomer.PHNUMBR1 = customer.PHNUMBR1;
                pmCustomer.PHNUMBR2 = customer.PHNUMBR2;
                pmCustomer.PHNUMBR3 = customer.PHNUMBR3;
                pmCustomer.FAX = customer.FAX;
                pmCustomer.TAXSCHID = customer.TAXSCHID;
                pmCustomer.SLPRSNID = customer.SLPRSNID;
                pmCustomer.SALSTERR = customer.SALESTERR;
                pmCustomer.USERDEF1 = customer.USERDEF1;
                pmCustomer.USERDEF2 = customer.USERDEF2;
                pmCustomer.CRLMTTYP = customer.CRLMTTYP.GetValueOrDefault();
                pmCustomer.CRLMTPER = customer.CRLMTPER.GetValueOrDefault();
                pmCustomer.CRLMTAMT = customer.CRLMTAMT.GetValueOrDefault();
                pmCustomer.TXRGNNUM = customer.TXRGNNUM;
                pmCustomer.CURNCYID = customer.CURNCYID;
                pmCustomer.CHEKBKID = customer.CHEKBKID;
                pmCustomer.UseCustomerClass = customer.UseCustomerClass.GetValueOrDefault();
                pmCustomer.CreateAddress = customer.CreateAddress.GetValueOrDefault();
                pmCustomer.INTEGRATIONID = customer.INTEGRATIONID;
                pmCustomer.UpdateIfExists = customer.UpdateIfExists.GetValueOrDefault();

                return pmCustomer;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private taCreateParentID SetParentValues(RMParentID parent)
        {
            var rmparent = new taCreateParentID();
            try
            {
                rmparent.CPRCSTNM = parent.CPRCSTNM;
                rmparent.NAALLOWRECEIPTS = parent.NAALLOWRECEIPTS.GetValueOrDefault();
                rmparent.NACREDITCHECK = parent.NACREDITCHECK.GetValueOrDefault();
                rmparent.NAFINANCECHARGE = parent.NAFINANCECHARGE.GetValueOrDefault();
                rmparent.NAHOLDINACTIVE = parent.NAHOLDINACTIVE.GetValueOrDefault();
                rmparent.NADEFPARENTVEN = parent.NADEFPARENTVEN.GetValueOrDefault();
                rmparent.UpdateIfExists = parent.UpdateIfExists.GetValueOrDefault();
                rmparent.RequesterTrx = parent.RequesterTrx.GetValueOrDefault();

                return rmparent;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private taParentIDChild_ItemsTaParentIDChild[] SetParentChildValues(List<RMParentIDChild> children)
        {
            try
            {
                var rmparentchild = new List<taParentIDChild_ItemsTaParentIDChild>();
                foreach (RMParentIDChild item in children)
                {
                    var rmparentchildInsert = new taParentIDChild_ItemsTaParentIDChild();

                    rmparentchildInsert.CPRCSTNM = item.CPRCSTNM;
                    rmparentchildInsert.CUSTNMBR = item.CUSTNMBR;
                    rmparentchildInsert.CreateRemove = item.CreateRemove.GetValueOrDefault();
                    rmparentchildInsert.RequesterTrx = item.RequesterTrx.GetValueOrDefault();

                    rmparentchild.Add(rmparentchildInsert);
                }

                return rmparentchild.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string SerializeCustomer(taUpdateCreateCustomerRcd rmcustomer)
        {
            try
            {
                RMCustomerMasterType customerMasterType = new RMCustomerMasterType();
                eConnectType eConnect = new eConnectType();
                customerMasterType.taUpdateCreateCustomerRcd = rmcustomer;

                RMCustomerMasterType[] Customers = { customerMasterType };

                eConnect.RMCustomerMasterType = Customers;
                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);

                string CustomerEntity = xmldoc.OuterXml;
                return CustomerEntity;

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

        private string SerializeCustomerParent(taUpdateCreateCustomerRcd rmcustomer,  taCreateParentID rmparent)
        {
            try
            {
                RMCustomerMasterType customerMasterType = new RMCustomerMasterType();
                eConnectType eConnect = new eConnectType();
                customerMasterType.taUpdateCreateCustomerRcd = rmcustomer;
                customerMasterType.taCreateParentID = rmparent;

                RMCustomerMasterType[] Customers = { customerMasterType };

                eConnect.RMCustomerMasterType = Customers;
                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);

                string CustomerEntity = xmldoc.OuterXml;
                return CustomerEntity;

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

        private string SerializeCustomerChild(taUpdateCreateCustomerRcd rmcustomer, taParentIDChild_ItemsTaParentIDChild[] rmchildren)
        {
            try
            {
                RMCustomerMasterType customerMasterType = new RMCustomerMasterType();
                eConnectType eConnect = new eConnectType();
                customerMasterType.taUpdateCreateCustomerRcd = rmcustomer;
                //customerMasterType.taCreateParentID = rmparent;
                customerMasterType.taParentIDChild_Items = rmchildren;

                RMCustomerMasterType[] Customers = { customerMasterType };

                eConnect.RMCustomerMasterType = Customers;
                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);

                string CustomerEntity = xmldoc.OuterXml;
                return CustomerEntity;

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
