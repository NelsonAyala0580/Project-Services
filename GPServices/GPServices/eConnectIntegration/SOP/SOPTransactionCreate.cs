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
using SOPClass;


namespace eConnectIntegration.SOP
{
    public class SOPTransactionCreate
    {
        public Response TransactionCreate(SOPHeader header, List<SOPDetail> detail, List<SOPDistribution> distribution, List<SOPTax> taxes, List<SOPCommissions> commissions, SopType soptype, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            //var server = Properties.Settings.Default.SERVER.ToString();
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();

            SOPTransactionType sopTranType = new SOPTransactionType();
            var getnext = new GetNextDocNumbers();
            getnext.RequireServiceProxy = false;
            string INVOICENUMBER;
            try
            {


                if (header.SOPNUMBE == string.Empty)
                {
                    INVOICENUMBER = getnext.GetNextSOPNumber(IncrementDecrement.Increment, header.DOCID, soptype, CNX);
                }
                else
                {
                    INVOICENUMBER = header.SOPNUMBE;
                }


                sopTranType.taSopHdrIvcInsert = SetHeaderValues(header, INVOICENUMBER);
                sopTranType.taSopLineIvcInsert_Items = SetDetailValues(detail, INVOICENUMBER);
                sopTranType.taSopDistribution_Items = SetDistributionValues(distribution, INVOICENUMBER);
                sopTranType.taSopLineIvcTaxInsert_Items = SetTaxValues(taxes, INVOICENUMBER);
                sopTranType.taSopCommissions_Items = SetCommissionValues(commissions, INVOICENUMBER);

                transactionXML = SerializeSOPTransaction(sopTranType);
                response = eConnect.CreateGPTransaction(CNX, transactionXML);

                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private taSopHdrIvcInsert SetHeaderValues(SOPHeader header, string invoicenumber)
        {
            try
            {
                var sopHeaderInsert = new taSopHdrIvcInsert();
                sopHeaderInsert.SOPTYPE = header.SOPTYPE;
                sopHeaderInsert.DOCID = header.DOCID;
                //sopHeaderInsert.DOCDATE = header.DOCDATE.ToString("dd/MM/yyyy");
                sopHeaderInsert.DOCDATE = header.DOCDATE.ToString("yyyy-MM-dd");
                sopHeaderInsert.SOPNUMBE = invoicenumber;
                sopHeaderInsert.ORIGNUMB = header.ORIGNUMB;
                sopHeaderInsert.ORIGTYPE = header.ORIGTYPE.GetValueOrDefault();
                sopHeaderInsert.TAXSCHID = header.TAXSCHID;
                sopHeaderInsert.FRTSCHID = header.FRTSCHID;
                sopHeaderInsert.MSCSCHID = header.MSCSCHID;
                sopHeaderInsert.SHIPMTHD = header.SHIPMTHD;
                sopHeaderInsert.TAXAMNT = header.TAXAMNT.GetValueOrDefault();
                sopHeaderInsert.LOCNCODE = header.LOCNCODE;
                sopHeaderInsert.FREIGHT = header.FREIGHT.GetValueOrDefault();
                sopHeaderInsert.MISCAMNT = header.MISCAMNT.GetValueOrDefault();
                sopHeaderInsert.TRDISAMT = header.TRDISAMT.GetValueOrDefault();
                sopHeaderInsert.TRADEPCT = header.TRADEPCT.GetValueOrDefault();
                sopHeaderInsert.DISTKNAM = header.DISTKNAM.GetValueOrDefault();
                sopHeaderInsert.MRKDNAMT = header.MRKDNAMT.GetValueOrDefault();

                sopHeaderInsert.CUSTNAME = header.CSTPONBR;
                sopHeaderInsert.ShipToName = header.ShipToName;
                sopHeaderInsert.ADDRESS1 = header.ADDRESS1;
                sopHeaderInsert.ADDRESS2 = header.ADDRESS2;
                sopHeaderInsert.ADDRESS3 = header.ADDRESS3;
                sopHeaderInsert.CNTCPRSN = header.CNTCPRSN;
                sopHeaderInsert.FAXNUMBR = header.FAXNUMBR;
                sopHeaderInsert.CITY = header.CITY;
                sopHeaderInsert.STATE = header.STATE;
                sopHeaderInsert.ZIPCODE = header.ZIPCODE;
                sopHeaderInsert.COUNTRY = header.COUNTRY;
                sopHeaderInsert.PHNUMBR1 = header.PHNUMBR1;
                sopHeaderInsert.PHNUMBR2 = header.PHNUMBR2;
                sopHeaderInsert.PHNUMBR3 = header.PHNUMBR3;
                sopHeaderInsert.Print_Phone_NumberGB = 0;
                sopHeaderInsert.Print_Phone_NumberGBSpecified = true;
                sopHeaderInsert.SUBTOTAL = header.SUBTOTAL.GetValueOrDefault();
                sopHeaderInsert.DOCAMNT = header.DOCAMNT.GetValueOrDefault();
                sopHeaderInsert.PYMTRCVD = header.PYMTRCVD.GetValueOrDefault();
                sopHeaderInsert.SALSTERR = header.SALSTERR;
                sopHeaderInsert.SLPRSNID = header.SLPRSNID;
                sopHeaderInsert.UPSZONE = header.UPSZONE;
                sopHeaderInsert.USER2ENT = header.USER2ENT;
                sopHeaderInsert.BACHNUMB = header.BACHNUMB;
                sopHeaderInsert.PRBTADCD = header.PRBTADCD;
                sopHeaderInsert.PRSTADCD = header.PRSTADCD;
                sopHeaderInsert.FRTTXAMT = header.FRTTXAMT.GetValueOrDefault();
                sopHeaderInsert.MSCTXAMT = header.MSCTXAMT.GetValueOrDefault();

                if (header.ORDRDATE != null)
                {
                    sopHeaderInsert.ORDRDATE = header.ORDRDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                sopHeaderInsert.MSTRNUMB = header.MSTRNUMB.GetValueOrDefault();
                sopHeaderInsert.PYMTRMID = header.PYMTRMID;

                if (header.DUEDATE != null)
                {
                    sopHeaderInsert.DUEDATE = header.DUEDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (header.DISCDATE != null)
                {
                    sopHeaderInsert.DISCDATE = header.DISCDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                sopHeaderInsert.REFRENCE = header.REFRENCE;
                sopHeaderInsert.USINGHEADERLEVELTAXES = header.USINGHEADERLEVELTAXES.GetValueOrDefault();
                sopHeaderInsert.BatchCHEKBKID = header.BatchCHEKBKID;
                sopHeaderInsert.CREATECOMM = header.CREATECOMM.GetValueOrDefault();
                sopHeaderInsert.COMMAMNT = header.COMMAMNT;
                sopHeaderInsert.COMPRCNT = header.COMPRCNT;
                sopHeaderInsert.CREATEDIST = header.CREATEDIST.GetValueOrDefault();
                sopHeaderInsert.CREATETAXES = header.CREATETAXES.GetValueOrDefault();
                sopHeaderInsert.DEFTAXSCHDS = header.DEFTAXSCHDS.GetValueOrDefault();
                sopHeaderInsert.CURNCYID = header.CURNCYID;
                sopHeaderInsert.XCHGRATE = header.XCHGRATE.GetValueOrDefault();
                sopHeaderInsert.RATETPID = header.RATETPID;

                if (header.EXPNDATE != null)
                {
                    sopHeaderInsert.EXPNDATE = header.EXPNDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (header.EXCHDATE != null)
                {
                    sopHeaderInsert.EXCHDATE = header.EXCHDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                sopHeaderInsert.EXGTBDSC = header.EXGTBDSC;
                sopHeaderInsert.EXTBLSRC = header.EXTBLSRC;
                sopHeaderInsert.RATEEXPR = header.RATEEXPR.GetValueOrDefault();
                sopHeaderInsert.DYSTINCR = header.DYSTINCR.GetValueOrDefault();
                sopHeaderInsert.RATEVARC = header.RATEVARC.GetValueOrDefault();
                sopHeaderInsert.TRXDTDEF = header.TRXDTDEF.GetValueOrDefault();
                sopHeaderInsert.RTCLCMTD = header.RTCLCMTD.GetValueOrDefault();
                sopHeaderInsert.PRVDSLMT = header.PRVDSLMT.GetValueOrDefault();
                sopHeaderInsert.DATELMTS = header.DATELMTS.GetValueOrDefault();

                if (header.TIME1 != null)
                {
                    sopHeaderInsert.TIME1 = header.TIME1.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                sopHeaderInsert.DISAVAMT = header.DISAVAMT.GetValueOrDefault();
                sopHeaderInsert.DSCDLRAM = header.DSCDLRAM.GetValueOrDefault();
                sopHeaderInsert.DSCPCTAM = header.DSCPCTAM.GetValueOrDefault();
                sopHeaderInsert.FREIGTBLE = header.FREIGTBLE.GetValueOrDefault();
                sopHeaderInsert.MISCTBLE = header.MISCTBLE.GetValueOrDefault();
                sopHeaderInsert.COMMNTID = header.COMMNTID;
                sopHeaderInsert.COMMENT_1 = header.COMMENT_1;
                sopHeaderInsert.COMMENT_2 = header.COMMENT_2;
                sopHeaderInsert.COMMENT_3 = header.COMMENT_3;
                sopHeaderInsert.COMMENT_4 = header.COMMENT_4;
                sopHeaderInsert.GPSFOINTEGRATIONID = header.GPSFOINTEGRATIONID;
                sopHeaderInsert.INTEGRATIONSOURCE = header.INTEGRATIONSOURCE.GetValueOrDefault();
                sopHeaderInsert.INTEGRATIONID = header.INTEGRATIONID;

                if (header.ReqShipDate != null)
                {
                    sopHeaderInsert.ReqShipDate = header.ReqShipDate.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                sopHeaderInsert.RequesterTrx = header.RequesterTrx.GetValueOrDefault();
                sopHeaderInsert.CKCreditLimit = header.CKCreditLimit.GetValueOrDefault();
                sopHeaderInsert.CKHOLD = header.CKHOLD.GetValueOrDefault();
                sopHeaderInsert.UpdateExisting = header.UpdateExisting.GetValueOrDefault();

                if (header.QUOEXPDA != null)
                {
                    sopHeaderInsert.QUOEXPDA = header.QUOEXPDA.GetValueOrDefault().ToShortDateString();
                }

                if (header.QUOTEDAT != null)
                {
                    sopHeaderInsert.QUOTEDAT = header.QUOTEDAT.GetValueOrDefault().ToShortDateString();
                }

                if (header.INVODATE != null)
                {
                    sopHeaderInsert.INVODATE = header.INVODATE.GetValueOrDefault().ToShortDateString();
                }

                if (header.BACKDATE != null)
                {
                    sopHeaderInsert.BACKDATE = header.BACKDATE.GetValueOrDefault().ToShortDateString();
                }

                if (header.RETUDATE != null)
                {
                    sopHeaderInsert.RETUDATE = header.RETUDATE.GetValueOrDefault().ToShortDateString();
                }


                sopHeaderInsert.CMMTTEXT = header.CMMTTEXT;
                sopHeaderInsert.PRCLEVEL = header.PRCLEVEL;
                sopHeaderInsert.DEFPRICING = header.DEFPRICING.GetValueOrDefault();
                sopHeaderInsert.TAXEXMT1 = header.TAXEXMT1;
                sopHeaderInsert.TAXEXMT2 = header.TAXEXMT2;
                sopHeaderInsert.TXRGNNUM = header.TXRGNNUM;
                sopHeaderInsert.REPTING = header.REPTING.GetValueOrDefault();
                sopHeaderInsert.TRXFREQU = header.TRXFREQU.GetValueOrDefault();
                sopHeaderInsert.TIMETREP = header.TIMETREP.GetValueOrDefault();
                sopHeaderInsert.QUOTEDYSTINCR = header.QUOTEDYSTINCR.GetValueOrDefault();
                sopHeaderInsert.NOTETEXT = header.NOTETEXT;
                sopHeaderInsert.CUSTNMBR = header.CUSTNMBR;

                return sopHeaderInsert;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private taSopLineIvcInsert_ItemsTaSopLineIvcInsert[] SetDetailValues(List<SOPDetail> detail, string InvoiceNumber)
        {
            try
            {
                var SopLine = new List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert>();
                foreach (SOPDetail item in detail)
                {
                    var sopDetailInsert = new taSopLineIvcInsert_ItemsTaSopLineIvcInsert();
                    sopDetailInsert.SOPTYPE = item.SOPTYPE;
                    sopDetailInsert.SOPNUMBE = InvoiceNumber;
                    sopDetailInsert.CUSTNMBR = item.CUSTNMBR;
                    //sopDetailInsert.DOCDATE = item.DOCDATE.ToString("dd/MM/yyyy");
                    sopDetailInsert.DOCDATE = item.DOCDATE.ToString("yyyy-MM-dd");
                    //sopDetailInsert.USERDATE = item.USERDATE.ToString("dd/MM/yyyy");
                    sopDetailInsert.USERDATE = item.USERDATE.ToString("yyyy-MM-dd");
                    sopDetailInsert.LOCNCODE = item.LOCNCODE;
                    sopDetailInsert.ITEMNMBR = item.ITEMNMBR;
                    sopDetailInsert.AutoAssignBin = item.AutoAssignBin.GetValueOrDefault();
                    sopDetailInsert.UNITPRCE = item.UNITPRCE.GetValueOrDefault();
                    sopDetailInsert.XTNDPRCE = item.XTNDPRCE.GetValueOrDefault();
                    sopDetailInsert.QUANTITY = item.QUANTITY.GetValueOrDefault();
                    sopDetailInsert.MRKDNAMT = item.MRKDNAMT.GetValueOrDefault();
                    sopDetailInsert.MRKDNPCT = item.MRKDNPCT.GetValueOrDefault();
                    sopDetailInsert.COMMNTID = item.COMMNTID;
                    sopDetailInsert.COMMENT_1 = item.COMMENT_1;
                    sopDetailInsert.COMMENT_2 = item.COMMENT_2;
                    sopDetailInsert.COMMENT_3 = item.COMMENT_3;
                    sopDetailInsert.COMMENT_4 = item.COMMENT_4;
                    sopDetailInsert.UNITCOST = item.UNITCOST.GetValueOrDefault();
                    sopDetailInsert.PRCLEVEL = item.PRCLEVEL;
                    sopDetailInsert.ITEMDESC = item.ITEMDESC;
                    sopDetailInsert.TAXAMNT = item.TAXAMNT.GetValueOrDefault();
                    sopDetailInsert.QTYONHND = item.QTYONHND.GetValueOrDefault();
                    sopDetailInsert.QTYRTRND = item.QTYRTRND.GetValueOrDefault();
                    sopDetailInsert.QTYINUSE = item.QTYINUSE.GetValueOrDefault();
                    sopDetailInsert.QTYINSVC = item.QTYINSVC.GetValueOrDefault();
                    sopDetailInsert.QTYDMGED = item.QTYDMGED.GetValueOrDefault();
                    sopDetailInsert.NONINVEN = item.NONINVEN.GetValueOrDefault();
                    sopDetailInsert.LNITMSEQ = item.LNITMSEQ.GetValueOrDefault();
                    sopDetailInsert.DROPSHIP = item.DROPSHIP.GetValueOrDefault();
                    sopDetailInsert.QTYTBAOR = item.QTYTBAOR.GetValueOrDefault();
                    sopDetailInsert.DOCID = item.DOCID;
                    sopDetailInsert.SALSTERR = item.SALSTERR;
                    sopDetailInsert.SLPRSNID = item.SLPRSNID;
                    sopDetailInsert.ITMTSHID = item.ITMTSHID;
                    sopDetailInsert.IVITMTXB = item.IVITMTXB.GetValueOrDefault();
                    sopDetailInsert.TAXSCHID = item.TAXSCHID;
                    sopDetailInsert.PRSTADCD = item.PRSTADCD;
                    sopDetailInsert.ShipToName = item.ShipToName;
                    sopDetailInsert.CNTCPRSN = item.CNTCPRSN;
                    sopDetailInsert.ADDRESS1 = item.ADDRESS1;
                    sopDetailInsert.ADDRESS2 = item.ADDRESS2;
                    sopDetailInsert.ADDRESS3 = item.ADDRESS3;
                    sopDetailInsert.CITY = item.CITY;
                    sopDetailInsert.STATE = item.STATE;
                    sopDetailInsert.ZIPCODE = item.ZIPCODE;
                    sopDetailInsert.COUNTRY = item.COUNTRY;
                    sopDetailInsert.PHONE1 = item.PHONE1;
                    sopDetailInsert.PHONE2 = item.PHONE2;
                    sopDetailInsert.PHONE3 = item.PHONE3;
                    sopDetailInsert.FAXNUMBR = item.FAXNUMBR;
                    sopDetailInsert.EXCEPTIONALDEMAND = item.EXCEPTIONALDEMAND.GetValueOrDefault();

                    if (item.ReqShipDate != null)
                    {
                        sopDetailInsert.ReqShipDate = item.ReqShipDate.GetValueOrDefault().ToString("yyyy-MM-dd");
                    }
                    if (item.FUFILDAT !=null)
                    {
                        sopDetailInsert.FUFILDAT = item.FUFILDAT.GetValueOrDefault().ToString("yyyy-MM-dd");
                    }
                    if(item.ACTLSHIP !=null)
                    {
                        sopDetailInsert.ACTLSHIP = item.ACTLSHIP.GetValueOrDefault().ToString("yyyy-MM-dd");
                    }

                    sopDetailInsert.SHIPMTHD = item.SHIPMTHD;
                    sopDetailInsert.INVINDX = item.INVINDX;
                    sopDetailInsert.CSLSINDX = item.CSLSINDX;
                    sopDetailInsert.SLSINDX = item.SLSINDX;
                    sopDetailInsert.MKDNINDX = item.MKDNINDX;
                    sopDetailInsert.RTNSINDX = item.RTNSINDX;
                    sopDetailInsert.INUSINDX = item.INUSINDX;
                    sopDetailInsert.INSRINDX = item.INSRINDX;
                    sopDetailInsert.DMGDINDX = item.DMGDINDX;
                    sopDetailInsert.AUTOALLOCATESERIAL = item.AUTOALLOCATESERIAL.GetValueOrDefault();
                    sopDetailInsert.AUTOALLOCATELOT = item.AUTOALLOCATELOT.GetValueOrDefault();
                    sopDetailInsert.GPSFOINTEGRATIONID = item.GPSFOINTEGRATIONID;
                    sopDetailInsert.INTEGRATIONSOURCE = item.INTEGRATIONSOURCE.GetValueOrDefault();
                    sopDetailInsert.INTEGRATIONID = item.INTEGRATIONID;
                    sopDetailInsert.RequesterTrx = item.RequesterTrx.GetValueOrDefault();
                    sopDetailInsert.QTYCANCE = item.QTYCANCE.GetValueOrDefault();
                    sopDetailInsert.QTYFULFI = item.QTYFULFI.GetValueOrDefault();
                    sopDetailInsert.ALLOCATE = item.ALLOCATE.GetValueOrDefault();
                    sopDetailInsert.UpdateIfExists = item.UpdateIfExists.GetValueOrDefault();
                    sopDetailInsert.RecreateDist = item.RecreateDist.GetValueOrDefault();
                    sopDetailInsert.QUOTEQTYTOINV = item.QUOTEQTYTOINV.GetValueOrDefault();
                    sopDetailInsert.TOTALQTY = item.TOTALQTY.GetValueOrDefault();
                    sopDetailInsert.CMMTTEXT = item.CMMTTEXT;
                    sopDetailInsert.KitCompMan = item.KitCompMan.GetValueOrDefault();
                    sopDetailInsert.DEFPRICING = item.DEFPRICING.GetValueOrDefault();
                    sopDetailInsert.DEFEXTPRICE = item.DEFEXTPRICE.GetValueOrDefault();
                    sopDetailInsert.CURNCYID = item.CURNCYID;
                    sopDetailInsert.UOFM = item.UOFM;
                    sopDetailInsert.IncludePromo = item.IncludePromo.GetValueOrDefault();
                    sopDetailInsert.CKCreditLimit = item.CKCreditLimit.GetValueOrDefault();
                    sopDetailInsert.QtyShrtOpt = item.QtyShrtOpt.GetValueOrDefault();
                    sopDetailInsert.Print_Phone_NumberGB = 0;
                    sopDetailInsert.Print_Phone_NumberGBSpecified = true;// item.Print_Phone_NumberGB.GetValueOrDefault();

                    SopLine.Add(sopDetailInsert);

                }


                return SopLine.ToArray();



            }
            catch (Exception)
            {

                throw;
            }
        }

        private taSopDistribution_ItemsTaSopDistribution[] SetDistributionValues(List<SOPDistribution> distribution, string InvoiceNumber)
        {
            try
            {
                var sopDistrib = new List<taSopDistribution_ItemsTaSopDistribution>();
                foreach(SOPDistribution item in distribution)
                {
                    var sopDistribInsert = new taSopDistribution_ItemsTaSopDistribution();

                    sopDistribInsert.SOPTYPE = item.SOPTYPE;
                    sopDistribInsert.SOPNUMBE = InvoiceNumber;
                    sopDistribInsert.SEQNUMBR = item.SEQNUMBR.GetValueOrDefault();
                    sopDistribInsert.DISTTYPE = item.DISTTYPE;
                    sopDistribInsert.DistRef = item.DistRef;
                    sopDistribInsert.ACTINDX = item.ACTINDX.GetValueOrDefault();
                    sopDistribInsert.ACTNUMST = item.ACTNUMST;
                    sopDistribInsert.DEBITAMT = item.DEBITAMT.GetValueOrDefault();
                    sopDistribInsert.CRDTAMNT = item.CRDTAMNT.GetValueOrDefault();
                    sopDistribInsert.CUSTNMBR = item.CUSTNMBR;
                    sopDistribInsert.RequesterTrx = item.RequesterTrx.GetValueOrDefault();

                    sopDistrib.Add(sopDistribInsert);
                }

                return sopDistrib.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert[] SetTaxValues(List<SOPTax> taxes, string InvoiceNumber)
        {
            try
            {
                var sopTaxes = new List<taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert>();

                foreach(SOPTax item in taxes)
                {
                    var sopTaxinsert = new taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert();

                    sopTaxinsert.SOPTYPE = item.SOPTYPE;
                    sopTaxinsert.TAXTYPE = item.TAXTYPE;
                    sopTaxinsert.SOPNUMBE = InvoiceNumber;
                    sopTaxinsert.CUSTNMBR = item.CUSTNMBR;
                    sopTaxinsert.LNITMSEQ = item.LNITMSEQ.GetValueOrDefault();
                    sopTaxinsert.SALESAMT = item.SALESAMT.GetValueOrDefault();
                    sopTaxinsert.FRTTXAMT = item.FRTTXAMT.GetValueOrDefault();
                    sopTaxinsert.MSCTXAMT = item.MSCTXAMT.GetValueOrDefault();
                    sopTaxinsert.FREIGHT = item.FREIGHT.GetValueOrDefault();
                    sopTaxinsert.MISCAMNT = item.MISCAMNT.GetValueOrDefault();
                    sopTaxinsert.TAXDTLID = item.TAXDTLID;
                    sopTaxinsert.ACTINDX = item.ACTINDX;
                    sopTaxinsert.ACTNUMST = item.ACTNUMST;
                    sopTaxinsert.STAXAMNT = item.STAXAMNT.GetValueOrDefault();
                    sopTaxinsert.TDTTXSLS = item.TDTTXSLS.GetValueOrDefault();
                    sopTaxinsert.TXDTOTTX = item.TXDTOTTX.GetValueOrDefault();
                    sopTaxinsert.RequesterTrx = item.RequesterTrx.GetValueOrDefault();

                    sopTaxes.Add(sopTaxinsert);
                    

                }
                return sopTaxes.ToArray();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private taSopCommissions_ItemsTaSopCommissions[] SetCommissionValues(List<SOPCommissions> commissions, string InvoiceNumber)
        {
            try
            {
                var sopCommission = new List<taSopCommissions_ItemsTaSopCommissions>();

                foreach(SOPCommissions item in commissions)
                {
                    var sopCommissionInsert = new taSopCommissions_ItemsTaSopCommissions();

                    sopCommissionInsert.SOPTYPE = item.SOPTYPE;
                    sopCommissionInsert.SOPNUMBE = item.SOPNUMBE;
                    sopCommissionInsert.LNITMSEQ = item.LNITMSEQ.GetValueOrDefault();
                    sopCommissionInsert.SLPRSNID = item.SLPRSNID;
                    sopCommissionInsert.SALSTERR = item.SALSTERR;
                    sopCommissionInsert.COMPRCNT = item.COMPRCNT.GetValueOrDefault();
                    sopCommissionInsert.COMMAMNT = item.COMMAMNT.GetValueOrDefault();
                    sopCommissionInsert.PRCTOSAL = item.PRCTOSAL.GetValueOrDefault();
                    sopCommissionInsert.CUSTNMBR = item.CUSTNMBR;
                    sopCommissionInsert.CURNCYID = item.CURNCYID;
                    sopCommissionInsert.RequesterTrx = item.RequesterTrx.GetValueOrDefault();


                    sopCommission.Add(sopCommissionInsert);
                        

                }

                return sopCommission.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private string SerializeSOPTransaction(SOPTransactionType soptran)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                SOPTransactionType[] tranType = { soptran };
                eConnect.SOPTransactionType = tranType;

                MemoryStream ms = new MemoryStream();

                XmlSerializer serializer = new XmlSerializer(eConnect.GetType());
                serializer.Serialize(ms, eConnect);
                ms.Position = 0;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(ms);

                string TransactionXML = xmldoc.OuterXml;

                return TransactionXML;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
