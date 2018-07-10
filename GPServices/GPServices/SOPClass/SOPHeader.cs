using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;


namespace SOPClass
{
    [DataContract]
    public class SOPHeader
    {
        private short _SOPTYPE;
        private string _DOCID;
        private string _SOPNUMBE;
        private string _ORIGNUMB;
        private short? _ORIGTYPE;
        private string _TAXSCHID;
        private string _FRTSCHID;
        private string _MSCSCHID;
        private string _SHIPMTHD;
        private decimal? _TAXAMNT;
        private string _LOCNCODE;
        private DateTime _DOCDATE;
        private decimal? _FREIGHT;
        private decimal? _MISCAMNT;
        private decimal? _TRDISAMT;
        private decimal? _TRADEPCT;
        private decimal? _DISTKNAM;
        private decimal? _MRKDNAMT;
        private string _CUSTNMBR;
        private string _CUSTNAME;
        private string _CSTPONBR;
        private string _ShipToName;
        private string _ADDRESS1;
        private string _ADDRESS2;
        private string _ADDRESS3;
        private string _CNTCPRSN;
        private string _FAXNUMBR;
        private string _CITY;
        private string _STATE;
        private string _ZIPCODE;
        private string _COUNTRY;
        private string _PHNUMBR1;
        private string _PHNUMBR2;
        private string _PHNUMBR3;
        private short? _Print_Phone_NumberGB;
        private decimal? _SUBTOTAL;
        private decimal? _DOCAMNT;
        private decimal? _PYMTRCVD;
        private string _SALSTERR;
        private string _SLPRSNID;
        private string _UPSZONE;
        private string _USER2ENT;
        private string _BACHNUMB;
        private string _PRBTADCD;
        private string _PRSTADCD;
        private decimal? _FRTTXAMT;
        private decimal? _MSCTXAMT;
        private DateTime? _ORDRDATE;
        private int? _MSTRNUMB;
        private string _PYMTRMID;
        private DateTime? _DUEDATE;
        private DateTime? _DISCDATE;
        private string _REFRENCE;
        private int? _USINGHEADERLEVELTAXES;
        private string _BatchCHEKBKID;
        private short? _CREATECOMM;
        private decimal _COMMAMNT;
        private decimal _COMPRCNT;
        private short? _CREATEDIST;
        private short? _CREATETAXES;
        private short? _DEFTAXSCHDS;
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
        private decimal? _DISAVAMT;
        private decimal? _DSCDLRAM;
        private decimal? _DSCPCTAM;
        private int? _FREIGTBLE;
        private int? _MISCTBLE;
        private string _COMMNTID;
        private string _COMMENT_1;
        private string _COMMENT_2;
        private string _COMMENT_3;
        private string _COMMENT_4;
        private string _GPSFOINTEGRATIONID;
        private short? _INTEGRATIONSOURCE;
        private string _INTEGRATIONID;
        private DateTime? _ReqShipDate;
        private short? _RequesterTrx;
        private short? _CKCreditLimit;
        private short? _CKHOLD;
        private short? _UpdateExisting;
        private DateTime? _QUOEXPDA;
        private DateTime? _QUOTEDAT;
        private DateTime? _INVODATE;
        private DateTime? _BACKDATE;
        private DateTime? _RETUDATE;
        private string _CMMTTEXT;
        private string _PRCLEVEL;
        private short? _DEFPRICING;
        private string _TAXEXMT1;
        private string _TAXEXMT2;
        private string _TXRGNNUM;
        private short? _REPTING;
        private short? _TRXFREQU;
        private short? _TIMETREP;
        private short? _QUOTEDYSTINCR;
        private string _NOTETEXT;

        /// <summary>
        /// 1=Quote; 2=Order; 3=Invoice; 4=Return; 5=Back order; 6=Fulfillment orders
        /// </summary>
        [DataMember]
        public short SOPTYPE
        {
            get
            {
                return _SOPTYPE;
            }

            set
            {
                _SOPTYPE = value;
            }
        }

        /// <summary>
        /// Document ID
        /// </summary>
        [DataMember]
        public string DOCID
        {
            get
            {
                return _DOCID;
            }

            set
            {
                _DOCID = value;
            }
        }

