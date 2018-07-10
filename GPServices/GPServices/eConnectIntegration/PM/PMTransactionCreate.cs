using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Dynamics.GP.eConnect;
using Microsoft.Dynamics.GP.eConnect.Serialization;
using PMClass;
using eConnectIntegration.CLASS;

namespace eConnectIntegration.PM
{
    /// <summary>
    /// 
    /// </summary>
    public class PMTransactionCreate
    {
        /// <summary>
        /// Create PM transaction
        /// </summary>
        /// <param name="transaction">Header of PM transaction</param>
        /// <param name="Distribution">Distribution Account of PM Transaction</param>
        /// <param name="Taxes">Taxes of PM transaction</param>
        /// <param name="company">COMPANY SHORT NAME</param>
        /// <returns>Response Class</returns>
        public Response TransactionCreate(PMTransactionHeader transaction, PMTransactionDist[] Distribution, PMTransactionTax[] Taxes, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            //var server = Properties.Settings.Default.SERVER.ToString();
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            PMTransactionType pmTranType = new PMTransactionType();

            var getnext = new GetNextDocNumbers();
            getnext.RequireServiceProxy = false;

            try
            {
                string VCHRNUMBER = getnext.GetPMNextVoucherNumber(IncrementDecrement.Increment, CNX);
                pmTranType.taPMTransactionInsert = SetTransactionValues(transaction, VCHRNUMBER);

                if (transaction.CREATEDIST == 0)
                {
                    pmTranType.taPMDistribution_Items = SetDistributionValues(Distribution, VCHRNUMBER);
                }
                if (transaction.CreateTaxes == 1)
                {
                    pmTranType.taPMTransactionTaxInsert_Items = SetTaxValues(Taxes, VCHRNUMBER);
                }

                transactionXML = SerializePMTransaction(pmTranType);

                response = eConnect.CreateGPTransaction(CNX, transactionXML);
                return response;
            }
            catch (Exception ex)
            {
                response = new Response();
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace; //+ " Inner Exception: " + ex.InnerException.Message;
                return response;
            }
            finally
            {
                getnext.Dispose();

            }
        }

