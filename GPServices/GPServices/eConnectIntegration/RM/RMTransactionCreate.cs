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
    public class RMTransactionCreate
    {

        #region "RM Documents"
        /// <summary>
        /// Create RM transaction
        /// <param name="transaction">Header of RM transaction</param>
        /// <param name="Distribution">Distribution Account of RM Transaction</param>
        /// <param name="Taxes">Taxes of RM transaction</param>
        /// <param name="company">COMPANY SHORT NAME</param>
        /// <returns>Response Class</returns>
        /// </summary>
        // Log4NetMR.classClsRegistrarLog logW = new Log4NetMR.classClsRegistrarLog();
        public Response TransactionCreate(RMTransactionHeader transaction, RMTransactionDist[] Distribution, RMDocumentTaxes[] Taxes, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            RMTransactionType rmTranType = new RMTransactionType();

            var getnext = new GetNextDocNumbers();
            getnext.RequireServiceProxy = false;

            try
            {

                string DOCNUMBR = string.Empty;

                if (string.IsNullOrEmpty(transaction.DOCNUMBR))
                {
                    DOCNUMBR = getnext.GetNextRMNumber(IncrementDecrement.Increment, RMPaymentType.RMCreditMemo, CNX);
                }
                else
                {
                    DOCNUMBR = transaction.DOCNUMBR;
                }

                rmTranType.taRMTransaction = SetTransactionValues(transaction, DOCNUMBR);

                if (transaction.CREATEDIST == 0)
                {
                    rmTranType.taRMDistribution_Items = SetDistributionValues(Distribution, DOCNUMBR);
                }
                if (transaction.CreateTaxes == 1)
                {
                    rmTranType.taRMTransactionTaxInsert_Items = SetTaxValues(Taxes, DOCNUMBR);
                }

                transactionXML = SerializeRMTransaction(rmTranType);

                response = eConnect.CreateGPTransaction(CNX, transactionXML);
                return response;
            }
            catch (Exception ex)
            {
                //logW.LogExeption("Econnect", 2, ex);
                response = new Response();
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace;
                return response;
            }
            finally
            {
                getnext.Dispose();
            }

        }

        /// <summary>
        /// Set Header Values
        /// <param name="transaction"></param>
        /// <param name="DOCNUMBR"></param>
        /// </summary>
        private taRMTransaction SetTransactionValues(RMTransactionHeader transaction, string DOCNUMBR)
        {
            try
            {
                var rmTransaction = new taRMTransaction
                {
                    RMDTYPAL = transaction.RMDTYPAL,
                    DOCNUMBR = transaction.DOCNUMBR,
                    //DOCDATE = transaction.DOCDATE.ToString("dd/MM/yyyy"),
                    DOCDATE = transaction.DOCDATE.ToString("yyyy-MM-dd"),
                    BACHNUMB = transaction.BACHNUMB,
                    CUSTNMBR = transaction.CUSTNMBR,
                    DOCAMNT = transaction.DOCAMNT,
                    SLSAMNT = transaction.SLSAMNT,
                    DOCDESCR = transaction.DOCDESCR,
                    ADRSCODE = transaction.ADRSCODE,
                    SLPRSNID = transaction.SLPRSNID,
                    SALSTERR = transaction.SALSTERR,
                    SHIPMTHD = transaction.SHIPMTHD,
                    TAXSCHID = transaction.TAXSCHID,
                    CSTPONBR = transaction.CSTPONBR,
                    COSTAMNT = transaction.COSTAMNT.GetValueOrDefault(),
                    TRDISAMT = transaction.TRDISAMT.GetValueOrDefault(),
                    TRDDISCT = transaction.TRDDISCT.GetValueOrDefault(),
                    FRTAMNT = transaction.FRTAMNT.GetValueOrDefault(),
                    MISCAMNT = transaction.MISCAMNT.GetValueOrDefault(),
                    TAXAMNT = transaction.TAXAMNT.GetValueOrDefault(),
                    BKTSLSAM = transaction.BKTSLSAM.GetValueOrDefault(),
                    BKTFRTAM = transaction.BKTFRTAM.GetValueOrDefault(),
                    BKTMSCAM = transaction.BKTMSCAM.GetValueOrDefault(),
                    CASHAMNT = transaction.CASHAMNT.GetValueOrDefault(),
                    CBKIDCSH = transaction.CBKIDCSH,
                    //CASHDATE = transaction.CASHDATE.ToShortDateString(),
                    DCNUMCSH = transaction.DCNUMCSH,
                    CHEKAMNT = transaction.CHEKAMNT.GetValueOrDefault(),
                    CBKIDCHK = transaction.CBKIDCHK,
                    CBKIDCRD = transaction.CBKIDCRD,
                    CHEKNMBR = transaction.CHEKNMBR,
                    //CHEKDATE = transaction.CHEKDATE.ToShortDateString(),
                    DCNUMCHK = transaction.DCNUMCHK,
                    CRCRDAMT = transaction.CRCRDAMT.GetValueOrDefault(),
                    CRCRDNAM = transaction.CRCRDNAM,
                    RCTNCCRD = transaction.RCTNCCRD,
                    //CRCARDDT = transaction.CRCARDDT.ToShortDateString(),
                    DCNUMCRD = transaction.DCNUMCRD,
                    DISCRTND = transaction.DISCRTND.GetValueOrDefault(),
                    DISTKNAM = transaction.DISTKNAM.GetValueOrDefault(),
                    WROFAMNT = transaction.WROFAMNT.GetValueOrDefault(),
                    PPSAMDED = transaction.PPSAMDED.GetValueOrDefault(),
                    GSTDSAMT = transaction.GSTDSAMT.GetValueOrDefault(),
                    PYMTRMID = transaction.PYMTRMID,
                    DISAVAMT = transaction.DISAVAMT.GetValueOrDefault(),
                    DSCDLRAM = transaction.DSCDLRAM.GetValueOrDefault(),
                    DSCPCTAM = transaction.DSCPCTAM.GetValueOrDefault(),
                    LSTUSRED = transaction.LSTUSRED,
                    PTDUSRID = transaction.PTDUSRID,
                    DistRef = transaction.DistRef,
                    BatchCHEKBKID = transaction.BatchCHEKBKID,
                    //DUEDATE = transaction.DUEDATE.ToShortDateString(),
                    //DISCDATE = transaction.DISCDATE.ToShortDateString(),
                    CURNCYID = transaction.CURNCYID,
                    XCHGRATE = transaction.XCHGRATE.GetValueOrDefault(),
                    RATETPID = transaction.RATETPID,
                    //EXPNDATE = transaction.EXPNDATE.ToShortDateString(),
                    //EXCHDATE = transaction.EXCHDATE.ToShortDateString(),
                    EXGTBDSC = transaction.EXGTBDSC,
                    EXTBLSRC = transaction.EXTBLSRC,
                    RATEEXPR = transaction.RATEEXPR.GetValueOrDefault(),
                    DYSTINCR = transaction.DYSTINCR.GetValueOrDefault(),
                    RATEVARC = transaction.RATEVARC.GetValueOrDefault(),
                    TRXDTDEF = transaction.TRXDTDEF.GetValueOrDefault(),
                    RTCLCMTD = transaction.RTCLCMTD.GetValueOrDefault(),
                    PRVDSLMT = transaction.PRVDSLMT.GetValueOrDefault(),
                    DATELMTS = transaction.DATELMTS.GetValueOrDefault(),
                    //TIME1 = transaction.TIME1.ToShortDateString(),
                    COMDLRAM = transaction.COMDLRAM.GetValueOrDefault(),
                    COMAPPTO = transaction.COMAPPTO.GetValueOrDefault(),
                    RequesterTrx = transaction.RequesterTrx.GetValueOrDefault(),
                    CREATEDIST = transaction.CREATEDIST.GetValueOrDefault(),
                };


                //if (transaction.DOCDATE != null)
                //{
                //    rmTransaction.DOCDATE = transaction.DOCDATE.ToShortDateString();
                //}

                if (transaction.CASHDATE != null)
                {
                    rmTransaction.CASHDATE = transaction.CASHDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.CHEKDATE != null)
                {
                    rmTransaction.CHEKDATE = transaction.CHEKDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.CRCARDDT != null)
                {
                    rmTransaction.CRCARDDT = transaction.CRCARDDT.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.DUEDATE != null)
                {
                    rmTransaction.DUEDATE = transaction.DUEDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.DISCDATE != null)
                {
                    rmTransaction.DISCDATE = transaction.DISCDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.EXPNDATE != null)
                {
                    rmTransaction.EXPNDATE = transaction.EXPNDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.EXCHDATE != null)
                {
                    rmTransaction.EXCHDATE = transaction.EXCHDATE.GetValueOrDefault().ToString("yyyy-MM-dd"); ;
                }

                if (transaction.TIME1 != null)
                {
                    rmTransaction.TIME1 = transaction.TIME1.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                return rmTransaction;
            }
            catch (Exception)
            {
                //logW.LogExeption("Econnect", 2, ex);
                throw;
            }
        }

        /// <summary>
        /// Set values for each tax class
        /// <param name="tax"></param>
        /// <param name="DOCNUMBR"></param>
        /// </summary>
        private taRMTransactionTaxInsert_ItemsTaRMTransactionTaxInsert[] SetTaxValues(RMDocumentTaxes[] tax, string DOCNUMBR)
        {
            int index = 0;
            try
            {
                taRMTransactionTaxInsert_ItemsTaRMTransactionTaxInsert[] TransactionTaxes = new taRMTransactionTaxInsert_ItemsTaRMTransactionTaxInsert[tax.Length];

                foreach (RMDocumentTaxes taxes in tax)
                {
                    var TransactionTax = new taRMTransactionTaxInsert_ItemsTaRMTransactionTaxInsert
                    {
                        CUSTNMBR = taxes.CUSTNMBR,
                        DOCNUMBR = taxes.DOCNUMBR,
                        RMDTYPAL = taxes.RMDTYPAL,
                        BACHNUMB = taxes.BACHNUMB,
                        TAXDTLID = taxes.TAXDTLID,
                        TAXAMNT = taxes.TAXAMNT,
                        STAXAMNT = taxes.STAXAMNT,
                        FRTTXAMT = taxes.FRTTXAMT.GetValueOrDefault(),
                        MSCTXAMT = taxes.MSCTXAMT.GetValueOrDefault(),
                        TAXDTSLS = taxes.TAXDTSLS,
                        SEQNUMBR = taxes.SEQNUMBR.GetValueOrDefault(),
                        ACTINDX = taxes.ACTINDX.GetValueOrDefault(),
                        ACTNUMST = taxes.ACTNUMST,
                        TDTTXSLS = taxes.TDTTXSLS,
                        RequesterTrx = taxes.RequesterTrx.GetValueOrDefault(),
                    };
                    TransactionTaxes[index] = TransactionTax;
                    index++;
                }
                return TransactionTaxes;
            }
            catch (Exception)
            {
                //logW.LogExeption("Econnect", 2, ex);
                throw;
            }
        }

        /// <summary>
        /// Set values for each Distribution class
        /// <param name="Dist"></param>
        /// <param name="DOCNUMBR"></param>
        /// </summary>
        private taRMDistribution_ItemsTaRMDistribution[] SetDistributionValues(RMTransactionDist[] Dist, string DOCNUMBR)
        {
            int index = 0;
            try
            {
                taRMDistribution_ItemsTaRMDistribution[] TransactionDist = new taRMDistribution_ItemsTaRMDistribution[Dist.Length];
                foreach (RMTransactionDist distribution in Dist)
                {
                    var TransactionDistribution = new taRMDistribution_ItemsTaRMDistribution
                    {
                        RMDTYPAL = distribution.RMDTYPAL,
                        DOCNUMBR = distribution.DOCNUMBR,
                        CUSTNMBR = distribution.CUSTNMBR,
                        SEQNUMBR = distribution.SEQNUMBR.GetValueOrDefault(),
                        DISTTYPE = distribution.DISTTYPE,
                        DistRef = distribution.DistRef,
                        DSTINDX = distribution.DSTINDX.GetValueOrDefault(),
                        ACTNUMST = distribution.ACTNUMST,
                        DEBITAMT = distribution.DEBITAMT.GetValueOrDefault(),
                        CRDTAMNT = distribution.CRDTAMNT.GetValueOrDefault(),
                    };
                    TransactionDist[index] = TransactionDistribution;
                    index++;
                }
                return TransactionDist;
            }
            catch (Exception)
            {
                //logW.LogExeption("Econnect", 2, ex);
                throw;
            }
        }

        /// <summary>
        /// Serialize Transaction
        /// <param name="transactionType"></param>
        /// </summary>
        private string SerializeRMTransaction(RMTransactionType transactionType)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                RMTransactionType[] TranType = { transactionType };
                eConnect.RMTransactionType = TranType;

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
                // logW.LogExeption("Econnect", 2, ex);
                throw;
            }
        }


        #endregion

        #region "CashReceipt"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentType"></param>
        /// <returns></returns>
        private string SerializeRMCashReceipts(RMCashReceiptsType paymentType)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                RMCashReceiptsType[] TranType = { paymentType };
                eConnect.RMCashReceiptsType = TranType;

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
                // logW.LogExeption("Econnect", 2, ex);
                throw;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Dist"></param>
        /// <param name="DOCNUMBR"></param>
        /// <returns></returns>
        private taRMDistribution_ItemsTaRMDistribution[] SetPaymentDistributionValues(RMTransactionDist[] Dist, string DOCNUMBR)
        {
            int index = 0;
            try
            {
                taRMDistribution_ItemsTaRMDistribution[] TransactionDist = new taRMDistribution_ItemsTaRMDistribution[Dist.Length];
                foreach (RMTransactionDist distribution in Dist)
                {
                    var TransactionDistribution = new taRMDistribution_ItemsTaRMDistribution
                    {
                        RMDTYPAL = distribution.RMDTYPAL,
                        DOCNUMBR = DOCNUMBR,
                        CUSTNMBR = distribution.CUSTNMBR,
                        SEQNUMBR = distribution.SEQNUMBR.GetValueOrDefault(),
                        DISTTYPE = distribution.DISTTYPE,
                        DistRef = distribution.DistRef,
                        DSTINDX = distribution.DSTINDX.GetValueOrDefault(),
                        ACTNUMST = distribution.ACTNUMST,
                        DEBITAMT = distribution.DEBITAMT.GetValueOrDefault(),
                        CRDTAMNT = distribution.CRDTAMNT.GetValueOrDefault(),
                    };
                    TransactionDist[index] = TransactionDistribution;
                    index++;
                }
                return TransactionDist;
            }
            catch (Exception)
            {
                //logW.LogExeption("Econnect", 2, ex);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cashreceipt"></param>
        /// <param name="Distribution"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response CashReceiptCreate(RMCashReceipt Cashreceipt, RMTransactionDist[] Distribution, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            RMCashReceiptsType rmcashreceipttype = new RMCashReceiptsType();

            var getnext = new GetNextDocNumbers();
            getnext.RequireServiceProxy = false;

            try
            {
                string DOCNUMBR = string.Empty;
                DOCNUMBR = getnext.GetNextRMNumber(IncrementDecrement.Increment, RMPaymentType.RMPayments, CNX);

                rmcashreceipttype.taRMCashReceiptInsert = SetReceiptValues(Cashreceipt, DOCNUMBR);

                if (Cashreceipt.CREATEDIST == 0)
                {
                    rmcashreceipttype.taRMDistribution_Items = SetPaymentDistributionValues(Distribution, DOCNUMBR);
                }

                transactionXML = SerializeRMCashReceipts(rmcashreceipttype);
                response = eConnect.CreateGPTransaction(CNX, transactionXML);
                response.DOCUMENT = DOCNUMBR.Trim();
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
            finally
            {
                getnext.Dispose();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cashreceipt"></param>
        /// <param name="DOCNUMBR"></param>
        /// <returns></returns>
        private taRMCashReceiptInsert SetReceiptValues(RMCashReceipt cashreceipt, string DOCNUMBR)
        {
            try
            {
                var rmcashreceipt = new taRMCashReceiptInsert
                {
                    CUSTNMBR = cashreceipt.CUSTNMBR,
                    DOCNUMBR = DOCNUMBR,
                    DOCDATE = cashreceipt.DOCDATE.ToString("yyyy-MM-dd"),
                    ORTRXAMT = cashreceipt.ORTRXAMT,
                    GLPOSTDT = cashreceipt.GLPOSTDT.ToString("yyyy-MM-dd"),
                    BACHNUMB = cashreceipt.BACHNUMB,
                    CSHRCTYP = cashreceipt.CSHRCTYP,
                    CHEKBKID = cashreceipt.CHEKBKID,
                    CHEKNMBR = cashreceipt.CHEKNMBR,
                    CRCARDID = cashreceipt.CRCARDID,
                    TRXDSCRN = cashreceipt.TRXDSCRN,
                    LSTUSRED = cashreceipt.LSTUSRED,
                    BatchCHEKBKID = cashreceipt.BatchCHEKBKID,
                    CURNCYID = cashreceipt.CURNCYID,
                    XCHGRATE = cashreceipt.XCHGRATE.GetValueOrDefault(),
                    RATETPID = cashreceipt.RATETPID,
                    //EXPNDATE = cashreceipt.EXPNDATE
                    //EXCHDATE = cashreceipt.EXCHDATE
                    EXGTBDSC = cashreceipt.EXGTBDSC,
                    EXTBLSRC = cashreceipt.EXTBLSRC,
                    RATEEXPR = cashreceipt.RATEEXPR.GetValueOrDefault(),
                    DYSTINCR = cashreceipt.DYSTINCR.GetValueOrDefault(),
                    RATEVARC = cashreceipt.RATEVARC.GetValueOrDefault(),
                    TRXDTDEF = cashreceipt.TRXDTDEF.GetValueOrDefault(),
                    RTCLCMTD = cashreceipt.RTCLCMTD.GetValueOrDefault(),
                    PRVDSLMT = cashreceipt.PRVDSLMT.GetValueOrDefault(),
                    DATELMTS = cashreceipt.DATELMTS.GetValueOrDefault(),
                    CREATEDIST = cashreceipt.CREATEDIST.GetValueOrDefault(),
                    RequesterTrx = cashreceipt.RequesterTrx.GetValueOrDefault()
                };



                if (cashreceipt.EXPNDATE != null)
                {
                    rmcashreceipt.EXPNDATE = cashreceipt.EXPNDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (cashreceipt.EXCHDATE != null)
                {
                    rmcashreceipt.EXCHDATE = cashreceipt.EXCHDATE.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                if (cashreceipt.TIME1 != null)
                {
                    rmcashreceipt.TIME1 = cashreceipt.TIME1.GetValueOrDefault().ToString("yyyy-MM-dd");
                }


                return rmcashreceipt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region "Apply and UnApply"

        public Response ApplyTransaction(RMApply applyTran, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            RMApplyType rmapplytype = new RMApplyType();
            try
            {
                rmapplytype.taRMApply = SetApplyValues(applyTran);
                transactionXML = SerializeRMApply(rmapplytype);
                response = eConnect.CreateGPTransaction(CNX, transactionXML);

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
        /// <param name="applytran"></param>
        /// <returns></returns>
        private taRMApply SetApplyValues(RMApply applytran)
        {
            try
            {
                var rmapplytransaction = new taRMApply
                {
                    APTODCNM = applytran.APTODCNM,
                    APFRDCNM = applytran.APFRDCNM,
                    APPTOAMT = applytran.APPTOAMT,
                    APFRDCTY = applytran.APFRDCTY,
                    APTODCTY = applytran.APTODCTY,
                    DISTKNAM = applytran.DISTKNAM.GetValueOrDefault(),
                    WROFAMNT = applytran.WROFAMNT.GetValueOrDefault(),
                    APPLYDATE = applytran.APPLYDATE.ToString("yyyy-MM-dd"),
                    GLPOSTDT = applytran.GLPOSTDT.ToString("yyyy-MM-dd")

                };
                return rmapplytransaction;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rmapply"></param>
        /// <returns></returns>
        private string SerializeRMApply(RMApplyType rmapply)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                RMApplyType[] TranType = { rmapply };
                eConnect.RMApplyType = TranType;

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
                // logW.LogExeption("Econnect", 2, ex);
                throw;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unapplytran"></param>
        /// <param name="company"></param>
        /// <returns></returns>
        public Response UnApplyTransaction(RMUnapply unapplytran, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            RMUnapplyTransactionType rmunapply = new RMUnapplyTransactionType();
            try
            {
                rmunapply.taRMUnapplyTransaction = SetUnapplyValues(unapplytran);
                transactionXML = SerializeRMUnaApply(rmunapply);
                response = eConnect.CreateGPTransaction(CNX, transactionXML);
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
        /// <param name="unapplytran"></param>
        /// <returns></returns>
        private taRMUnapplyTransaction SetUnapplyValues(RMUnapply unapplytran)
        {
            try
            {
                var rmunapplytransaction = new taRMUnapplyTransaction
                {
                    CUSTNMBR = unapplytran.CUSTNMBR,
                    DOCNUMBR = unapplytran.DOCNUMBR,
                    RMDTYPAL = unapplytran.RMDTYPAL,
                    APTODCTY = unapplytran.APTODCTY.GetValueOrDefault(),
                    APTODCNM = unapplytran.APTODCNM,
                };

                if (unapplytran.GLPOSTDT != null)
                {
                    rmunapplytransaction.GLPOSTDT = unapplytran.GLPOSTDT.GetValueOrDefault().ToString("yyyy-MM-dd");
                }

                return rmunapplytransaction;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rmunapply"></param>
        /// <returns></returns>
        private string SerializeRMUnaApply(RMUnapplyTransactionType rmunapply)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                RMUnapplyTransactionType[] TranType = { rmunapply };
                eConnect.RMUnapplyTransactionType = TranType;

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
                // logW.LogExeption("Econnect", 2, ex);
                throw;

            }
        }

        #endregion

        #region "Void Transaction"

        public Response VoidTransaction(RMVoidTransaction rmvoidtran, string company)
        {
            Response response;
            string server = ConfigKey.ReadSetting("SERVER");
            string transactionXML = string.Empty;
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=False;packet size=4096";
            var eConnect = new eConnectRequest();
            RMVoidTransactionType rmvoidtransaction = new RMVoidTransactionType();

            try
            {
                rmvoidtransaction.taRMVoidTransaction = SetVoidValues(rmvoidtran);
                transactionXML = SerializeRMVoid(rmvoidtransaction);
                response = eConnect.CreateGPTransaction(CNX, transactionXML);
                return response;
            }
            catch (Exception ex)
            {
                response = new Response();
                response.SUCCESS = false;
                response.MESSAGE = ex.Message;
                response.STACK = ex.StackTrace;
                return response;
                //throw;
            }

        }

        private taRMVoidTransaction SetVoidValues(RMVoidTransaction rmvoidtran)
        {

            try
            {
                var rmVoid = new taRMVoidTransaction
                {
                    CUSTNMBR = rmvoidtran.CUSTNMBR,
                    DOCNUMBR = rmvoidtran.DOCNUMBR,
                    VOIDSTTS = rmvoidtran.VOIDSTTS,
                    RMDTYPAL = rmvoidtran.RMDTYPAL,
                    VOIDDATE = rmvoidtran.VOIDDATE.ToString("yyyy-MM-dd"),
                    GLPOSTDT = rmvoidtran.GLPOSTDT.ToString("yyy-MM-dd")
                };

                return rmVoid;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private string SerializeRMVoid(RMVoidTransactionType rmvoid)
        {
            try
            {
                eConnectType eConnect = new eConnectType();
                RMVoidTransactionType[] TranType = { rmvoid };
                eConnect.RMVoidTransactionType = TranType;

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
                // logW.LogExeption("Econnect", 2, ex);
                throw;

            }
        }

        #endregion
    }
}