        /// <summary>
        /// Invoice number
        /// </summary>
        [DataMember]
        public string SOPNUMBE
        {
            get
            {
                return _SOPNUMBE;
            }

            set
            {
                _SOPNUMBE = value;
            }
        }

        /// <summary>
        /// Order number
        /// </summary>
        [DataMember]
        public string ORIGNUMB
        {
            get
            {
                return _ORIGNUMB;
            }

            set
            {
                _ORIGNUMB = value;
            }
        }

        /// <summary>
        /// Document type of the originating SOP number
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? ORIGTYPE
        {
            get
            {
                return _ORIGTYPE;
            }

            set
            {
                _ORIGTYPE = value;
            }
        }

        /// <summary>
        /// Tax schedule
        /// </summary>
        [DataMember]
        public string TAXSCHID
        {
            get
            {
                return _TAXSCHID;
            }

            set
            {
                _TAXSCHID = value;
            }
        }

        /// <summary>
        /// Freight tax schedule
        /// </summary>
        [DataMember]
        public string FRTSCHID
        {
            get
            {
                return _FRTSCHID;
            }

            set
            {
                _FRTSCHID = value;
            }
        }

        /// <summary>
        /// Miscellaneous tax schedule
        /// </summary>
        [DataMember]
        public string MSCSCHID
        {
            get
            {
                return _MSCSCHID;
            }

            set
            {
                _MSCSCHID = value;
            }
        }

        /// <summary>
        /// Shipping method
        /// </summary>
        [DataMember]
        public string SHIPMTHD
        {
            get
            {
                return _SHIPMTHD;
            }

            set
            {
                _SHIPMTHD = value;
            }
        }

        /// <summary>
        /// Tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TAXAMNT
        {
            get
            {
                return _TAXAMNT;
            }

            set
            {
                _TAXAMNT = value;
            }
        }

        /// <summary>
        /// Location code
        /// </summary>
        [DataMember]
        public string LOCNCODE
        {
            get
            {
                return _LOCNCODE;
            }

            set
            {
                _LOCNCODE = value;
            }
        }

        /// <summary>
        /// Document date
        /// </summary>
        [DataMember]
        public DateTime DOCDATE
        {
            get
            {
                return _DOCDATE;
            }

            set
            {
                _DOCDATE = value;
            }
        }

        /// <summary>
        /// Freight amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FREIGHT
        {
            get
            {
                return _FREIGHT;
            }

            set
            {
                _FREIGHT = value;
            }
        }

        /// <summary>
        /// Miscellaneous amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MISCAMNT
        {
            get
            {
                return _MISCAMNT;
            }

            set
            {
                _MISCAMNT = value;
            }
        }

        /// <summary>
        /// Trade discount amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TRDISAMT
        {
            get
            {
                return _TRDISAMT;
            }

            set
            {
                _TRDISAMT = value;
            }
        }

        /// <summary>
        /// Trade discount percentage
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TRADEPCT
        {
            get
            {
                return _TRADEPCT;
            }

            set
            {
                _TRADEPCT = value;
            }
        }

        /// <summary>
        /// Discount taken amount--cannot be larger then discount available amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DISTKNAM
        {
            get
            {
                return _DISTKNAM;
            }

            set
            {
                _DISTKNAM = value;
            }
        }

        /// <summary>
        /// Markdown amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MRKDNAMT
        {
            get
            {
                return _MRKDNAMT;
            }

            set
            {
                _MRKDNAMT = value;
            }
        }

        /// <summary>
        /// Customer number
        /// </summary>
        [DataMember]
        public string CUSTNMBR
        {
            get
            {
                return _CUSTNMBR;
            }

            set
            {
                _CUSTNMBR = value;
            }
        }

        /// <summary>
        /// Customer name
        /// </summary>
        [DataMember]
        public string CUSTNAME
        {
            get
            {
                return _CUSTNAME;
            }

            set
            {
                _CUSTNAME = value;
            }
        }


        /// <summary>
        /// Customer purchase order number
        /// </summary>
        [DataMember]
        public string CSTPONBR
        {
            get
            {
                return _CSTPONBR;
            }

            set
            {
                _CSTPONBR = value;
            }
        }

        /// <summary>
        /// Ship to name:The default gets the ship to name from the customer ship to address
        /// </summary>
        [DataMember]
        public string ShipToName
        {
            get
            {
                return _ShipToName;
            }

            set
            {
                _ShipToName = value;
            }
        }

