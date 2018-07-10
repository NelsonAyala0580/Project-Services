using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Dynamics.GP.eConnect;
using Microsoft.Dynamics.GP.eConnect.Serialization;
using GLClass;
using eConnectIntegration.CLASS;

namespace eConnectIntegration.GL
{
    public class GLTransactionCreate
    {
        public Response TransactionCreate(GLTrasactionHeader Header, GLTransactionDetail[] Detail, string company)
        {
            Response response;
            string transactionXML = string.Empty;
            //var server = Properties.Settings.Default.SERVER.ToString();
            string server = ConfigKey.ReadSetting("SERVER");
            string CNX = "data source=" + server + ";initial catalog=" + company + ";integrated security=SSPI;persist security info=True;packet size=4096";

            //string CNX = "data source=stsv-qa15;initial catalog=ELSIN;integrated security=SSPI;persist security info=True;packet size=4096";
            var eConnect = new eConnectRequest();
            GLTransactionType GLTranType = new GLTransactionType();
            var getnext = new GetNextDocNumbers();
            //getnext.RequireServiceProxy = false;
            try
            {
                int jrnEntry = Convert.ToInt32(getnext.GetNextGLJournalEntryNumber(IncrementDecrement.Increment, CNX));

                GLTranType.taGLTransactionHeaderInsert = SetTransactionValues(Header, jrnEntry);
                GLTranType.taGLTransactionLineInsert_Items = SetDetailValues(Detail, jrnEntry);
                transactionXML = SerializeGLTransacion(GLTranType);

                response = eConnect.CreateGPTransaction(CNX, transactionXML);

                return response;
            }
            catch (eConnectException ex)
            {
                response = new Response();
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
                response = new Response();
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
                //getnext.Dispose();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Header"></param>
        /// <param name="jrnEntry"></param>
        /// <returns></returns>
        private taGLTransactionHeaderInsert SetTransactionValues(GLTrasactionHeader Header, int jrnEntry)
        {
            try
            {
                var glTrasactionInsert = new taGLTransactionHeaderInsert
                {
                    BACHNUMB = Header.BACHNUMB,
                    JRNENTRY = jrnEntry,
                    REFRENCE = Header.REFRENCE,
                    TRXDATE = Header.TRXDATE.ToString("yyyy-MM-dd"),
                    TRXTYPE = Header.TRXTYPE,
                    SQNCLINE = Header.SQNCLINE.GetValueOrDefault(),
                    SERIES = Header.SERIES.GetValueOrDefault(),
                    CURNCYID = Header.CURNCYID,
                    XCHGRATE = Header.XCHGRATE.GetValueOrDefault(),
                    RATETPID = Header.RATETPID,
                    EXGTBDSC = Header.EXGTBDSC,
                    EXTBLSRC = Header.EXTBLSRC,
                    RATEEXPR = Header.RATEEXPR.GetValueOrDefault(),
                    RATEVARC = Header.RATEVARC.GetValueOrDefault(),
                    TRXDTDEF = Header.TRXDTDEF.GetValueOrDefault(),
                    PRVDSLMT = Header.PRVDSLMT.GetValueOrDefault(),
                    DATELMTS = Header.DATELMTS.GetValueOrDefault(),
                    RequesterTrx = Header.RequesterTrx.GetValueOrDefault(),
                    SOURCDOC = Header.SOURCDOC,
                    Ledger_ID = Header.Ledger_ID.GetValueOrDefault(),
                    USERID = Header.USERID,
                    Adjustment_Transaction = Header.Adjustment_Transaction.GetValueOrDefault(),
                    NOTETEXT = Header.NOTETEXT

                };

                if (Header.EXPNDATE != null)
                {
                    glTrasactionInsert.EXPNDATE = Header.EXPNDATE.GetValueOrDefault().ToShortDateString();
                }

                if (Header.EXCHDATE != null)
                {
                    glTrasactionInsert.EXCHDATE = Header.EXCHDATE.GetValueOrDefault().ToShortDateString();
                }

                return glTrasactionInsert;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Detail"></param>
        /// <param name="jrnEntry"></param>
        /// <returns></returns>
        private taGLTransactionLineInsert_ItemsTaGLTransactionLineInsert[] SetDetailValues(GLTransactionDetail[] Detail, int jrnEntry)
        {
            int index = 0;
            try
            {
                var tranDetails = new taGLTransactionLineInsert_ItemsTaGLTransactionLineInsert[Detail.Length];
                foreach (GLTransactionDetail item in Detail)
                {
                    var tranDetail = new taGLTransactionLineInsert_ItemsTaGLTransactionLineInsert
                    {
                        BACHNUMB = item.BACHNUMB,
                        JRNENTRY = jrnEntry,
                        SQNCLINE = item.SQNCLINE.GetValueOrDefault(),
                        ACTINDX = item.ACTINDX,
                        CRDTAMNT = item.CRDTAMNT,
                        DEBITAMT = item.DEBITAMT,
                        ACTNUMST = item.ACTNUMST,
                        DSCRIPTN = item.DSCRIPTN,
                        ORCTRNUM = item.ORCTRNUM,
                        ORDOCNUM = item.ORDOCNUM,
                        ORMSTRID = item.ORMSTRID,
                        ORMSTRNM = item.ORMSTRNM,
                        ORTRXTYP = item.ORTRXTYP.GetValueOrDefault(),
                        OrigSeqNum = item.OrigSeqNum.GetValueOrDefault(),
                        ORTRXDESC = item.ORTRXDESC,
                        TAXDTLID = item.TAXDTLID,
                        TAXAMNT = item.TAXAMNT.GetValueOrDefault(),
                        TAXACTNUMST = item.TAXACTNUMST,
                        DOCDATE = item.DOCDATE.ToString("yyyy-MM-dd"),
                        CURNCYID = item.CURNCYID,
                        XCHGRATE = item.XCHGRATE.GetValueOrDefault(),
                        RATETPID = item.RATETPID,
                        EXGTBDSC = item.EXGTBDSC,
                        EXTBLSRC = item.EXTBLSRC,
                        RATEEXPR = item.RATEEXPR.GetValueOrDefault(),
                        DYSTINCR = item.DYSTINCR.GetValueOrDefault(),
                        RATEVARC = item.RATEVARC.GetValueOrDefault(),
                        TRXDTDEF = item.TRXDTDEF.GetValueOrDefault(),
                        PRVDSLMT = item.PRVDSLMT.GetValueOrDefault(),
                        DATELMTS = item.DATELMTS.GetValueOrDefault(),
                        RequesterTrx = item.RequesterTrx.GetValueOrDefault()

                    };
                    if (item.EXPNDATE != null)
                    {
                        tranDetail.EXPNDATE = item.EXPNDATE.Value.ToString("yyyy-MM-dd");
                    }

                    if (item.EXCHDATE != null)
                    {
                        tranDetail.EXCHDATE = item.EXCHDATE.Value.ToString("yyyy-MM-dd");
                    }


                    tranDetails[index] = tranDetail;
                    index++;
                }
                return tranDetails;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TransactionType"></param>
        /// <returns></returns>
        private string SerializeGLTransacion(GLTransactionType TransactionType)
        {
            try
            {
                eConnectType eConnect = new eConnectType();

                GLTransactionType[] tranType = { TransactionType };
                eConnect.GLTransactionType = tranType;
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
