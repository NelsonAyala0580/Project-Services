using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PMClass
{
    [DataContract]
    public class PMVendor
    {
        private string _VENDORID;
        private string _VENDNAME;
        private string _VENDSHNM;
        private string _VNDCHKNM;
        private short? _HOLD;
        private short? _VENDSTTS;
        private string _VNDCLSID;
        private string _VADDCDPR;
        private string _VNDCNTCT;
        private string _ADDRESS1;
        private string _ADDRESS2;
        private string _ADDRESS3;
        private string _CITY;
        private string _STATE;
        private string _ZIPCODE;
        private string _CCode;
        private string _COUNTRY;
        private string _PHNUMBR1;
        private string _PHNUMBR2;
        private string _PHNUMBR3;
        private string _FAXNUMBR;
        private string _TAXSCHID;
        private string _SHIPMTHD;
        private string _UPSZONE;
        private string _VADCDPAD;
        private string _VADCDTRO;
        private string _VADCDSFR;
        private string _ACNMVNDR;
        private string _COMMENT1;
        private string _COMMENT2;
        private string _NOTETEXT;
        private string _CURNCYID;
        private string _RATETPID;
        private string _PYMTRMID;
        private short? _DISGRPER;
        private short? _DUEGRPER;
        private string _PYMNTPRI;
        private decimal? _MINORDER;
        private decimal? _TRDDISCT;
        private string _TXIDNMBR;
        private string _TXRGNNUM;
        private string _CHEKBKID;
        private string _USERDEF1;
        private string _USERDEF2;
        private short? _TEN99TYPE;
        private short? _TEN99BOXNUMBER;
        private short? _FREEONBOARD;
        private short? _USERLANG;
        private short? _MINPYTYP;
        private decimal? _MINPYDLR;
        private decimal? _MINPYPCT;
        private short? _MXIAFVND;
        private decimal? _MAXINDLR;
        private short? _CREDTLMT;
        private decimal? _CRLMTDLR;
        private short? _WRITEOFF;
        private decimal? _MXWOFAMT;
        private short? _Revalue_Vendor;
        private short? _Post_Results_To;
        private short? _KPCALHST;
        private short? _KPERHIST;
        private short? _KPTRXHST;
        private short? _KGLDSTHS;
        private short? _PTCSHACF;
        private string _PMCSHACTNUMST;
        private string _PMAPACTNUMST;
        private string _PMDAVACTNUMST;
        private string _PMDTKACTNUMST;
        private string _PMFINACTNUMST;
        private string _PMPRCHACTNUMST;
        private string _PMTDSCACTNUMST;
        private string _PMMSCHACTNUMST;
        private string _PMFRTACTNUMST;
        private string _PMTAXACTNUMST;
        private string _PMWRTACTNUMST;
        private string _ACPURACTNUMST;
        private string _PURPVACTNUMST;
        private short? _UseVendorClass;
        private short? _CreateAddress;
        private short? _UpdateIfExists;
        private short? _RequesterTrx;


        /// <summary>
        /// Vendor ID
        /// </summary>
        [DataMember]
        [Description("Vendor ID")]
        public string VENDORID
        {
            get { return _VENDORID; }
            set { _VENDORID = value; }
        }

        /// <summary>
        /// Vendor name
        /// </summary>
        [DataMember]
        [Description("Vendor name")]
        public string VENDNAME
        {
            get { return _VENDNAME; }
            set { _VENDNAME = value; }
        }

        /// <summary>
        /// Vendor short name
        /// </summary>
        [DataMember]
        [Description("Vendor short name")]
        public string VENDSHNM
        {
            get { return _VENDSHNM; }
            set { _VENDSHNM = value; }
        }

        /// <summary>
        /// Vendor check name
        /// </summary>
        [DataMember]
        public string VNDCHKNM
        {
            get { return _VNDCHKNM; }
            set { _VNDCHKNM = value; }
        }

        /// <summary>
        /// Hold:
        /// 0=Not on hold;
        /// 1=Hold
        /// Default is zero on new record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? HOLD
        {
            get { return _HOLD; }
            set { _HOLD = value; }
        }

        /// <summary>
        /// Vendor status:
        /// 1=Active;
        /// 2=Inactive;
        /// 3=Temporary
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? VENDSTTS
        {
            get { return _VENDSTTS; }
            set { _VENDSTTS = value; }
        }

        /// <summary>
        /// Vendor class ID
        /// </summary>
        [DataMember]
        public string VNDCLSID
        {
            get { return _VNDCLSID; }
            set { _VNDCLSID = value; }
        }

        /// <summary>
        /// Primary vendor address ID
        /// </summary>
        [DataMember]
        public string VADDCDPR
        {
            get { return _VADDCDPR; }
            set { _VADDCDPR = value; }
        }


        /// <summary>
        /// Vendor contact
        /// </summary>
        [DataMember]
        public string VNDCNTCT
        {
            get { return _VNDCNTCT; }
            set { _VNDCNTCT = value; }
        }

        /// <summary>
        /// Address 1
        /// </summary>
        [DataMember]
        public string ADDRESS1
        {
            get { return _ADDRESS1; }
            set { _ADDRESS1 = value; }
        }

        /// <summary>
        /// Address 2
        /// </summary>
        [DataMember]
        public string ADDRESS2
        {
            get { return _ADDRESS2; }
            set { _ADDRESS2 = value; }
        }

        /// <summary>
        /// Address 3
        /// </summary>
        [DataMember]
        public string ADDRESS3
        {
            get { return _ADDRESS3; }
            set { _ADDRESS3 = value; }
        }

        /// <summary>
        /// City
        /// </summary>
        [DataMember]
        public string CITY
        {
            get { return _CITY; }
            set { _CITY = value; }
        }

        /// <summary>
        /// State
        /// </summary>
        [DataMember]
        public string STATE
        {
            get { return _STATE; }
            set { _STATE = value; }
        }

        /// <summary>
        /// Zip Code
        /// </summary>
        [DataMember]
        public string ZIPCODE
        {
            get { return _ZIPCODE; }
            set { _ZIPCODE = value; }
        }

        /// <summary>
        /// Country code
        /// </summary>
        [DataMember]
        public string CCode
        {
            get { return _CCode; }
            set { _CCode = value; }
        }

        /// <summary>
        /// Country
        /// </summary>
        [DataMember]
        public string COUNTRY
        {
            get { return _COUNTRY; }
            set { _COUNTRY = value; }
        }

        /// <summary>
        /// Phone 1
        /// </summary>
        [DataMember]
        public string PHNUMBR1
        {
            get { return _PHNUMBR1; }
            set { _PHNUMBR1 = value; }
        }

        /// <summary>
        /// Phone 2
        /// </summary>
        [DataMember]
        public string PHNUMBR2
        {
            get { return _PHNUMBR2; }
            set { _PHNUMBR2 = value; }
        }

        /// <summary>
        /// Phone 3
        /// </summary>
        [DataMember]
        public string PHNUMBR3
        {
            get { return _PHNUMBR3; }
            set { _PHNUMBR3 = value; }
        }

        /// <summary>
        /// Fax number
        /// </summary>
        [DataMember]
        public string FAXNUMBR
        {
            get { return _FAXNUMBR; }
            set { _FAXNUMBR = value; }
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
        /// Shipping method
        /// </summary>
        [DataMember]
        public string SHIPMTHD
        {
            get { return _SHIPMTHD; }
            set { _SHIPMTHD = value; }
        }

        /// <summary>
        /// UPS zone
        /// </summary>
        [DataMember]
        public string UPSZONE
        {
            get { return _UPSZONE; }
            set { _UPSZONE = value; }
        }

        /// <summary>
        /// Vendor purchase address ID
        /// </summary>
        [DataMember]
        public string VADCDPAD
        {
            get { return _VADCDPAD; }
            set { _VADCDPAD = value; }
        }

        /// <summary>
        /// Vendor remit to address ID
        /// </summary>
        [DataMember]
        public string VADCDTRO
        {
            get { return _VADCDTRO; }
            set { _VADCDTRO = value; }
        }

        /// <summary>
        /// Vendor ship from address ID
        /// </summary>
        [DataMember]
        public string VADCDSFR
        {
            get { return _VADCDSFR; }
            set { _VADCDSFR = value; }
        }

        /// <summary>
        /// Vendor account number
        /// </summary>
        [DataMember]
        public string ACNMVNDR
        {
            get { return _ACNMVNDR; }
            set { _ACNMVNDR = value; }
        }

        /// <summary>
        /// Comment 1
        /// </summary>
        [DataMember]
        public string COMMENT1
        {
            get { return _COMMENT1; }
            set { _COMMENT1 = value; }
        }

        /// <summary>
        /// Comment 2
        /// </summary>
        [DataMember]
        public string COMMENT2
        {
            get { return _COMMENT2; }
            set { _COMMENT2 = value; }
        }

        /// <summary>
        /// Note text
        /// </summary>
        [DataMember]
        public string NOTETEXT
        {
            get { return _NOTETEXT; }
            set { _NOTETEXT = value; }
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
        /// Rate type ID
        /// </summary>
        [DataMember]
        public string RATETPID
        {
            get { return _RATETPID; }
            set { _RATETPID = value; }
        }

        /// <summary>
        /// Payment terms ID
        /// </summary>
        [DataMember]
        public string PYMTRMID
        {
            get { return _PYMTRMID; }
            set { _PYMTRMID = value; }
        }

        /// <summary>
        /// Discount grace period; max value is 99
        /// </summary>
        [DataMember]
        public short? DISGRPER
        {
            get { return _DISGRPER; }
            set { _DISGRPER = value; }
        }

        /// <summary>
        /// Due date grace period; max value is 99
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DUEGRPER
        {
            get { return _DUEGRPER; }
            set { _DUEGRPER = value; }
        }

        /// <summary>
        /// Payment priority
        /// </summary>
        [DataMember]
        public string PYMNTPRI
        {
            get { return _PYMNTPRI; }
            set { _PYMNTPRI = value; }
        }

        /// <summary>
        /// Minimum order
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MINORDER
        {
            get { return _MINORDER; }
            set { _MINORDER = value; }
        }

        /// <summary>
        /// Trade discount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TRDDISCT
        {
            get { return _TRDDISCT; }
            set { _TRDDISCT = value; }
        }

        /// <summary>
        /// Tax ID number
        /// </summary>
        [DataMember]
        public string TXIDNMBR
        {
            get { return _TXIDNMBR; }
            set { _TXIDNMBR = value; }
        }

        /// <summary>
        /// Tax registration number (NRC en El Salvador)
        /// </summary>
        [DataMember]
        public string TXRGNNUM
        {
            get { return _TXRGNNUM; }
            set { _TXRGNNUM = value; }
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
        /// User-defined 1
        /// </summary>
        [DataMember]
        public string USERDEF1
        {
            get { return _USERDEF1; }
            set { _USERDEF1 = value; }
        }

        /// <summary>
        /// User-defined 2
        /// </summary>
        [DataMember]
        public string USERDEF2
        {
            get { return _USERDEF2; }
            set { _USERDEF2 = value; }
        }

        /// <summary>
        /// Tax 1099 type:
        /// 1=Not a 1099 vendor;
        /// 2=Dividend;
        /// 3=Interest;
        /// 4=Miscellaneous
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? TEN99TYPE
        {
            get { return _TEN99TYPE; }
            set { _TEN99TYPE = value; }
        }

        /// <summary>
        /// Tax 1099 box number
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? TEN99BOXNUMBER
        {
            get { return _TEN99BOXNUMBER; }
            set { _TEN99BOXNUMBER = value; }
        }

        /// <summary>
        /// Free on board:
        /// 1=None;
        /// 2=Origin;
        /// 3=Destination
        /// Default is 1 on new order
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? FREEONBOARD
        {
            get { return _FREEONBOARD; }
            set { _FREEONBOARD = value; }
        }

        /// <summary>
        /// User language; default is 0 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? USERLANG
        {
            get { return _USERLANG; }
            set { _USERLANG = value; }
        }

        /// <summary>
        /// Minimum payment type: 0=No minimum;
        /// 1=Percent;
        /// 2=Amount
        /// Default is zero on new record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? MINPYTYP
        {
            get { return _MINPYTYP; }
            set { _MINPYTYP = value; }
        }

        /// <summary>
        /// Minimum payment dollar amount; used if MINPYTYP=2
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MINPYDLR
        {
            get { return _MINPYDLR; }
            set { _MINPYDLR = value; }
        }

        /// <summary>
        /// Minimum payment percent; used if MINPYTYP=1
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MINPYPCT
        {
            get { return _MINPYPCT; }
            set { _MINPYPCT = value; }
        }

        /// <summary>
        /// Maximum invoice amount type:
        /// 0=No maximum;
        /// 1=Amount
        /// Default is zero on new record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? MXIAFVND
        {
            get { return _MXIAFVND; }
            set { _MXIAFVND = value; }
        }

        /// <summary>
        /// Maximum invoice dollar amount; used if MXIAFVND=1
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MAXINDLR
        {
            get { return _MAXINDLR; }
            set { _MAXINDLR = value; }
        }

        /// <summary>
        /// Credit limit type:
        /// 0=No credit;
        /// 1=Unlimited;
        /// 2=Amount
        /// Default is zero on new record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CREDTLMT
        {
            get { return _CREDTLMT; }
            set { _CREDTLMT = value; }
        }

        /// <summary>
        /// Credit limit dollar amount; used if CREDTLMT=2
        /// </summary>
        [DataMember]
        public decimal? CRLMTDLR
        {
            get { return _CRLMTDLR; }
            set { _CRLMTDLR = value; }
        }

        /// <summary>
        /// Write-off type:
        /// 0=Not allowed;
        /// 1=Unlimited;
        /// 2=Maximum
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? WRITEOFF
        {
            get { return _WRITEOFF; }
            set { _WRITEOFF = value; }
        }

        /// <summary>
        /// Maximum write-off amount; used if WRITEOFF=2
        /// </summary>
        [DataMember]
        public decimal? MXWOFAMT
        {
            get { return _MXWOFAMT; }
            set { _MXWOFAMT = value; }
        }

        /// <summary>
        /// Revalue vendor:
        /// 0=Do not revalue;
        /// 1=Revalue
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? Revalue_Vendor
        {
            get { return _Revalue_Vendor; }
            set { _Revalue_Vendor = value; }
        }

        /// <summary>
        /// Post results to:
        /// 0=Payable/Discount account;
        /// 1=Purchasing offset account
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? Post_Results_To
        {
            get { return _Post_Results_To; }
            set { _Post_Results_To = value; }
        }

        /// <summary>
        /// Maintain history--calendar year:
        /// 0=Do not maintain;
        /// 1=Maintain
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPCALHST
        {
            get { return _KPCALHST; }
            set { _KPCALHST = value; }
        }

        /// <summary>
        /// Maintain history--fiscal year:
        /// 0=Do not maintain;
        /// 1=Maintain
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPERHIST
        {
            get { return _KPERHIST; }
            set { _KPERHIST = value; }
        }

        /// <summary>
        /// Maintain history--transaction:
        /// 0=Do not maintain;
        /// 1=Maintain
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPTRXHST
        {
            get { return _KPTRXHST; }
            set { _KPTRXHST = value; }
        }

        /// <summary>
        /// Maintain history--distribution:
        /// 0=Do not maintain;
        /// 1=Maintain
        /// Default is 1 on new record
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KGLDSTHS
        {
            get { return _KGLDSTHS; }
            set { _KGLDSTHS = value; }
        }

        /// <summary>
        /// Use cash account from:
        /// 0=Checkbook;
        /// 1=Vendor
        /// Default is zero on new record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? PTCSHACF
        {
            get { return _PTCSHACF; }
            set { _PTCSHACF = value; }
        }

        /// <summary>
        /// Cash account; only valid if PTCSHACF=1
        /// </summary>
        [DataMember]
        public string PMCSHACTNUMST
        {
            get { return _PMCSHACTNUMST; }
            set { _PMCSHACTNUMST = value; }
        }
        /// <summary>
        /// Accounts payable account
        /// </summary>
        [DataMember]
        public string PMAPACTNUMST
        {
            get { return _PMAPACTNUMST; }
            set { _PMAPACTNUMST = value; }
        }

        /// <summary>
        /// Terms discount available account
        /// </summary>
        [DataMember]
        public string PMDAVACTNUMST
        {
            get { return _PMDAVACTNUMST; }
            set { _PMDAVACTNUMST = value; }
        }

        /// <summary>
        /// Terms discount taken account
        /// </summary>
        [DataMember]
        public string PMDTKACTNUMST
        {
            get { return _PMDTKACTNUMST; }
            set { _PMDTKACTNUMST = value; }
        }

        /// <summary>
        /// Finance charges account
        /// </summary>
        [DataMember]
        public string PMFINACTNUMST
        {
            get { return _PMFINACTNUMST; }
            set { _PMFINACTNUMST = value; }
        }

        /// <summary>
        /// Purchases account
        /// </summary>
        [DataMember]
        public string PMPRCHACTNUMST
        {
            get { return _PMPRCHACTNUMST; }
            set { _PMPRCHACTNUMST = value; }
        }

        /// <summary>
        /// Trade discount account
        /// </summary>
        [DataMember]
        public string PMTDSCACTNUMST
        {
            get { return _PMTDSCACTNUMST; }
            set { _PMTDSCACTNUMST = value; }
        }

        /// <summary>
        /// Miscellaneous account
        /// </summary>
        [DataMember]
        public string PMMSCHACTNUMST
        {
            get { return _PMMSCHACTNUMST; }
            set { _PMMSCHACTNUMST = value; }
        }

        /// <summary>
        /// Freight account
        /// </summary>
        [DataMember]
        public string PMFRTACTNUMST
        {
            get { return _PMFRTACTNUMST; }
            set { _PMFRTACTNUMST = value; }
        }

        /// <summary>
        /// Tax account
        /// </summary>
        [DataMember]
        public string PMTAXACTNUMST
        {
            get { return _PMTAXACTNUMST; }
            set { _PMTAXACTNUMST = value; }
        }

        /// <summary>
        /// Write-off account
        /// </summary>
        [DataMember]
        public string PMWRTACTNUMST
        {
            get { return _PMWRTACTNUMST; }
            set { _PMWRTACTNUMST = value; }
        }

        /// <summary>
        /// Accrued purchases account
        /// </summary>
        [DataMember]
        public string ACPURACTNUMST
        {
            get { return _ACPURACTNUMST; }
            set { _ACPURACTNUMST = value; }
        }

        /// <summary>
        /// Purchase price variance account
        /// </summary>
        [DataMember]
        public string PURPVACTNUMST
        {
            get { return _PURPVACTNUMST; }
            set { _PURPVACTNUMST = value; }
        }

        /// <summary>
        /// Flag to have class setting roll down to elements that not passed in; uses the VNDCLSID class
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? UseVendorClass
        {
            get { return _UseVendorClass; }
            set { _UseVendorClass = value; }
        }

        /// <summary>
        /// Flag to allow a primary address code to be created on the fly:
        /// 0=Do not create address code;
        /// 1=Create address code
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? CreateAddress
        {
            get { return _CreateAddress; }
            set { _CreateAddress = value; }
        }

        /// <summary>
        /// Flag to allow vendor data to be updated if it exists:
        /// 0=Do not update;
        /// 1=Update if exists;
        /// 2=Create if record does not exist and exits without error if record does exist
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? UpdateIfExists
        {
            get { return _UpdateIfExists; }
            set { _UpdateIfExists = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False;1=True(if True, it populates the requester shadow table)
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