        /// <summary>
        /// Customer address one
        /// </summary>
        [DataMember]
        public string ADDRESS1
        {
            get
            {
                return _ADDRESS1;
            }

            set
            {
                _ADDRESS1 = value;
            }
        }

        /// <summary>
        /// Customer address two
        /// </summary>
        [DataMember]
        public string ADDRESS2
        {
            get
            {
                return _ADDRESS2;
            }

            set
            {
                _ADDRESS2 = value;
            }
        }

        /// <summary>
        /// Customer address three
        /// </summary>
        [DataMember]
        public string ADDRESS3
        {
            get
            {
                return _ADDRESS3;
            }

            set
            {
                _ADDRESS3 = value;
            }
        }

        /// <summary>
        /// Contact person
        /// </summary>
        [DataMember]
        public string CNTCPRSN
        {
            get
            {
                return _CNTCPRSN;
            }

            set
            {
                _CNTCPRSN = value;
            }
        }

        /// <summary>
        /// Fax number
        /// </summary>
        [DataMember]
        public string FAXNUMBR
        {
            get
            {
                return _FAXNUMBR;
            }

            set
            {
                _FAXNUMBR = value;
            }
        }

        /// <summary>
        /// Customer city
        /// </summary>
        [DataMember]
        public string CITY
        {
            get
            {
                return _CITY;
            }

            set
            {
                _CITY = value;
            }
        }

        /// <summary>
        /// Customer state
        /// </summary>
        [DataMember]
        public string STATE
        {
            get
            {
                return _STATE;
            }

            set
            {
                _STATE = value;
            }
        }

        /// <summary>
        /// Customer ZIP Code
        /// </summary>
        [DataMember]
        public string ZIPCODE
        {
            get
            {
                return _ZIPCODE;
            }

            set
            {
                _ZIPCODE = value;
            }
        }

        /// <summary>
        /// Customer country
        /// </summary>
        [DataMember]
        public string COUNTRY
        {
            get
            {
                return _COUNTRY;
            }

            set
            {
                _COUNTRY = value;
            }
        }

        /// <summary>
        /// Phone one
        /// </summary>
        [DataMember]
        public string PHNUMBR1
        {
            get
            {
                return _PHNUMBR1;
            }

            set
            {
                _PHNUMBR1 = value;
            }
        }

        /// <summary>
        /// Phone two
        /// </summary>
        [DataMember]
        public string PHNUMBR2
        {
            get
            {
                return _PHNUMBR2;
            }

            set
            {
                _PHNUMBR2 = value;
            }
        }

        /// <summary>
        /// Phone three
        /// </summary>
        [DataMember]
        public string PHNUMBR3
        {
            get
            {
                return _PHNUMBR3;
            }

            set
            {
                _PHNUMBR3 = value;
            }
        }

        /// <summary>
        /// Print phone number:0=Do not print;1=Phone 1;2=Phone 2;3=Phone 3;4=Fax
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? Print_Phone_NumberGB
        {
            get
            {
                return _Print_Phone_NumberGB;
            }

            set
            {
                _Print_Phone_NumberGB = value;
            }
        }

        /// <summary>
        /// Subtotal=Total before taxes
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? SUBTOTAL
        {
            get
            {
                return _SUBTOTAL;
            }

            set
            {
                _SUBTOTAL = value;
            }
        }

