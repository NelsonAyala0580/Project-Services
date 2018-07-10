using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;

namespace PMClass
{
    [DataContract]
    public class PMTransactionHeader
    {
        private string _BACHNUMB;
        private string _VCHNUMWK;
        private string _VENDORID;
        private string _DOCNUMBR;
        private short _DOCTYPE;
        private decimal? _DOCAMNT;
        private DateTime _DOCDATE;
        private DateTime? _PSTGDATE;
        private string _VADCDTRO;
        private string _VADDCDPR;
        private string _PYMTRMID;
        private string _TAXSCHID;
        private DateTime _DUEDATE;
        private decimal? _DSCDLRAM;
        private DateTime? _DISCDATE;
        private decimal _PRCHAMNT;
        private decimal? _CHRGAMNT;
        private decimal? _CASHAMNT;
        private string _CAMCBKID;
        private string _CDOCNMBR;
        private DateTime? _CAMTDATE;
        private string _CAMPMTNM;
        private decimal? _CHEKAMNT;
        private string _CHAMCBID;
        private DateTime? _CHEKDATE;
        private string _CAMPYNBR;
        private decimal? _CRCRDAMT;
        private string _CCAMPYNM;
        private string _CHEKNMBR;
        private string _CARDNAME;
        private string _CCRCTNUM;
        private DateTime? _CRCARDDT;
        private string _CHEKBKID;
        private string _TRXDSCRN;
        private decimal? _TRDISAMT;
        private decimal? _TAXAMNT;
        private decimal? _FRTAMNT;
        private decimal? _TEN99AMNT;
        private decimal? _MSCCHAMT;
        private string _PORDNMBR;
        private string _SHIPMTHD;
        private decimal? _DISAMTAV;
        private decimal? _DISTKNAM;
        private decimal? _APDSTKAM;
        private string _MDFUSRID;
        private DateTime? _POSTEDDT;
        private string _PTDURID;
        private string _PCHSCHID;
        private string _FRTSCHID;
        private string _MSCSCHID;
        private decimal? _PRCTDISC;
        private DateTime? _Tax_Date;
        private string _CURNCYID;
        private decimal? _XCHGRATE;
        private string _RATEPID;
        private DateTime? _EXPNDATE;
        private DateTime? _EXCHDATE;
        private string _EXGTBDSC;
        private string _EXTBLSRC;
        private short? _RATEEXPR;
        private short? _DYSTINCR;
        private decimal? _RATEVARC;
        private short? _TRXDTDEF;
        private short? _RTCLCMTD;
        private short? _PRVDSLMT;
        private short? _DATELMTS;
        private string _BatchCHEKBKID;
        private short? _CREATEDIST;
        private short? _RequesterTrx;
        private short _CreateTaxes;

        /// <summary>
        /// Batch number; batch for the cash receipt; created on the fly
        /// </summary>
        [DataMember]
        public string BACHNUMB
        {
            get { return _BACHNUMB; }
            set { _BACHNUMB = value; }
        }

        /// <summary>
        /// Voucher number--must be unique
        /// </summary>
        [DataMember]
        public string VCHNUMWK
        {
            get { return _VCHNUMWK; }
            set { _VCHNUMWK = value; }
        }

        /// <summary>
        /// Vendor ID
        /// </summary>
        [DataMember]
        public string VENDORID
        {
            get { return _VENDORID; }
            set { _VENDORID = value; }
        }

        /// <summary>
        /// Document number--unique based on PM40100 setup option
        /// </summary>
        [DataMember]
        public string DOCNUMBR
        {
            get { return _DOCNUMBR; }
            set { _DOCNUMBR = value; }
        }

        /// <summary>
        /// Document type:
        /// 1=Invoice
        /// 2=Finance Charge
        /// 3=Miscellaneous Charge
        /// 4=Return
        /// 5=Credit Memo
        /// </summary>
        [DataMember]
        public short DOCTYPE
        {
            get { return _DOCTYPE; }
            set { _DOCTYPE = value; }
        }