        /// <summary>
        /// Set Header Values
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="VCHRNUMBER"></param>
        /// <returns></returns>
        private taPMTransactionInsert SetTransactionValues(PMTransactionHeader transaction, string VCHRNUMBER)
        {


            try
            {
                var pmTransactionInsert = new taPMTransactionInsert
                {
                    BACHNUMB = transaction.BACHNUMB,
                    VCHNUMWK = VCHRNUMBER,
                    VENDORID = transaction.VENDORID,
                    DOCNUMBR = transaction.DOCNUMBR,
                    DOCTYPE = transaction.DOCTYPE,
                    DOCDATE = transaction.DOCDATE.ToString("yyyy-MM-dd"),
                    VADCDTRO = transaction.VADCDTRO,
                    VADDCDPR = transaction.VADDCDPR,
                    PYMTRMID = transaction.PYMTRMID,
                    TAXSCHID = transaction.TAXSCHID,
                    DUEDATE = transaction.DUEDATE.ToString("yyyy-MM-dd"),
                    DSCDLRAM = transaction.DSCDLRAM.GetValueOrDefault(),
                    PRCHAMNT = transaction.PRCHAMNT,
                    CASHAMNT = transaction.CASHAMNT.GetValueOrDefault(),
                    CAMCBKID = transaction.CAMCBKID,
                    CDOCNMBR = transaction.CDOCNMBR,
                    CAMPMTNM = transaction.CAMPMTNM,
                    CHEKAMNT = transaction.CHEKAMNT.GetValueOrDefault(),
                    CHAMCBID = transaction.CHAMCBID,
                    CAMPYNBR = transaction.CAMPYNBR,
                    CRCRDAMT = transaction.CRCRDAMT.GetValueOrDefault(),
                    CCAMPYNM = transaction.CCAMPYNM,
                    CHEKNMBR = transaction.CHEKNMBR,
                    CARDNAME = transaction.CARDNAME,
                    CCRCTNUM = transaction.CCRCTNUM,
                    CHEKBKID = transaction.CHEKBKID,
                    TRXDSCRN = transaction.TRXDSCRN,
                    TRDISAMT = transaction.TRDISAMT.GetValueOrDefault(),
                    TAXAMNT = transaction.TAXAMNT.GetValueOrDefault(),
                    FRTAMNT = transaction.FRTAMNT.GetValueOrDefault(),
                    TEN99AMNT = transaction.TEN99AMNT.GetValueOrDefault(),
                    MSCCHAMT = transaction.MSCCHAMT.GetValueOrDefault(),
                    PORDNMBR = transaction.PORDNMBR,
                    SHIPMTHD = transaction.SHIPMTHD,
                    DISAMTAV = transaction.DISAMTAV.GetValueOrDefault(),
                    DISTKNAM = transaction.DISTKNAM.GetValueOrDefault(),
                    APDSTKAM = transaction.APDSTKAM.GetValueOrDefault(),
                    MDFUSRID = transaction.MDFUSRID,
                    PTDUSRID = transaction.PTDURID,
                    PCHSCHID = transaction.PCHSCHID,
                    FRTSCHID = transaction.FRTSCHID,
                    MSCSCHID = transaction.MSCSCHID,
                    PRCTDISC = transaction.PRCTDISC.GetValueOrDefault(),
                    CURNCYID = transaction.CURNCYID,
                    XCHGRATE = transaction.XCHGRATE.GetValueOrDefault(),
                    RATETPID = transaction.RATEPID,
                    EXGTBDSC = transaction.EXGTBDSC,
                    EXTBLSRC = transaction.EXTBLSRC,
                    RATEEXPR = transaction.RATEEXPR.GetValueOrDefault(),
                    DYSTINCR = transaction.DYSTINCR.GetValueOrDefault(),
                    RATEVARC = transaction.RATEVARC.GetValueOrDefault(),
                    TRXDTDEF = transaction.TRXDTDEF.GetValueOrDefault(),
                    RTCLCMTD = transaction.RTCLCMTD.GetValueOrDefault(),
                    PRVDSLMT = transaction.PRVDSLMT.GetValueOrDefault(),
                    DATELMTS = transaction.DATELMTS.GetValueOrDefault(),
                    BatchCHEKBKID = transaction.BatchCHEKBKID,
                    CREATEDIST = transaction.CREATEDIST.GetValueOrDefault(),
                    RequesterTrx = transaction.RequesterTrx.GetValueOrDefault()
                };

                pmTransactionInsert.DOCAMNT = pmTransactionInsert.MSCCHAMT + 
                                              pmTransactionInsert.PRCHAMNT + 
                                              pmTransactionInsert.TAXAMNT + 
                                              pmTransactionInsert.FRTAMNT + 
                                              pmTransactionInsert.TRDISAMT;

                pmTransactionInsert.CHRGAMNT = pmTransactionInsert.DOCAMNT -
                                               pmTransactionInsert.CASHAMNT -
                                               pmTransactionInsert.CHEKAMNT -
                                               pmTransactionInsert.CRCRDAMT -
                                               pmTransactionInsert.DISTKNAM;

                if (transaction.PSTGDATE != null)
                {
                    pmTransactionInsert.PSTGDATE = transaction.PSTGDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); 
                }

                if (transaction.DISCDATE != null)
                {
                    pmTransactionInsert.DISCDATE = transaction.DISCDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); 
                }

                if (transaction.CAMTDATE != null)
                {
                    pmTransactionInsert.CAMTDATE = transaction.CAMTDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); 
                }

                if (transaction.CRCARDDT != null)
                {
                    pmTransactionInsert.CRCARDDT = transaction.CRCARDDT.GetValueOrDefault().ToString("yyyy-MM-dd"); 
                }