        /// <summary>
        /// Document amount/total
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DOCAMNT
        {
            get
            {
                return _DOCAMNT;
            }

            set
            {
                _DOCAMNT = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? PYMTRCVD
        {
            get
            {
                return _PYMTRCVD;
            }

            set
            {
                _PYMTRCVD = value;
            }
        }

        /// <summary>
        /// Sales territory
        /// </summary>
        [DataMember]
        public string SALSTERR
        {
            get
            {
                return _SALSTERR;
            }

            set
            {
                _SALSTERR = value;
            }
        }

        /// <summary>
        /// Salesperson ID
        /// </summary>
        [DataMember]
        public string SLPRSNID
        {
            get
            {
                return _SLPRSNID;
            }

            set
            {
                _SLPRSNID = value;
            }
        }

        /// <summary>
        /// UPS zone
        /// </summary>
        [DataMember]
        public string UPSZONE
        {
            get
            {
                return _UPSZONE;
            }

            set
            {
                _UPSZONE = value;
            }
        }

        /// <summary>
        /// User who entered
        /// </summary>
        [DataMember]
        public string USER2ENT
        {
            get
            {
                return _USER2ENT;
            }

            set
            {
                _USER2ENT = value;
            }
        }

        /// <summary>
        /// Batch number
        /// </summary>
        [DataMember]
        public string BACHNUMB
        {
            get
            {
                return _BACHNUMB;
            }

            set
            {
                _BACHNUMB = value;
            }
        }

        /// <summary>
        /// Primary bill to address code
        /// </summary>
        [DataMember]
        public string PRBTADCD
        {
            get
            {
                return _PRBTADCD;
            }

            set
            {
                _PRBTADCD = value;
            }
        }

        /// <summary>
        /// Primary ship to address code
        /// </summary>
        [DataMember]
        public string PRSTADCD
        {
            get
            {
                return _PRSTADCD;
            }

            set
            {
                _PRSTADCD = value;
            }
        }

        /// <summary>
        /// Freight tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FRTTXAMT
        {
            get
            {
                return _FRTTXAMT;
            }

            set
            {
                _FRTTXAMT = value;
            }
        }

        /// <summary>
        /// Miscellaneous tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MSCTXAMT
        {
            get
            {
                return _MSCTXAMT;
            }

            set
            {
                _MSCTXAMT = value;
            }
        }

        /// <summary>
        /// Order date
        /// </summary>
        [DataMember]
        public DateTime? ORDRDATE
        {
            get
            {
                return _ORDRDATE;
            }

            set
            {
                _ORDRDATE = value;
            }
        }
        /// <summary>
        /// Master Number--default is next number if 0
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? MSTRNUMB
        {
            get
            {
                return _MSTRNUMB;
            }

            set
            {
                _MSTRNUMB = value;
            }
        }

        /// <summary>
        /// Payment terms ID--default is from customer if not passed in
        /// </summary>
        [DataMember]
        public string PYMTRMID
        {
            get
            {
                return _PYMTRMID;
            }

            set
            {
                _PYMTRMID = value;
            }
        }

        /// <summary>
        /// Due date
        /// </summary>
        [DataMember]
        public DateTime? DUEDATE
        {
            get
            {
                return _DUEDATE;
            }

            set
            {
                _DUEDATE = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime? DISCDATE
        {
            get
            {
                return _DISCDATE;
            }

            set
            {
                _DISCDATE = value;
            }
        }

        /// <summary>
        /// GL reference
        /// </summary>
        [DataMember]
        public string REFRENCE
        {
            get
            {
                return _REFRENCE;
            }

            set
            {
                _REFRENCE = value;
            }
        }

        /// <summary>
        /// Header level taxes
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? USINGHEADERLEVELTAXES
        {
            get
            {
                return _USINGHEADERLEVELTAXES;
            }

            set
            {
                _USINGHEADERLEVELTAXES = value;
            }
        }

        /// <summary>
        /// Checkbook ID for the batch
        /// </summary>
        [DataMember]
        public string BatchCHEKBKID
        {
            get
            {
                return _BatchCHEKBKID;
            }

            set
            {
                _BatchCHEKBKID = value;
            }
        }
        
        /// <summary>
        /// Flag to autocreate commissions:0=Manual; 1=Automatic--use if not calling taSopCommissions node
        /// </summary>
        [DataMember]
        [DefaultValue (0)]
        public short? CREATECOMM
        {
            get
            {
                return _CREATECOMM;
            }

            set
            {
                _CREATECOMM = value;
            }
        }
        /// <summary>
        /// Total amount of commissions for this document--used only with manual commissions
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal COMMAMNT
        {
            get
            {
                return _COMMAMNT;
            }

            set
            {
                _COMMAMNT = value;
            }
        }

        /// <summary>
        /// Used for all salespeople if passed in and CREATECOMM=1; leave blank to use default percentages
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal COMPRCNT
        {
            get
            {
                return _COMPRCNT;
            }

            set
            {
                _COMPRCNT = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CREATEDIST
        {
            get
            {
                return _CREATEDIST;
            }

            set
            {
                _CREATEDIST = value;
            }
        }

        /// <summary>
        /// Flag to autocreate taxes with tax engine; leave at 0 if integrating your own
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CREATETAXES
        {
            get
            {
                return _CREATETAXES;
            }

            set
            {
                _CREATETAXES = value;
            }
        }

        /// <summary>
        /// Flag to default tax schedules based on setup if incoming tax schedules empty
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DEFTAXSCHDS
        {
            get
            {
                return _DEFTAXSCHDS;
            }

            set
            {
                _DEFTAXSCHDS = value;
            }
        }

        /// <summary>
        /// Currency ID
        /// </summary>
        [DataMember]
        public string CURNCYID
        {
            get
            {
                return _CURNCYID;
            }

            set
            {
                _CURNCYID = value;
            }
        }

        /// <summary>
        /// Exchange rate
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? XCHGRATE
        {
            get
            {
                return _XCHGRATE;
            }

            set
            {
                _XCHGRATE = value;
            }
        }

        /// <summary>
        /// Rate type ID
        /// </summary>
        [DataMember]
        public string RATETPID
        {
            get
            {
                return _RATETPID;
            }

            set
            {
                _RATETPID = value;
            }
        }

        /// <summary>
        /// Expiration date
        /// </summary>
        [DataMember]
        public DateTime? EXPNDATE
        {
            get
            {
                return _EXPNDATE;
            }

            set
            {
                _EXPNDATE = value;
            }
        }

        /// <summary>
        /// Exchange date
        /// </summary>
        [DataMember]
        public DateTime? EXCHDATE
        {
            get
            {
                return _EXCHDATE;
            }

            set
            {
                _EXCHDATE = value;
            }
        }

        /// <summary>
        /// Exchange ID description
        /// </summary>
        [DataMember]
        public string EXGTBDSC
        {
            get
            {
                return _EXGTBDSC;
            }

            set
            {
                _EXGTBDSC = value;
            }
        }

        /// <summary>
        /// Exchange rate source
        /// </summary>
        [DataMember]
        public string EXTBLSRC
        {
            get
            {
                return _EXTBLSRC;
            }

            set
            {
                _EXTBLSRC = value;
            }
        }
        /// <summary>
        /// Rate expiration: 0=None1=Daily; 2=Weekly; 3=Biweekly; 4=Semimonthly;5=Monthly; 6=Quarterly;7=Annually; 8=Miscellaneous; 9=None
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RATEEXPR
        {
            get
            {
                return _RATEEXPR;
            }

            set
            {
                _RATEEXPR = value;
            }
        }
        /// <summary>
        /// Days to increment--used only when RATEEXPR=8
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DYSTINCR
        {
            get
            {
                return _DYSTINCR;
            }

            set
            {
                _DYSTINCR = value;
            }
        }

        /// <summary>
        /// Rate variance
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? RATEVARC
        {
            get
            {
                return _RATEVARC;
            }

            set
            {
                _RATEVARC = value;
            }
        }

        /// <summary>
        /// Transaction date default:0=Exact date; 1=Next date; 2=Previous date
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? TRXDTDEF
        {
            get
            {
                return _TRXDTDEF;
            }

            set
            {
                _TRXDTDEF = value;
            }
        }
        /// <summary>
        /// Rate calculation method:0=Multiply; 1=Divide
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RTCLCMTD
        {
            get
            {
                return _RTCLCMTD;
            }

            set
            {
                _RTCLCMTD = value;
            }
        }

        /// <summary>
        /// Previous day's limits
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? PRVDSLMT
        {
            get
            {
                return _PRVDSLMT;
            }

            set
            {
                _PRVDSLMT = value;
            }
        }

        /// <summary>
        /// Date limits:0=Unlimited;1=Limited
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DATELMTS
        {
            get
            {
                return _DATELMTS;
            }

            set
            {
                _DATELMTS = value;
            }
        }

        /// <summary>
        /// MC exchange time=Time 1
        /// </summary>
        [DataMember]
        public DateTime? TIME1
        {
            get
            {
                return _TIME1;
            }

            set
            {
                _TIME1 = value;
            }
        }

        /// <summary>
        /// Discount available amount; cannot be larger than document amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DISAVAMT
        {
            get
            {
                return _DISAVAMT;
            }

            set
            {
                _DISAVAMT = value;
            }
        }

        /// <summary>
        /// Discount dollar amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DSCDLRAM
        {
            get
            {
                return _DSCDLRAM;
            }

            set
            {
                _DSCDLRAM = value;
            }
        }

        /// <summary>
        /// Discount percent amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? DSCPCTAM
        {
            get
            {
                return _DSCPCTAM;
            }

            set
            {
                _DSCPCTAM = value;
            }
        }

        /// <summary>
        /// Freight taxable:0=Default from SOP setup; 1=Taxable; 2=Nontaxable; 3=Base on customers
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? FREIGTBLE
        {
            get
            {
                return _FREIGTBLE;
            }

            set
            {
                _FREIGTBLE = value;
            }
        }

        /// <summary>
        /// Miscellaneous amount taxable:0=Default from SOP setup;1=Taxable; 2=Nontaxable; 3=Base on customers
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? MISCTBLE
        {
            get
            {
                return _MISCTBLE;
            }

            set
            {
                _MISCTBLE = value;
            }
        }

        /// <summary>
        /// Comment ID
        /// </summary>
        [DataMember]
        public string COMMNTID
        {
            get
            {
                return _COMMNTID;
            }

            set
            {
                _COMMNTID = value;
            }
        }

        /// <summary>
        /// Comment 1
        /// </summary>
        [DataMember]
        public string COMMENT_1
        {
            get
            {
                return _COMMENT_1;
            }

            set
            {
                _COMMENT_1 = value;
            }
        }

        /// <summary>
        /// Comment 2
        /// </summary>
        [DataMember]
        public string COMMENT_2
        {
            get
            {
                return _COMMENT_2;
            }

            set
            {
                _COMMENT_2 = value;
            }
        }

        /// <summary>
        /// Comment 3
        /// </summary>
        [DataMember]
        public string COMMENT_3
        {
            get
            {
                return _COMMENT_3;
            }

            set
            {
                _COMMENT_3 = value;
            }
        }

        /// <summary>
        /// Comment 4
        /// </summary>
        [DataMember]
        public string COMMENT_4
        {
            get
            {
                return _COMMENT_4;
            }

            set
            {
                _COMMENT_4 = value;
            }
        }

        /// <summary>
        /// Front office integration ID
        /// </summary>
        [DataMember]
        public string GPSFOINTEGRATIONID
        {
            get
            {
                return _GPSFOINTEGRATIONID;
            }

            set
            {
                _GPSFOINTEGRATIONID = value;
            }
        }

        /// <summary>
        /// Integration source
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? INTEGRATIONSOURCE
        {
            get
            {
                return _INTEGRATIONSOURCE;
            }

            set
            {
                _INTEGRATIONSOURCE = value;
            }
        }

        /// <summary>
        /// Integration ID
        /// </summary>
        [DataMember]
        public string INTEGRATIONID
        {
            get
            {
                return _INTEGRATIONID;
            }

            set
            {
                _INTEGRATIONID = value;
            }
        }

        /// <summary>
        /// Requested ship date
        /// </summary>
        [DataMember]
        public DateTime? ReqShipDate
        {
            get
            {
                return _ReqShipDate;
            }

            set
            {
                _ReqShipDate = value;
            }
        }

        /// <summary>
        /// Requester transaction:0=False; 1=True (if True, it populates requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get
            {
                return _RequesterTrx;
            }

            set
            {
                _RequesterTrx = value;
            }
        }

        /// <summary>
        /// Flag to allow check on credit limits before transaction is processed: 0=Does not check credit limit;1=Checks credit limit
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CKCreditLimit
        {
            get
            {
                return _CKCreditLimit;
            }

            set
            {
                _CKCreditLimit = value;
            }
        }

        /// <summary>
        /// Flag to allow check on hold status: 0=Does not check hold status;1=Checks hold status
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CKHOLD
        {
            get
            {
                return _CKHOLD;
            }

            set
            {
                _CKHOLD = value;
            }
        }

        /// <summary>
        /// Used to modify header: 0=New transaction; 1=Update header--used to update after transaction exists
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? UpdateExisting
        {
            get
            {
                return _UpdateExisting;
            }

            set
            {
                _UpdateExisting = value;
            }
        }

        /// <summary>
        /// Quote expiration date; defaults based on setup if not filled in
        /// </summary>
        [DataMember]
        public DateTime? QUOEXPDA
        {
            get
            {
                return _QUOEXPDA;
            }

            set
            {
                _QUOEXPDA = value;
            }
        }

        /// <summary>
        /// Quote date; used for SOPTYPE <> 1; if SOPTYPE=1, DOCDATE is used
        /// </summary>
        [DataMember]
        public DateTime? QUOTEDAT
        {
            get
            {
                return _QUOTEDAT;
            }

            set
            {
                _QUOTEDAT = value;
            }
        }

        /// <summary>
        /// Invoice date; used for SOPTYPE <> 3; if SOPTYPE=3, DOCDATE is used
        /// </summary>
        [DataMember]
        public DateTime? INVODATE
        {
            get
            {
                return _INVODATE;
            }

            set
            {
                _INVODATE = value;
            }
        }

        /// <summary>
        /// Back order date; used for SOPTYPE <> 4; if SOPTYPE=4, DOCDATE is used
        /// </summary>
        [DataMember]
        public DateTime? BACKDATE
        {
            get
            {
                return _BACKDATE;
            }

            set
            {
                _BACKDATE = value;
            }
        }

        /// <summary>
        /// Return date; used for SOPTYPE <> 5; if SOPTYPE=5, DOCDATE is used
        /// </summary>
        [DataMember]
        public DateTime? RETUDATE
        {
            get
            {
                return _RETUDATE;
            }

            set
            {
                _RETUDATE = value;
            }
        }

        /// <summary>
        /// Comment text; used only if not using COMMENT_1 through COMMENT_4
        /// </summary>
        [DataMember]
        public string CMMTTEXT
        {
            get
            {
                return _CMMTTEXT;
            }

            set
            {
                _CMMTTEXT = value;
            }
        }

        /// <summary>
        /// Price level
        /// </summary>
        [DataMember]
        public string PRCLEVEL
        {
            get
            {
                return _PRCLEVEL;
            }

            set
            {
                _PRCLEVEL = value;
            }
        }

        /// <summary>
        /// 1=Subtotal will be calculated from SOP line or lines
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DEFPRICING
        {
            get
            {
                return _DEFPRICING;
            }

            set
            {
                _DEFPRICING = value;
            }
        }

        /// <summary>
        /// Tax exempt 1; default is from customer if not supplied
        /// </summary>
        [DataMember]
        public string TAXEXMT1
        {
            get
            {
                return _TAXEXMT1;
            }

            set
            {
                _TAXEXMT1 = value;
            }
        }

        /// <summary>
        /// Tax exempt 2; default is from customer if not supplied
        /// </summary>
        [DataMember]
        public string TAXEXMT2
        {
            get
            {
                return _TAXEXMT2;
            }

            set
            {
                _TAXEXMT2 = value;
            }
        }

        /// <summary>
        /// Tax registration number; default is from customer if not supplied
        /// </summary>
        [DataMember]
        public string TXRGNNUM
        {
            get
            {
                return _TXRGNNUM;
            }

            set
            {
                _TXRGNNUM = value;
            }
        }

        /// <summary>
        /// Repeating:0=False;1=TrueOnly valid for SOPTYPE=1 or 2
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? REPTING
        {
            get
            {
                return _REPTING;
            }

            set
            {
                _REPTING = value;
            }
        }

        /// <summary>
        /// Frequency:1=Weekly; 2=Biweekly; 3=Semimonthly;4=Monthly; 5=Bi-Monthly; 6=Quarterly; 7=Misc.Only valid for SOPTYPE=1 or 2
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? TRXFREQU
        {
            get
            {
                return _TRXFREQU;
            }

            set
            {
                _TRXFREQU = value;
            }
        }

        /// <summary>
        /// Times Repeating;Only valid for SOPTYPE=1 or 2
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? TIMETREP
        {
            get
            {
                return _TIMETREP;
            }

            set
            {
                _TIMETREP = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? QUOTEDYSTINCR
        {
            get
            {
                return _QUOTEDYSTINCR;
            }

            set
            {
                _QUOTEDYSTINCR = value;
            }
        }

        /// <summary>
        /// Notes field
        /// </summary>
        [DataMember]
        public string NOTETEXT
        {
            get
            {
                return _NOTETEXT;
            }

            set
            {
                _NOTETEXT = value;
            }
        }
    }
}
