using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace GLClass
{
    [DataContract]
    public class GLTransactionDetail
    {
        private string _BACHNUMB;
        private int _JRNENTRY;
        private decimal? _SQNCLINE;
        private int _ACTINDX;
        private decimal _CRDTAMNT;
        private decimal _DEBITAMT;
        private string _ACTNUMST;
        private string _DSCRIPTN;
        private string _ORCTRNUM;
        private string _ORDOCNUM;
        private string _ORMSTRID;
        private string _ORMSTRNM;
        private short? _ORTRXTYP;
        private int? _OrigSeqNum;
        private string _ORTRXDESC;
        private string _TAXDTLID;
        private decimal? _TAXAMNT;
        private string _TAXACTNUMST;
        private DateTime _DOCDATE;
        private string _CURNCYID;
        private decimal? _XCHGRATE;
        private string _RATETPID;
        private DateTime? _EXPNDATE;
        private DateTime? _EXCHDATE;
        private string _EXGTBDSC;
        private string _EXTBLSRC;
        private short? _RATEEXPR;
        private short? _DYSTINCR;
        private decimal? _RATEVARC;
        private short? _TRXDTDEF;
        private short? _PRVDSLMT;
        private short? _DATELMTS;
        private short? _RequesterTrx;
        /// <summary>
        /// Batch number
        /// </summary>
        [DataMember]
        public string BACHNUMB
        {
            get { return _BACHNUMB; }
            set { _BACHNUMB = value; }
        }

        /// <summary>
        /// Journal entry number
        /// </summary>
        [DataMember]
        public int JRNENTRY
        {
            get { return _JRNENTRY; }
            set { _JRNENTRY = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? SQNCLINE
        {
            get { return _SQNCLINE; }
            set { _SQNCLINE = value; }
        }

        /// <summary>
        /// Account index
        /// </summary>
        [DataMember]
        public int ACTINDX
        {
            get { return _ACTINDX; }
            set { _ACTINDX = value; }
        }

        /// <summary>
        /// Credit amount
        /// </summary>
        [DataMember]
        public decimal CRDTAMNT
        {
            get { return _CRDTAMNT; }
            set { _CRDTAMNT = value; }
        }

        /// <summary>
        /// Debit amount
        /// </summary>
        [DataMember]
        public decimal DEBITAMT
        {
            get { return _DEBITAMT; }
            set { _DEBITAMT = value; }
        }

        /// <summary>
        /// Account string
        /// </summary>
        [DataMember]
        public string ACTNUMST
        {
            get { return _ACTNUMST; }
            set { _ACTNUMST = value; }
        }

        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        public string DSCRIPTN
        {
            get { return _DSCRIPTN; }
            set { _DSCRIPTN = value; }
        }

        /// <summary>
        /// Originating control number
        /// </summary>
        [DataMember]
        public string ORCTRNUM
        {
            get { return _ORCTRNUM; }
            set { _ORCTRNUM = value; }
        }

        /// <summary>
        /// Originating document number
        /// </summary>
        [DataMember]
        public string ORDOCNUM
        {
            get { return _ORDOCNUM; }
            set { _ORDOCNUM = value; }
        }

        /// <summary>
        /// Originating master ID
        /// </summary>
        [DataMember]
        public string ORMSTRID
        {
            get { return _ORMSTRID; }
            set { _ORMSTRID = value; }
        }

        /// <summary>
        /// Originating master name
        /// </summary>
        [DataMember]
        public string ORMSTRNM
        {
            get { return _ORMSTRNM; }
            set { _ORMSTRNM = value; }
        }

        /// <summary>
        /// Originating transaction type
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? ORTRXTYP
        {
            get { return _ORTRXTYP; }
            set { _ORTRXTYP = value; }
        }

        /// <summary>
        /// Originating sequence number
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? OrigSeqNum
        {
            get { return _OrigSeqNum; }
            set { _OrigSeqNum = value; }
        }

        /// <summary>
        /// Originating transaction description
        /// </summary>
        [DataMember]
        public string ORTRXDESC
        {
            get { return _ORTRXDESC; }
            set { _ORTRXDESC = value; }
        }

        /// <summary>
        /// Tax detail ID
        /// </summary>
        [DataMember]
        public string TAXDTLID
        {
            get { return _TAXDTLID; }
            set { _TAXDTLID = value; }
        }

        /// <summary>
        /// Tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TAXAMNT
        {
            get { return _TAXAMNT; }
            set { _TAXAMNT = value; }
        }

        /// <summary>
        /// Tax account string
        /// </summary>
        [DataMember]
        public string TAXACTNUMST
        {
            get { return _TAXACTNUMST; }
            set { _TAXACTNUMST = value; }
        }

        /// <summary>
        /// Document date
        /// </summary>
        [DataMember]
        public DateTime DOCDATE
        {
            get { return _DOCDATE; }
            set { _DOCDATE = value; }
        }

        /// <summary>
        /// Currency ID
        /// </summary>
        [DataMember]
        public string CURNCYID
        {
            get { return _CURNCYID; }
            set { _CURNCYID = value; }
        }

        /// <summary>
        /// Exchange rate
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? XCHGRATE
        {
            get { return _XCHGRATE; }
            set { _XCHGRATE = value; }
        }

        /// <summary>
        /// Rate type ID
        /// </summary>
        [DataMember]
        public string RATETPID
        {
            get { return _RATETPID; }
            set { _RATETPID = value; }
        }

        /// <summary>
        /// Expiration date
        /// </summary>
        [DataMember]
        public DateTime? EXPNDATE
        {
            get { return _EXPNDATE; }
            set { _EXPNDATE = value; }
        }

        /// <summary>
        /// Exchange date
        /// </summary>
        [DataMember]
        public DateTime? EXCHDATE
        {
            get { return _EXCHDATE; }
            set { _EXCHDATE = value; }
        }

        /// <summary>
        /// Exchange ID description
        /// </summary>
        [DataMember]
        public string EXGTBDSC
        {
            get { return _EXGTBDSC; }
            set { _EXGTBDSC = value; }
        }

        /// <summary>
        /// Exchange rate source
        /// </summary>
        [DataMember]
        public string EXTBLSRC
        {
            get { return _EXTBLSRC; }
            set { _EXTBLSRC = value; }
        }

        /// <summary>
        /// Rate expiration:
        /// 0=None
        /// 1=Daily;
        /// 2=Weekly;
        /// 3=Bi-weekly;
        /// 4=Semiweekly;
        /// 5=Monthly;
        /// 6=Quarterly;
        /// 7=Annually;
        /// 8=Miscellaneous;
        /// 9=None;
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RATEEXPR
        {
            get { return _RATEEXPR; }
            set { _RATEEXPR = value; }
        }

        /// <summary>
        /// Days to increment--used only when RATEEXPR=8
        /// </summary>
        [DataMember]
        public short? DYSTINCR
        {
            get { return _DYSTINCR; }
            set { _DYSTINCR = value; }
        }

        /// <summary>
        /// Rate variance
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? RATEVARC
        {
            get { return _RATEVARC; }
            set { _RATEVARC = value; }
        }

        /// <summary>
        /// Transaction date default:
        /// 0=Exact date;
        /// 1=Next date;
        /// 2=Previous date
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? TRXDTDEF
        {
            get { return _TRXDTDEF; }
            set { _TRXDTDEF = value; }
        }

        /// <summary>
        /// Previous days limits
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? PRVDSLMT
        {
            get { return _PRVDSLMT; }
            set { _PRVDSLMT = value; }
        }

        /// <summary>
        /// Date limits:
        /// 0=Unlimited;
        /// 1=Limited
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DATELMTS
        {
            get { return _DATELMTS; }
            set { _DATELMTS = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False;
        /// 1=True(if True it populates the requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get { return _RequesterTrx; }
            set { _RequesterTrx = value; }
        }

    }
}

