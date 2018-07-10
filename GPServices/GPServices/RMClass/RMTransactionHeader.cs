using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace RMClass
{
    [DataContract]
    public class RMTransactionHeader
    {
        private short _RMDTYPAL;
        private string _DOCNUMBR;
        private DateTime _DOCDATE;
        private string _BACHNUMB;
        private string _CUSTNMBR;
        private decimal _DOCAMNT;
        private decimal _SLSAMNT;
        private string _DOCDESCR;
        private string _ADRSCODE;
        private string _SLPRSNID;
        private string _SALSTERR;
        private string _SHIPMTHD;
        private string _TAXSCHID;
        private string _CSTPONBR;
        private decimal? _COSTAMNT;
        private decimal? _TRDISAMT;
        private short? _TRDDISCT;
        private decimal? _FRTAMNT;
        private decimal? _MISCAMNT;
        private decimal? _TAXAMNT;
        private decimal? _BKTSLSAM;
        private decimal? _BKTFRTAM;
        private decimal? _BKTMSCAM;
        private decimal? _CASHAMNT;
        private string _CBKIDCSH;
        private DateTime? _CASHDATE;
        private string _DCNUMCSH;
        private decimal? _CHEKAMNT;
        private string _CBKIDCHK;
        private string _CBKIDCRD;
        private string _CHEKNMBR;
        private DateTime? _CHEKDATE;
        private string _DCNUMCHK;
        private decimal? _CRCRDAMT;
        private string _CRCRDNAM;
        private string _RCTNCCRD;
        private DateTime? _CRCARDDT;
        private string _DCNUMCRD;
        private decimal? _DISCRTND;
        private decimal? _DISTKNAM;
        private decimal? _WROFAMNT;
        private decimal? _PPSAMDED;
        private decimal? _GSTDSAMT;
        private string _PYMTRMID;
        private decimal? _DISAVAMT;
        private decimal? _DSCDLRAM;
        private decimal? _DSCPCTAM;
        private string _LSTUSRED;
        private string _PTDUSRID;
        private string _DistRef;
        private string _BatchCHEKBKID;
        private DateTime? _DUEDATE;
        private DateTime? _DISCDATE;
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
        private short? _RTCLCMTD;
        private short? _PRVDSLMT;
        private short? _DATELMTS;
        private DateTime? _TIME1;
        private decimal? _COMDLRAM;
        private short? _COMAPPTO;
        private short? _RequesterTrx;
        private short? _CREATEDIST;
        private short? _CreateTaxes;

        /// <summary>
        /// 1=Sales/invoice;
        /// 3=Debit memo;
        /// 4=Finance charge;
        /// 5=Service/repair;
        /// 6=Warranty;
        /// 7=Credit memo; 8=Return
        /// </summary>
        [DataMember]
        public short RMDTYPAL
        {
            get { return _RMDTYPAL; }
            set { _RMDTYPAL = value; }
        }

        /// <summary>
        /// Document number
        /// </summary>
        [DataMember]
        public string DOCNUMBR
        {
            get { return _DOCNUMBR; }
            set { _DOCNUMBR = value; }
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
        /// Batch number
        /// </summary>
        [DataMember]
        public string BACHNUMB
        {
            get { return _BACHNUMB; }
            set { _BACHNUMB = value; }
        }

        /// <summary>
        /// Customer number
        /// </summary>
        [DataMember]
        public string CUSTNMBR
        {
            get { return _CUSTNMBR; }
            set { _CUSTNMBR = value; }
        }

        /// <summary>
        /// Document amount
        /// </summary>
        [DataMember]
        public decimal DOCAMNT
        {
            get { return _DOCAMNT; }
            set { _DOCAMNT = value; }
        }

        /// <summary>
        /// Sales amount
        /// </summary>
        [DataMember]
        public decimal SLSAMNT
        {
            get { return _SLSAMNT; }
            set { _SLSAMNT = value; }
        }

        /// <summary>
        /// Document description
        /// </summary>
        [DataMember]
        public string DOCDESCR
        {
            get { return _DOCDESCR; }
            set { _DOCDESCR = value; }
        }

        /// <summary>
        /// Address code
        /// </summary>
        [DataMember]
        public string ADRSCODE
        {
            get { return _ADRSCODE; }
            set { _ADRSCODE = value; }
        }

        /// <summary>
        /// Salesperson ID
        /// </summary>
        [DataMember]
        public string SLPRSNID
        {
            get { return _SLPRSNID; }
            set { _SLPRSNID = value; }
        }

        /// <summary>
        /// Sales territory
        /// </summary>
        [DataMember]
        public string SALSTERR
        {
            get { return _SALSTERR; }
            set { _SALSTERR = value; }
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
        /// Tax schedule ID
        /// </summary>
        [DataMember]
        public string TAXSCHID
        {
            get { return _TAXSCHID; }
            set { _TAXSCHID = value; }
        }

        /// <summary>
        /// Customer PO number
        /// </summary>
        [DataMember]
        public string CSTPONBR
        {
            get { return _CSTPONBR; }
            set { _CSTPONBR = value; }
        }

        /// <summary>
        /// Cost amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? COSTAMNT
        {
            get { return _COSTAMNT; }
            set { _COSTAMNT = value; }
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
        /// Trade discount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? TRDDISCT
        {
            get { return _TRDDISCT; }
            set { _TRDDISCT = value; }
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
        /// Miscellaneous amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MISCAMNT
        {
            get { return _MISCAMNT; }
            set { _MISCAMNT = value; }
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
        /// Back out sales amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? BKTSLSAM
        {
            get { return _BKTSLSAM; }
            set { _BKTSLSAM = value; }
        }

        /// <summary>
        /// Back out freight amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? BKTFRTAM
        {
            get { return _BKTFRTAM; }
            set { _BKTFRTAM = value; }
        }

        /// <summary>
        /// Back out miscellaneous amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? BKTMSCAM
        {
            get { return _BKTMSCAM; }
            set { _BKTMSCAM = value; }
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
        /// Checkbook ID cash
        /// </summary>
        [DataMember]
        public string CBKIDCSH
        {
            get { return _CBKIDCSH; }
            set { _CBKIDCSH = value; }
        }

        /// <summary>
        /// Cash date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? CASHDATE
        {
            get { return _CASHDATE; }
            set { _CASHDATE = value; }
        }

        /// <summary>
        /// Document number cash
        /// </summary>
        [DataMember]
        public string DCNUMCSH
        {
            get { return _DCNUMCSH; }
            set { _DCNUMCSH = value; }
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
        /// Checkbook ID check
        /// </summary>
        [DataMember]
        public string CBKIDCHK
        {
            get { return _CBKIDCHK; }
            set { _CBKIDCHK = value; }
        }

        /// <summary>
        /// Checkbook ID credit card
        /// </summary>
        [DataMember]
        public string CBKIDCRD
        {
            get { return _CBKIDCRD; }
            set { _CBKIDCRD = value; }
        }

        /// <summary>
        /// Check number
        /// </summary>
        [DataMember]
        public string CHEKNMBR
        {
            get { return _CHEKNMBR; }
            set { _CHEKNMBR = value; }
        }

        /// <summary>
        /// Check date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? CHEKDATE
        {
            get { return _CHEKDATE; }
            set { _CHEKDATE = value; }
        }

        /// <summary>
        /// Document number of the check
        /// </summary>
        [DataMember]
        public string DCNUMCHK
        {
            get { return _DCNUMCHK; }
            set { _DCNUMCHK = value; }
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
        /// Credit card name
        /// </summary>
        [DataMember]
        public string CRCRDNAM
        {
            get { return _CRCRDNAM; }
            set { _CRCRDNAM = value; }
        }

        /// <summary>
        /// Receipt number for the credit card
        /// </summary>
        [DataMember]
        public string RCTNCCRD
        {
            get { return _RCTNCCRD; }
            set { _RCTNCCRD = value; }
        }

        /// <summary>
        /// Credit card date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? CRCARDDT
        {
            get { return _CRCARDDT; }
            set { _CRCARDDT = value; }
        }

        /// <summary>
        /// Document number for the credit card
        /// </summary>
        [DataMember]
        public string DCNUMCRD
        {
            get { return _DCNUMCRD; }
            set { _DCNUMCRD = value; }
        }

        /// <summary>
        /// Discount returned
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DISCRTND
        {
            get { return _DISCRTND; }
            set { _DISCRTND = value; }
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
        /// Write-off amount for credit documents
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? WROFAMNT
        {
            get { return _WROFAMNT; }
            set { _WROFAMNT = value; }
        }

        /// <summary>
        /// PPS amount deducted for credits
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? PPSAMDED
        {
            get { return _PPSAMDED; }
            set { _PPSAMDED = value; }
        }

        /// <summary>
        /// GST discount amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? GSTDSAMT
        {
            get { return _GSTDSAMT; }
            set { _GSTDSAMT = value; }
        }

        /// <summary>
        /// Payment term ID
        /// </summary>
        [DataMember]
        public string PYMTRMID
        {
            get { return _PYMTRMID; }
            set { _PYMTRMID = value; }
        }

        /// <summary>
        /// Discount available amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DISAVAMT
        {
            get { return _DISAVAMT; }
            set { _DISAVAMT = value; }
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
        /// Discount percent amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DSCPCTAM
        {
            get { return _DSCPCTAM; }
            set { _DSCPCTAM = value; }
        }

        /// <summary>
        /// Last user to edit
        /// </summary>
        [DataMember]
        public string LSTUSRED
        {
            get { return _LSTUSRED; }
            set { _LSTUSRED = value; }
        }

        /// <summary>
        /// Posted user ID
        /// </summary>
        [DataMember]
        public string PTDUSRID
        {
            get { return _PTDUSRID; }
            set { _PTDUSRID = value; }
        }

        /// <summary>
        /// Distribution reference
        /// </summary>
        [DataMember]
        public string DistRef
        {
            get { return _DistRef; }
            set { _DistRef = value; }
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
        /// Due date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? DUEDATE
        {
            get { return _DUEDATE; }
            set { _DUEDATE = value; }
        }

        /// <summary>
        /// Discount date
        /// </summary>
        [DataMember]
        [DefaultValue("1900-01-01 00:00:00")]
        public DateTime? DISCDATE
        {
            get { return _DISCDATE; }
            set { _DISCDATE = value; }
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
        /// Time 1
        /// </summary>
        [DataMember]
        public DateTime? TIME1
        {
            get { return _TIME1; }
            set { _TIME1 = value; }
        }

        /// <summary>
        /// Commission amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? COMDLRAM
        {
            get { return _COMDLRAM; }
            set { _COMDLRAM = value; }
        }

        /// <summary>
        /// Commission apply to
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? COMAPPTO
        {
            get { return _COMAPPTO; }
            set { _COMAPPTO = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False;
        /// 1=True(if True, it populates the requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get { return _RequesterTrx; }
            set { _RequesterTrx = value; }
        }

        /// <summary>
        /// Flag to autocreate distributions:
        /// 0=Manual;
        /// 1=Automatic
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CREATEDIST
        {
            get { return _CREATEDIST; }
            set { _CREATEDIST = value; }
        }

        /// <summary>
        /// flag to create taxes
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? CreateTaxes
        {
            get { return _CreateTaxes; }
            set { _CreateTaxes = value; }
        }
    }
}
