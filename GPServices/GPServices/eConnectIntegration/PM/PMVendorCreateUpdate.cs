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
using PMClass;

namespace eConnectIntegration.PM
{
    /// <summary>
    /// 
    /// </summary>
    public class PMVendorCreateUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response VendorCreateUpdate(PMVendor vendor, string company)
        {

            var response = new Response();
            string VendorXML;
            string server = ConfigKey.ReadSetting("SERVER");
            //var server = Properties.Settings.Default.SERVER.ToString();
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            taUpdateCreateVendorRcd pmVendorCreateUpdate;
            try
            {
                pmVendorCreateUpdate = SetVendorValues(vendor);
                VendorXML = SerializeVendor(pmVendorCreateUpdate);
                response = eConnect.CreateGPMaster(CNX, VendorXML);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        private taUpdateCreateVendorRcd SetVendorValues(PMVendor vendor)
        {
            var pmVendorCreateUpdate = new taUpdateCreateVendorRcd();

            try
            {
                pmVendorCreateUpdate.VENDORID = vendor.VENDORID;
                pmVendorCreateUpdate.VENDNAME = vendor.VENDNAME;
                pmVendorCreateUpdate.VENDSHNM = vendor.VENDSHNM;
                pmVendorCreateUpdate.VNDCHKNM = vendor.VNDCHKNM;
                pmVendorCreateUpdate.HOLD = vendor.HOLD.GetValueOrDefault();
                pmVendorCreateUpdate.VENDSTTS = vendor.VENDSTTS.GetValueOrDefault();
                pmVendorCreateUpdate.VNDCLSID = vendor.VNDCLSID;
                pmVendorCreateUpdate.VADDCDPR = vendor.VADDCDPR;
                pmVendorCreateUpdate.VNDCNTCT = vendor.VNDCNTCT;
                pmVendorCreateUpdate.ADDRESS1 = vendor.ADDRESS1;
                pmVendorCreateUpdate.ADDRESS2 = vendor.ADDRESS2;
                pmVendorCreateUpdate.ADDRESS3 = vendor.ADDRESS3;
                pmVendorCreateUpdate.CITY = vendor.CITY;
                pmVendorCreateUpdate.STATE = vendor.STATE;
                pmVendorCreateUpdate.ZIPCODE = vendor.ZIPCODE;
                pmVendorCreateUpdate.CCode = vendor.CCode;
                pmVendorCreateUpdate.COUNTRY = vendor.COUNTRY;
                pmVendorCreateUpdate.PHNUMBR1 = vendor.PHNUMBR1;
                pmVendorCreateUpdate.PHNUMBR2 = vendor.PHNUMBR2;
                pmVendorCreateUpdate.PHNUMBR3 = vendor.PHNUMBR3;
                pmVendorCreateUpdate.FAXNUMBR = vendor.FAXNUMBR;
                pmVendorCreateUpdate.TAXSCHID = vendor.TAXSCHID;
                pmVendorCreateUpdate.SHIPMTHD = vendor.SHIPMTHD;
                pmVendorCreateUpdate.UPSZONE = vendor.UPSZONE;
                pmVendorCreateUpdate.VADCDPAD = vendor.VADCDPAD;
                pmVendorCreateUpdate.VADCDTRO = vendor.VADCDTRO;
                pmVendorCreateUpdate.VADCDSFR = vendor.VADCDSFR;
                pmVendorCreateUpdate.ACNMVNDR = vendor.ACNMVNDR;
                pmVendorCreateUpdate.COMMENT1 = vendor.COMMENT1;
                pmVendorCreateUpdate.COMMENT2 = vendor.COMMENT2;
                pmVendorCreateUpdate.NOTETEXT = vendor.NOTETEXT;
                pmVendorCreateUpdate.CURNCYID = vendor.CURNCYID;
                pmVendorCreateUpdate.RATETPID = vendor.RATETPID;
                pmVendorCreateUpdate.PYMTRMID = vendor.PYMTRMID;
                pmVendorCreateUpdate.DISGRPER = vendor.DISGRPER.GetValueOrDefault();
                pmVendorCreateUpdate.DUEGRPER = vendor.DUEGRPER.GetValueOrDefault();
                pmVendorCreateUpdate.PYMNTPRI = vendor.PYMNTPRI;
                pmVendorCreateUpdate.MINORDER = vendor.MINORDER.GetValueOrDefault();
                pmVendorCreateUpdate.TRDDISCT = vendor.TRDDISCT.GetValueOrDefault();
                pmVendorCreateUpdate.TXIDNMBR = vendor.TXIDNMBR;
                pmVendorCreateUpdate.TXRGNNUM = vendor.TXRGNNUM;
                pmVendorCreateUpdate.CHEKBKID = vendor.CHEKBKID;
                pmVendorCreateUpdate.USERDEF1 = vendor.USERDEF1;
                pmVendorCreateUpdate.USERDEF2 = vendor.USERDEF2;
                pmVendorCreateUpdate.TEN99TYPE = vendor.TEN99TYPE.GetValueOrDefault();
                pmVendorCreateUpdate.TEN99BOXNUMBER = vendor.TEN99BOXNUMBER.GetValueOrDefault();
                pmVendorCreateUpdate.FREEONBOARD = vendor.FREEONBOARD.GetValueOrDefault();
                pmVendorCreateUpdate.USERLANG = vendor.USERLANG.GetValueOrDefault();
                pmVendorCreateUpdate.MINPYTYP = vendor.MINPYTYP.GetValueOrDefault();
                pmVendorCreateUpdate.MINPYDLR = vendor.MINPYDLR.GetValueOrDefault();
                pmVendorCreateUpdate.MINPYPCT = vendor.MINPYPCT.GetValueOrDefault();
                pmVendorCreateUpdate.MXIAFVND = vendor.MXIAFVND.GetValueOrDefault();
                pmVendorCreateUpdate.MAXINDLR = vendor.MAXINDLR.GetValueOrDefault();
                pmVendorCreateUpdate.CREDTLMT = vendor.CREDTLMT.GetValueOrDefault();
                pmVendorCreateUpdate.CRLMTDLR = vendor.CRLMTDLR.GetValueOrDefault();
                pmVendorCreateUpdate.WRITEOFF = vendor.WRITEOFF.GetValueOrDefault();
                pmVendorCreateUpdate.MXWOFAMT = vendor.MXWOFAMT.GetValueOrDefault();
                pmVendorCreateUpdate.Revalue_Vendor = vendor.Revalue_Vendor.GetValueOrDefault();
                pmVendorCreateUpdate.Post_Results_To = vendor.Post_Results_To.GetValueOrDefault();
                pmVendorCreateUpdate.KPCALHST = vendor.KPCALHST.GetValueOrDefault();
                pmVendorCreateUpdate.KPERHIST = vendor.KPERHIST.GetValueOrDefault();
                pmVendorCreateUpdate.KPTRXHST = vendor.KPTRXHST.GetValueOrDefault();
                pmVendorCreateUpdate.KGLDSTHS = vendor.KGLDSTHS.GetValueOrDefault();
                pmVendorCreateUpdate.PTCSHACF = vendor.PTCSHACF.GetValueOrDefault();
                pmVendorCreateUpdate.PMCSHACTNUMST = vendor.PMCSHACTNUMST;
                pmVendorCreateUpdate.PMAPACTNUMST = vendor.PMAPACTNUMST;
                pmVendorCreateUpdate.PMDAVACTNUMST = vendor.PMDAVACTNUMST;
                pmVendorCreateUpdate.PMDTKACTNUMST = vendor.PMDTKACTNUMST;
                pmVendorCreateUpdate.PMFINACTNUMST = vendor.PMFINACTNUMST;
                pmVendorCreateUpdate.PMPRCHACTNUMST = vendor.PMPRCHACTNUMST;
                pmVendorCreateUpdate.PMTDSCACTNUMST = vendor.PMTDSCACTNUMST;
                pmVendorCreateUpdate.PMMSCHACTNUMST = vendor.PMMSCHACTNUMST;
                pmVendorCreateUpdate.PMFRTACTNUMST = vendor.PMFRTACTNUMST;
                pmVendorCreateUpdate.PMTAXACTNUMST = vendor.PMTAXACTNUMST;
                pmVendorCreateUpdate.PMWRTACTNUMST = vendor.PMWRTACTNUMST;
                pmVendorCreateUpdate.ACPURACTNUMST = vendor.ACPURACTNUMST;
                pmVendorCreateUpdate.PURPVACTNUMST = vendor.PURPVACTNUMST;
                pmVendorCreateUpdate.UseVendorClass = vendor.UseVendorClass.GetValueOrDefault();
                pmVendorCreateUpdate.CreateAddress = vendor.CreateAddress.GetValueOrDefault();
                pmVendorCreateUpdate.UpdateIfExists = vendor.UpdateIfExists.GetValueOrDefault();
                pmVendorCreateUpdate.RequesterTrx = vendor.RequesterTrx.GetValueOrDefault();

                return pmVendorCreateUpdate;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        private string SerializeVendor(taUpdateCreateVendorRcd vendor)
        {
            try
            {
                PMVendorMasterType VendorMasterType = new PMVendorMasterType();
                eConnectType eConnect = new eConnectType();
                VendorMasterType.taUpdateCreateVendorRcd = vendor;
                PMVendorMasterType[] VendorsMasterType = { VendorMasterType };

                eConnect.PMVendorMasterType = VendorsMasterType;
                
                //MemoryStream ms = new MemoryStream();
                FileStream FS = new FileStream(@"C:\DOCS\eConnectVendor.xml", FileMode.Create);

                XmlTextWriter writer = new XmlTextWriter(FS, new UTF8Encoding());

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(writer, eConnect);
                writer.Close();

                XmlDocument xmldoc = new XmlDocument();
                

                xmldoc.Load(@"C:\DOCS\eConnectVendor.xml");
                
                string VendorEntity = xmldoc.OuterXml;

                File.Delete(@"C:\DOCS\eConnectVendor.xml");

                return VendorEntity;

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
        */


        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        private string SerializeVendor(taUpdateCreateVendorRcd vendor)
        {
            try
            {
                PMVendorMasterType VendorMasterType = new PMVendorMasterType();
                eConnectType eConnect = new eConnectType();
                VendorMasterType.taUpdateCreateVendorRcd = vendor;
                PMVendorMasterType[] VendorsMasterType = { VendorMasterType };

                eConnect.PMVendorMasterType = VendorsMasterType;

                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);
                string VendorEntity = xmldoc.OuterXml;
                return VendorEntity;

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