        /// <summary>
        /// Document amount = MSCCHAMT + PRCHAMNT + TAXAMNT + FRTAMNT - TRDISAMT
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DOCAMNT
        {
            get { return _DOCAMNT; }
            set { _DOCAMNT = value; }
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
        /// Posting date
        /// </summary>
        [DataMember]
        public DateTime? PSTGDATE
        {
            get { return _PSTGDATE; }
            set { _PSTGDATE = value; }
        }

        /// <summary>
        /// Remit to Address ID
        /// </summary>
        [DataMember]
        public string VADCDTRO
        {
            get { return _VADCDTRO; }
            set { _VADCDTRO = value; }
        }

        /// <summary>
        /// Primary address ID;
        ///*must exist if filled - use taCreateVendorAddress to create the master record*/
        /// </summary>
        [DataMember]
        public string VADDCDPR
        {
            get { return _VADDCDPR; }
            set { _VADDCDPR = value; }
        }

        /// <summary>
        /// Payment terms ID; must exist if filled
        /// </summary>
        [DataMember]
        public string PYMTRMID
        {
            get { return _PYMTRMID; }
            set { _PYMTRMID = value; }
        }

        /// <summary>
        /// Tax schedule ID; must exist if filled and a tax amount is passed in
        /// </summary>
        [DataMember]
        public string TAXSCHID
        {
            get { return _TAXSCHID; }
            set { _TAXSCHID = value; }
        }

        /// <summary>
        /// Due date
        /// </summary>
        [DataMember]
        public DateTime DUEDATE
        {
            get { return _DUEDATE; }
            set { _DUEDATE = value; }
        }

        /// <summary>
        /// Discount dollar amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DSCDLRAM
        {
            get { return _DSCDLRAM; }
            set { _DSCDLRAM = value; }
        }

        /// <summary>
        /// Discount date
        /// </summary>
        [DataMember]
        public DateTime? DISCDATE
        {
            get { return _DISCDATE; }
            set { _DISCDATE = value; }
        }

        /// <summary>
        /// Purchases amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal PRCHAMNT
        {
            get { return _PRCHAMNT; }
            set { _PRCHAMNT = value; }
        }

        /// <summary>
        /// Charge amount=DOCAMNT - CASHAMNT -CHEKAMNT - CRCRDAMT - DISTKNAM 
        /// (required if on account amount)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CHRGAMNT
        {
            get { return _CHRGAMNT; }
            set { _CHRGAMNT = value; }
        }

        /// <summary>
        /// Cash amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CASHAMNT
        {
            get { return _CASHAMNT; }
            set { _CASHAMNT = value; }
        }

        /// <summary>
        /// Cash amount checkbook ID
        /// </summary>
        [DataMember]
        public string CAMCBKID
        {
            get { return _CAMCBKID; }
            set { _CAMCBKID = value; }
        }


        /// <summary>
        /// Cash document number--required if cash amount is greater than 0
        /// </summary>
        [DataMember]
        public string CDOCNMBR
        {
            get { return _CDOCNMBR; }
            set { _CDOCNMBR = value; }
        }

        /// <summary>
        /// Cash amount date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? CAMTDATE
        {
            get { return _CAMTDATE; }
            set { _CAMTDATE = value; }
        }

        /// <summary>
        /// Cash amount payment number
        /// </summary>
        [DataMember]
        public string CAMPMTNM
        {
            get { return _CAMPMTNM; }
            set { _CAMPMTNM = value; }
        }

        /// <summary>
        /// Check amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CHEKAMNT
        {
            get { return _CHEKAMNT; }
            set { _CHEKAMNT = value; }
        }

        /// <summary>
        /// Check amount checkbook ID
        /// </summary>
        [DataMember]
        public string CHAMCBID
        {
            get { return _CHAMCBID; }
            set { _CHAMCBID = value; }
        }

        /// <summary>
        /// Check amount date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? CHEKDATE
        {
            get { return _CHEKDATE; }
            set { _CHEKDATE = value; }
        }

        /// <summary>
        /// Check payment number
        /// </summary>
        [DataMember]
        public string CAMPYNBR
        {
            get { return _CAMPYNBR; }
            set { _CAMPYNBR = value; }
        }

        /// <summary>
        /// Credit card amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CRCRDAMT
        {
            get { return _CRCRDAMT; }
            set { _CRCRDAMT = value; }
        }

        /// <summary>
        /// Credit card payment number
        /// </summary>
        [DataMember]
        public string CCAMPYNM
        {
            get { return _CCAMPYNM; }
            set { _CCAMPYNM = value; }
        }

        /// <summary>
        /// Check document number
        /// </summary>
        [DataMember]
        public string CHEKNMBR
        {
            get { return _CHEKNMBR; }
            set { _CHEKNMBR = value; }
        }

        /// <summary>
        /// Credit card name
        /// </summary>
        [DataMember]
        public string CARDNAME
        {
            get { return _CARDNAME; }
            set { _CARDNAME = value; }
        }

        /// <summary>
        /// Credit card receipt number
        /// </summary>
        [DataMember]
        public string CCRCTNUM
        {
            get { return _CCRCTNUM; }
            set { _CCRCTNUM = value; }
        }

        /// <summary>
        /// Credit card amount date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? CRCARDDT
        {
            get { return _CRCARDDT; }
            set { _CRCARDDT = value; }
        }

        /// <summary>
        /// Checkbook ID
        /// </summary>
        [DataMember]
        public string CHEKBKID
        {
            get { return _CHEKBKID; }
            set { _CHEKBKID = value; }
        }

        /// <summary>
        /// Transaction description
        /// </summary>
        [DataMember]
        public string TRXDSCRN
        {
            get { return _TRXDSCRN; }
            set { _TRXDSCRN = value; }
        }

        /// <summary>
        /// Trade discount amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TRDISAMT
        {
            get { return _TRDISAMT; }
            set { _TRDISAMT = value; }
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
        /// Freight amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FRTAMNT
        {
            get { return _FRTAMNT; }
            set { _FRTAMNT = value; }
        }

        /// <summary>
        /// 1099 amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TEN99AMNT
        {
            get { return _TEN99AMNT; }
            set { _TEN99AMNT = value; }
        }

        /// <summary>
        /// Miscellaneous charge amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MSCCHAMT
        {
            get { return _MSCCHAMT; }
            set { _MSCCHAMT = value; }
        }

        /// <summary>
        /// Purchase order number
        /// </summary>
        [DataMember]
        public string PORDNMBR
        {
            get { return _PORDNMBR; }
            set { _PORDNMBR = value; }
        }

        /// <summary>
        /// Shipping method
        /// </summary>
        [DataMember]
        public string SHIPMTHD
        {
            get { return _SHIPMTHD; }
            set { _SHIPMTHD = value; }
        }

        /// <summary>
        /// Discount amount available
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DISAMTAV
        {
            get { return _DISAMTAV; }
            set { _DISAMTAV = value; }
        }

        /// <summary>
        /// Discount taken amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DISTKNAM
        {
            get { return _DISTKNAM; }
            set { _DISTKNAM = value; }
        }

        /// <summary>
        /// Applied discount taken amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? APDSTKAM
        {
            get { return _APDSTKAM; }
            set { _APDSTKAM = value; }
        }

        /// <summary>
        /// Modified user ID
        /// </summary>
        [DataMember]
        public string MDFUSRID
        {
            get { return _MDFUSRID; }
            set { _MDFUSRID = value; }
        }

        /// <summary>
        /// Posted date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? POSTEDDT
        {
            get { return _POSTEDDT; }
            set { _POSTEDDT = value; }
        }

        /// <summary>
        /// Posted user ID
        /// </summary>
        [DataMember]
        public string PTDURID
        {
            get { return _PTDURID; }
            set { _PTDURID = value; }
        }

        /// <summary>
        /// Purchase schedule ID
        /// </summary>
        [DataMember]
        public string PCHSCHID
        {
            get { return _PCHSCHID; }
            set { _PCHSCHID = value; }
        }

        /// <summary>
        /// Freight schedule ID
        /// </summary>
        [DataMember]
        public string FRTSCHID
        {
            get { return _FRTSCHID; }
            set { _FRTSCHID = value; }
        }

        /// <summary>
        /// Miscellaneous schedule ID
        /// </summary>
        [DataMember]
        public string MSCSCHID
        {
            get { return _MSCSCHID; }
            set { _MSCSCHID = value; }
        }

        /// <summary>
        /// Percent discount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? PRCTDISC
        {
            get { return _PRCTDISC; }
            set { _PRCTDISC = value; }
        }

        /// <summary>
        /// Tax date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? Tax_Date
        {
            get { return _Tax_Date; }
            set { _Tax_Date = value; }
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
        public string RATEPID
        {
            get { return _RATEPID; }
            set { _RATEPID = value; }
        }

        /// <summary>
        /// Expiration date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? EXPNDATE
        {
            get { return _EXPNDATE; }
            set { _EXPNDATE = value; }
        }

        /// <summary>
        /// Exchange date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
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
        /// 3=Biweekly;
        /// 4=Semimonthly;
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
        [DefaultValue(0)]
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
        /// Rate calculation method:
        /// 0=Multiply;
        /// 1=Divide
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RTCLCMTD
        {
            get { return _RTCLCMTD; }
            set { _RTCLCMTD = value; }
        }

        /// <summary>
        /// Previous day's limits
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? PRVDSLMT
        {
            get { return _PRVDSLMT; }
            set { _PRVDSLMT = value; }
        }

        /// <summary>
        /// Date limits
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DATELMTS
        {
            get { return _DATELMTS; }
            set { _DATELMTS = value; }
        }

        /// <summary>
        /// Checkbook ID for the batch
        /// </summary>
        [DataMember]
        public string BatchCHEKBKID
        {
            get { return _BatchCHEKBKID; }
            set { _BatchCHEKBKID = value; }
        }

        /// <summary>
        /// Flag to autocreate distributions:
        /// 0=Manual;
        /// 1=Automatic--use if not calling the "taPMDistribution" node
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? CREATEDIST
        {
            get { return _CREATEDIST; }
            set { _CREATEDIST = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False;
        /// 1=True(if True, it populates requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get { return _RequesterTrx; }
            set { _RequesterTrx = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short CreateTaxes
        {
            get { return _CreateTaxes; }
            set { _CreateTaxes = value; }
        }
    }
}
