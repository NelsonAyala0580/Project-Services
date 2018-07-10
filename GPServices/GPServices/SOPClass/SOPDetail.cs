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
    public class SOPDetail
    {
        private short _SOPTYPE;
        private string _SOPNUMBE;
        private string _CUSTNMBR;
        private DateTime _DOCDATE;
        private DateTime _USERDATE;
        private string _LOCNCODE;
        private string _ITEMNMBR;
        private short? _AutoAssignBin;
        private decimal? _UNITPRCE;
        private decimal? _XTNDPRCE;
        private decimal? _QUANTITY;
        private decimal? _MRKDNAMT;
        private decimal? _MRKDNPCT;
        private string _COMMNTID;
        private string _COMMENT_1;
        private string _COMMENT_2;
        private string _COMMENT_3;
        private string _COMMENT_4;
        private decimal? _UNITCOST;
        private string _PRCLEVEL;
        private string _ITEMDESC;
        private decimal? _TAXAMNT;
        private decimal? _QTYONHND;
        private decimal? _QTYRTRND;
        private decimal? _QTYINUSE;
        private decimal? _QTYINSVC;
        private decimal? _QTYDMGED;
        private short? _NONINVEN;
        private short? _LNITMSEQ;
        private short? _DROPSHIP;
        private decimal? _QTYTBAOR;
        private string _DOCID;
        private string _SALSTERR;
        private string _SLPRSNID;
        private string _ITMTSHID;
        private short? _IVITMTXB;
        private string _TAXSCHID;
        private string _PRSTADCD;
        private string _ShipToName;
        private string _CNTCPRSN;
        private string _ADDRESS1;
        private string _ADDRESS2;
        private string _ADDRESS3;
        private string _CITY;
        private string _STATE;
        private string _ZIPCODE;
        private string _COUNTRY;
        private string _PHONE1;
        private string _PHONE2;
        private string _PHONE3;
        private string _FAXNUMBR;
        //private short? _Print_Phone_NumberGB;
        private short? _EXCEPTIONALDEMAND;
        private DateTime? _ReqShipDate;
        private DateTime? _FUFILDAT;
        private DateTime? _ACTLSHIP;
        private string _SHIPMTHD;
        private string _INVINDX;
        private string _CSLSINDX;
        private string _SLSINDX;
        private string _MKDNINDX;
        private string _RTNSINDX;
        private string _INUSINDX;
        private string _INSRINDX;
        private string _DMGDINDX;
        private int? _AUTOALLOCATESERIAL;
        private int? _AUTOALLOCATELOT;
        private string _GPSFOINTEGRATIONID;
        private short? _INTEGRATIONSOURCE;
        private string _INTEGRATIONID;
        private short? _RequesterTrx;
        private decimal? _QTYCANCE;
        private decimal? _QTYFULFI;
        private short? _ALLOCATE;
        private short? _UpdateIfExists;
        private short? _RecreateDist;
        private decimal? _QUOTEQTYTOINV;
        private decimal? _TOTALQTY;
        private string _CMMTTEXT;
        private short? _KitCompMan;
        private int? _DEFPRICING;
        private int? _DEFEXTPRICE;
        private string _CURNCYID;
        private string _UOFM;
        private short? _IncludePromo;
        private short? _CKCreditLimit;
        private short? _QtyShrtOpt;

        /// <summary>
        /// 1=Quote; 
        /// 2=Order; 
        /// 3=Invoice;
        /// 4=Return;
        /// 5=Back order;
        /// 6=Fulfillment order
        /// </summary>
        [DataMember]
        public short SOPTYPE
        {
            get { return _SOPTYPE; }
            set { _SOPTYPE = value; }
        }

        /// <summary>
        /// Invoice number
        /// </summary>
        [DataMember]
        public string SOPNUMBE
        {
            get { return _SOPNUMBE; }
            set { _SOPNUMBE = value; }
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
        /// Invoice date
        /// </summary>
        [DataMember]
        public DateTime DOCDATE
        {
            get { return _DOCDATE; }
            set { _DOCDATE = value; }
        }

        /// <summary>
        /// User Date:
        /// Used to determine if a lot is expired., defaults to system date
        /// </summary>
        [DataMember]
        public DateTime USERDATE
        {
            get { return _USERDATE; }
            set { _USERDATE = value; }
        }

        /// <summary>
        /// Location code
        /// </summary>
        [DataMember]
        public string LOCNCODE
        {
            get { return _LOCNCODE; }
            set { _LOCNCODE = value; }
        }

        /// <summary>
        /// Item number 
        /// If you have a document with more than one taSopLineIvcInsert node, 
        /// use the values in the ITEMNMBR element to specify the sequence where each node appears in the document.
        /// </summary>
        [DataMember]
        public string ITEMNMBR
        {
            get { return _ITEMNMBR; }
            set { _ITEMNMBR = value; }
        }

        /// <summary>
        /// Auto assign bin will use either the SOFULFILLMENT or SORETURN bin
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? AutoAssignBin
        {
            get { return _AutoAssignBin; }
            set { _AutoAssignBin = value; }
        }

        /// <summary>
        /// Unit price for item
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? UNITPRCE
        {
            get { return _UNITPRCE; }
            set { _UNITPRCE = value; }
        }

        /// <summary>
        /// Extended price for line item
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? XTNDPRCE
        {
            get { return _XTNDPRCE; }
            set { _XTNDPRCE = value; }
        }

        /// <summary>
        /// Quote=Quantity to order; 
        /// Order and Bkorder=Quantity to invoice; 
        /// Invoice=Billed quantity;
        /// Return=Total quantity
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QUANTITY
        {
            get { return _QUANTITY; }
            set { _QUANTITY = value; }
        }

        /// <summary>
        /// Markdown amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MRKDNAMT
        {
            get { return _MRKDNAMT; }
            set { _MRKDNAMT = value; }
        }

        /// <summary>
        /// Markdown percent; if MRKDNPCT is utilized, in taSopHdrIvcInsert the element DEFPRICING must be set to 1 or error 67 will occur.
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MRKDNPCT
        {
            get { return _MRKDNPCT; }
            set { _MRKDNPCT = value; }
        }

        /// <summary>
        /// Comment ID
        /// </summary>
        [DataMember]
        public string COMMNTID
        {
            get { return _COMMNTID; }
            set { _COMMNTID = value; }
        }

        /// <summary>
        /// Comment 1
        /// </summary>
        [DataMember]
        public string COMMENT_1
        {
            get { return _COMMENT_1; }
            set { _COMMENT_1 = value; }
        }

        /// <summary>
        /// Comment 2
        /// </summary>
        [DataMember]
        public string COMMENT_2
        {
            get { return _COMMENT_2; }
            set { _COMMENT_2 = value; }
        }

        /// <summary>
        /// Comment 3
        /// </summary>
        [DataMember]
        public string COMMENT_3
        {
            get { return _COMMENT_3; }
            set { _COMMENT_3 = value; }
        }

        /// <summary>
        /// Comment 4
        /// </summary>
        [DataMember]
        public string COMMENT_4
        {
            get { return _COMMENT_4; }
            set { _COMMENT_4 = value; }
        }

        /// <summary>
        /// Unit cost 
        /// Used with non-inventory items or return type documents.
        /// If null, the default is pulled for inventory or 0 for non-inventory.
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? UNITCOST
        {
            get { return _UNITCOST; }
            set { _UNITCOST = value; }
        }

        /// <summary>
        /// Price level
        /// </summary>
        [DataMember]
        public string PRCLEVEL
        {
            get { return _PRCLEVEL; }
            set { _PRCLEVEL = value; }
        }

        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        public string ITEMDESC
        {
            get { return _ITEMDESC; }
            set { _ITEMDESC = value; }
        }
        /// <summary>
        /// Tax amount on line item without freight and miscellaneous tax
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TAXAMNT
        {
            get { return _TAXAMNT; }
            set { _TAXAMNT = value; }
        }

        /// <summary>
        /// Return quantity type: On hand
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYONHND
        {
            get { return _QTYONHND; }
            set { _QTYONHND = value; }
        }

        /// <summary>
        /// Return quantity type: Returned
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYRTRND
        {
            get { return _QTYRTRND; }
            set { _QTYRTRND = value; }
        }

        /// <summary>
        /// Return quantity type: In use
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYINUSE
        {
            get { return _QTYINUSE; }
            set { _QTYINUSE = value; }
        }

        /// <summary>
        /// Return quantity type: In service
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYINSVC
        {
            get { return _QTYINSVC; }
            set { _QTYINSVC = value; }
        }

        /// <summary>
        /// Return quantity type: Damaged
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYDMGED
        {
            get { return _QTYDMGED; }
            set { _QTYDMGED = value; }
        }

        /// <summary>
        /// Non-inventory:0=No; 1=Yes
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? NONINVEN
        {
            get { return _NONINVEN; }
            set { _NONINVEN = value; }
        }

        /// <summary>
        /// Line item sequence number; by default, the line item sequence number will be autoincremented by 16,384 for each SOP line if it is not passed in;
        /// if the value needs to be passed in, we recommend passing in a value of 16,384 for the first line and increment the value by 16,384 for each subsequent line 
        /// (that is, pass in a value of 16,384 for the first SOP line and then 32,768 for the second SOP line
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? LNITMSEQ
        {
            get { return _LNITMSEQ; }
            set { _LNITMSEQ = value; }
        }


        /// <summary>
        /// Drop ship flag 1=Drop ship
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DROPSHIP
        {
            get { return _DROPSHIP; }
            set { _DROPSHIP = value; }
        }

        /// <summary>
        /// Quantity to back order
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYTBAOR
        {
            get { return _QTYTBAOR; }
            set { _QTYTBAOR = value; }
        }

        /// <summary>
        /// Document ID; if left blank, line will autoallocate and fulfill
        /// </summary>
        [DataMember]
        public string DOCID
        {
            get { return _DOCID; }
            set { _DOCID = value; }
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
        /// Salesperson ID
        /// </summary>
        [DataMember]
        public string SLPRSNID
        {
            get { return _SLPRSNID; }
            set { _SLPRSNID = value; }
        }

        /// <summary>
        /// Item tax schedule ID; if user wants to pass in a blank schedule ID, '' (tick tick) must be passed in for ITMTSHID
        /// </summary>
        [DataMember]
        public string ITMTSHID
        {
            get { return _ITMTSHID; }
            set { _ITMTSHID = value; }
        }

        /// <summary>
        /// IV item taxable; user can change item tax option per line:
        /// 0=Default; 
        /// 1=Tax; 
        /// 2=Nontax; 
        /// 3=Based on customer
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? IVITMTXB
        {
            get { return _IVITMTXB; }
            set { _IVITMTXB = value; }
        }

        /// <summary>
        /// Delivery method tax schedule ID; can be used to override the default delivery method tax schedule; 
        /// if user wants to pass in a blank schedule ID, '' (tick tick) must be passed in for TAXSCHID
        /// </summary>
        [DataMember]
        public string TAXSCHID
        {
            get { return _TAXSCHID; }
            set { _TAXSCHID = value; }
        }

        /// <summary>
        /// Primary ship to address code
        /// </summary>
        [DataMember]
        public string PRSTADCD
        {
            get { return _PRSTADCD; }
            set { _PRSTADCD = value; }
        }

        /// <summary>
        /// Ship to name:The default gets the ship to name from the customer ship to address.
        /// </summary>
        [DataMember]
        public string ShipToName
        {
            get { return _ShipToName; }
            set { _ShipToName = value; }
        }

        /// <summary>
        /// Contact person
        /// </summary>
        [DataMember]
        public string CNTCPRSN
        {
            get { return _CNTCPRSN; }
            set { _CNTCPRSN = value; }
        }

        /// <summary>
        /// Customer address one per ship to line item
        /// </summary>
        [DataMember]
        public string ADDRESS1
        {
            get { return _ADDRESS1; }
            set { _ADDRESS1 = value; }
        }

        /// <summary>
        /// Customer address two per ship to line item
        /// </summary>
        [DataMember]
        public string ADDRESS2
        {
            get { return _ADDRESS2; }
            set { _ADDRESS2 = value; }
        }

        /// <summary>
        /// Customer address three per ship to line item
        /// </summary>
        [DataMember]
        public string ADDRESS3
        {
            get { return _ADDRESS3; }
            set { _ADDRESS3 = value; }
        }
        
        /// <summary>
        /// City per ship to line item
        /// </summary>
        [DataMember]
        public string CITY
        {
            get { return _CITY; }
            set { _CITY = value; }
        }

        /// <summary>
        /// State per ship to line item
        /// </summary>
        [DataMember]
        public string STATE
        {
            get { return _STATE; }
            set { _STATE = value; }
        }

        /// <summary>
        /// ZIP Code per ship to line item
        /// </summary>
        [DataMember]
        public string ZIPCODE
        {
            get { return _ZIPCODE; }
            set { _ZIPCODE = value; }
        }

        /// <summary>
        /// Country per ship to line item
        /// </summary>
        [DataMember]
        public string COUNTRY
        {
            get { return _COUNTRY; }
            set { _COUNTRY = value; }
        }

        /// <summary>
        /// Phone 1 per ship to line item
        /// </summary>
        [DataMember]
        public string PHONE1
        {
            get { return _PHONE1; }
            set { _PHONE1 = value; }
        }

        /// <summary>
        /// Phone 2 per ship to line item
        /// </summary>
        [DataMember]
        public string PHONE2
        {
            get { return _PHONE2; }
            set { _PHONE2 = value; }
        }

        /// <summary>
        /// Phone 3 per ship to line item
        /// </summary>
        [DataMember]
        public string PHONE3
        {
            get { return _PHONE3; }
            set { _PHONE3 = value; }
        }

        /// <summary>
        /// Fax per ship to line item
        /// </summary>
        [DataMember]
        public string FAXNUMBR
        {
            get { return _FAXNUMBR; }
            set { _FAXNUMBR = value; }
        }

        ///// <summary>
        ///// Print phone number:0=Do not print;1=Phone 1;2=Phone 2;3=Phone 3;4=Fax
        ///// </summary>
        //[DataMember]
        //[DefaultValue(0)]
        //public short? Print_Phone_NumberGB
        //{
        //    get { return _Print_Phone_NumberGB; }
        //    set { _Print_Phone_NumberGB = value; }
        //}
        
        /// <summary>
        /// Resource planning
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? EXCEPTIONALDEMAND
        {
            get { return _EXCEPTIONALDEMAND; }
            set { _EXCEPTIONALDEMAND = value; }
        }

        /// <summary>
        /// Requested ship date
        /// </summary>
        [DataMember]
        public DateTime? ReqShipDate
        {
            get { return _ReqShipDate; }
            set { _ReqShipDate = value; }
        }

        /// <summary>
        /// Fulfill date
        /// </summary>
        [DataMember]
        public DateTime? FUFILDAT
        {
            get { return _FUFILDAT; }
            set { _FUFILDAT = value; }
        }

        /// <summary>
        /// Actual ship date
        /// </summary>
        [DataMember]
        public DateTime? ACTLSHIP
        {
            get { return _ACTLSHIP; }
            set { _ACTLSHIP = value; }
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
        /// Inventory account number string
        /// </summary>
        [DataMember]
        public string INVINDX
        {
            get { return _INVINDX; }
            set { _INVINDX = value; }
        }

        /// <summary>
        /// Cost of goods sold account number string
        /// </summary>
        [DataMember]
        public string CSLSINDX
        {
            get { return _CSLSINDX; }
            set { _CSLSINDX = value; }
        }

        /// <summary>
        /// Sales account number string
        /// </summary>
        [DataMember]
        public string SLSINDX
        {
            get { return _SLSINDX; }
            set { _SLSINDX = value; }
        }

        /// <summary>
        /// Markdowns account number string
        /// </summary>
        [DataMember]
        public string MKDNINDX
        {
            get { return _MKDNINDX; }
            set { _MKDNINDX = value; }
        }

        /// <summary>
        /// Returns account number string
        /// </summary>
        [DataMember]
        public string RTNSINDX
        {
            get { return _RTNSINDX; }
            set { _RTNSINDX = value; }
        }

        /// <summary>
        /// In use account number string
        /// </summary>
        [DataMember]
        public string INUSINDX
        {
            get { return _INUSINDX; }
            set { _INUSINDX = value; }
        }

        /// <summary>
        /// In service account number string
        /// </summary>
        [DataMember]
        public string INSRINDX
        {
            get { return _INSRINDX; }
            set { _INSRINDX = value; }
        }

        /// <summary>
        /// Damaged account number string
        /// </summary>
        [DataMember]
        public string DMGDINDX
        {
            get { return _DMGDINDX; }
            set { _DMGDINDX = value; }
        }

        /// <summary>
        /// Autoallocate serial numbers on the fly: 0=Auto; 1=Manual; 2=Mixed
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? AUTOALLOCATESERIAL
        {
            get { return _AUTOALLOCATESERIAL; }
            set { _AUTOALLOCATESERIAL = value; }
        }

        /// <summary>
        /// Autoallocate lot numbers on the fly:
        /// 0=Auto; 
        /// 1=Manual; 
        /// 2=Mixed
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? AUTOALLOCATELOT
        {
            get { return _AUTOALLOCATELOT; }
            set { _AUTOALLOCATELOT = value; }
        }

        /// <summary>
        /// Front office integration ID
        /// </summary>
        [DataMember]
        public string GPSFOINTEGRATIONID
        {
            get { return _GPSFOINTEGRATIONID; }
            set { _GPSFOINTEGRATIONID = value; }
        }

        /// <summary>
        /// Integration source
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? INTEGRATIONSOURCE
        {
            get { return _INTEGRATIONSOURCE; }
            set { _INTEGRATIONSOURCE = value;}
        }

        /// <summary>
        /// Integration ID
        /// </summary>
        [DataMember]
        public string INTEGRATIONID
        {
            get { return _INTEGRATIONID; }
            set { _INTEGRATIONID = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False; 
        /// 1=True (if True, it populates requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get { return _RequesterTrx; }
            set { _RequesterTrx = value; }
        }

        /// <summary>
        /// Quantity canceled; will subtract from the QUANTITY passed in
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QTYCANCE
        {
            get { return _QTYCANCE; }
            set { _QTYCANCE = value; }
        }

        /// <summary>
        /// Quantity fulfilled--if set to a value other than null, that quantity value will be used
        /// </summary>
        [DataMember]
        public decimal? QTYFULFI
        {
            get { return _QTYFULFI; }
            set { _QTYFULFI = value; }
        }

        /// <summary>
        /// Allocates quantities; 
        /// 0=Use DOCID default; 
        /// 1=Allocate quantities
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? ALLOCATE
        {
            get { return _ALLOCATE; }
            set { _ALLOCATE = value; }
        }

        /// <summary>
        /// Used to add or modify existing documents; 1=Add/modify--entire line will need to be resent
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? UpdateIfExists
        {
            get { return _UpdateIfExists; }
            set { _UpdateIfExists = value; }
        }

        /// <summary>
        /// Used only if UpdateIfExists=1;
        /// 0=Do not re-create distributions;
        /// 1=Re-create distributions
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RecreateDist
        {
            get { return _RecreateDist; }
            set { _RecreateDist = value; }
        }

        /// <summary>
        /// Quote quantity to invoice; added to QUANTITY and QTYCANCE for total quote amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? QUOTEQTYTOINV
        {
            get { return _QUOTEQTYTOINV; }
            set { _QUOTEQTYTOINV = value; }
        }

        /// <summary>
        /// Total line quantity; used if total line quantity exceeds individual quantity amounts being sent in
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TOTALQTY
        {
            get { return _TOTALQTY; }
            set { _TOTALQTY = value; }
        }

        /// <summary>
        /// Comment text; used only if COMMENT_1 through COMMENT_4 are not being used
        /// </summary>
        [DataMember]
        public string CMMTTEXT
        {
            get { return _CMMTTEXT; }
            set { _CMMTTEXT = value; }
        }

        /// <summary>
        /// Manually passing kit components:
        /// 0=False; 
        /// 1=True (if 1, LNITMSEQ is required)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? KitCompMan
        {
            get { return _KitCompMan; }
            set { _KitCompMan = value; }
        }

        /// <summary>
        /// 1=Unit price and extended price will use default
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? DEFPRICING
        {
            get { return _DEFPRICING; }
            set { _DEFPRICING = value; }
        }

        /// <summary>
        /// Extended price will use the default based on the unit price and quantity passed in
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? DEFEXTPRICE
        {
            get { return _DEFEXTPRICE; }
            set { _DEFEXTPRICE = value; }
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
        /// Unit of measure
        /// </summary>
        [DataMember]
        public string UOFM
        {
            get { return _UOFM; }
            set { _UOFM = value; }
        }

        /// <summary>
        /// Include extended pricing promotion, including free items
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? IncludePromo
        {
            get { return _IncludePromo; }
            set { _IncludePromo = value; }
        }

        /// <summary>
        /// Check credit limit at line level:
        /// 0=Do not check credit limit;
        /// 1=Check limit (users still have the ability to check credit limit at the header level)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CKCreditLimit
        {
            get { return _CKCreditLimit; }
            set { _CKCreditLimit = value; }
        }

        /// <summary>
        /// Quantity shortage option: 
        /// 1=Sell balance;
        /// 2=Override shortage; 
        /// 3=Back Order all; 
        /// 4=Back Order balance;
        /// 5=Cancel all;
        /// 6=Cancel balance
        /// More information available in SOP Transaction General Information.
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? QtyShrtOpt
        {
            get { return _QtyShrtOpt; }
            set { _QtyShrtOpt = value; }
        }

    }
}