                if (transaction.CHEKDATE != null)
                {
                    pmTransactionInsert.CHEKDATE = transaction.CHEKDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (transaction.POSTEDDT != null)
                {
                    pmTransactionInsert.POSTEDDT = transaction.POSTEDDT.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (transaction.Tax_Date != null)
                {
                    pmTransactionInsert.Tax_Date = transaction.Tax_Date.GetValueOrDefault().ToString("yyyy-MM-dd");
                }


                if (transaction.EXPNDATE != null)
                {
                    pmTransactionInsert.EXPNDATE = transaction.EXPNDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (transaction.EXCHDATE != null)
                {
                    pmTransactionInsert.EXCHDATE = transaction.EXCHDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }
                

                return pmTransactionInsert;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Set values for each tax class
        /// </summary>
        /// <param name="tax"></param>
        /// <param name="VCHRNUMBER"></param>
        /// <returns></returns>
        private taPMTransactionTaxInsert_ItemsTaPMTransactionTaxInsert[] SetTaxValues(PMTransactionTax[] tax, string VCHRNUMBER)
        {
            int index = 0;
            try
            {
                taPMTransactionTaxInsert_ItemsTaPMTransactionTaxInsert[] TransactionTaxes = new taPMTransactionTaxInsert_ItemsTaPMTransactionTaxInsert[tax.Length];


                foreach (PMTransactionTax taxes in tax)
                {
                    var TransactionTax = new taPMTransactionTaxInsert_ItemsTaPMTransactionTaxInsert
                    {
                        VENDORID = taxes.VENDORID,
                        VCHRNMBR = VCHRNUMBER,
                        DOCTYPE = taxes.DOCTYPE,
                        BACHNUMB = taxes.BACHNUMB,
                        TAXDTLID = taxes.TAXDTLID,
                        TAXAMNT = taxes.TAXAMNT,
                        PCTAXAMT = taxes.PCTAXAMT,
                        FRTTXAMT = taxes.FRTTXAMT,
                        MSCTXAMT = taxes.MSCTXAMT,
                        TDTTXPUR = taxes.TDTTXPUR,
                        ACTINDX = taxes.ACTINDX,
                        ACTNUMST = taxes.ACTNUMST,
                        RequesterTrx = taxes.RequesterTrx.GetValueOrDefault()

                    };
                    TransactionTaxes[index] = TransactionTax;
                    index++;
                }


                return TransactionTaxes;

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Set values for each Distribution class
        /// </summary>
        /// <param name="Dist"></param>
        /// <param name="VCHRNUMBER"></param>
        /// <returns></returns>
        private taPMDistribution_ItemsTaPMDistribution[] SetDistributionValues(PMTransactionDist[] Dist, string VCHRNUMBER)
        {
            int index = 0;
            try
            {
                taPMDistribution_ItemsTaPMDistribution[] TransactionDist = new taPMDistribution_ItemsTaPMDistribution[Dist.Length];
                foreach (PMTransactionDist distribution in Dist)
                {
                    var TransactionDistribution = new taPMDistribution_ItemsTaPMDistribution
                    {
                        DOCTYPE = distribution.DOCTYPE,
                        VCHRNMBR = VCHRNUMBER,
                        VENDORID = distribution.VENDORID,
                        DSTSQNUM = distribution.DSTSQNUM,
                        DISTTYPE = distribution.DISTTYPE,
                        DistRef = distribution.DistRef,
                        ACTINDX = distribution.ACTINDX,
                        ACTNUMST = distribution.ACTNUMST,
                        DEBITAMT = distribution.DEBITAMT,
                        CRDTAMNT = distribution.CRDTAMNT,
                        RequesterTrx = distribution.RequesterTrx.GetValueOrDefault()
                    };
                    TransactionDist[index] = TransactionDistribution;
                    index++;
                }

                return TransactionDist;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Serialize Transaction
        /// </summary>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        private string SerializePMTransaction(PMTransactionType transactionType)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                PMTransactionType[] TranType = { transactionType };
                eConnect.PMTransactionType = TranType;

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
