using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;

namespace RMClass
{
    [DataContract]
    public class RMCustomerClass
    {
        private string _CLASSID;
        private string _CLASDSCR;
        private short? _CRLMTTYP;
        private decimal? _CRLMTAMT;
        private short? _CRLMTPER;
        private decimal? _CRLMTPAM;
        private short? _DEFLTCLS;
        private short? _BALNCTYP;
        private string _CHEKBKID;
        private string _TAXSCHID;
        private string _SHIPMTHD;
        private string _PYMTRMID;
        private short? _CUSTDISC;
        private short? _MINPYTYP;
        private decimal? _MINPYDLR;
        private short? _MINPYPCT;
        private short? _MXWOFTYP;
        private decimal? _MXWROFAM;
        private short? _FNCHATYP;
        private decimal? _FINCHDLR;
        private short? _FNCHPCNT;
        private string _PRCLEVEL;
        private string _CURNCYID;
        private string _RATETPID;
        private short? _DEFCACTY;
        private string _CASHACCT;
        private string _ACCTRECACCT;
        private string _SALESACCT;
        private string _COSTOFSALESACCT;
        private string _IVACCT;
        private string _TERMDISCTAKENACCT;
        private string _TERMDISCAVAILACCT;
        private string _FINCHRGACCT;
        private string _WRITEOFFACCT;
        private string _SALESORDERRETACCT;
        private string _SALSTERR;
        private string _SLPRSNID;
        private short? _STMTCYCL;
        private short? _KPCALHST;
        private short? _KPDSTHST;
        private short? _KPERHIST;
        private short? _KPTRXHST;
        private short? _DISGRPER;
        private short? _DUEGRPER;
        private short? _Revalue_Customer;
        private short? _Post_Results_To;
        private short? _ORDERFULFILLDEFAULT;
        private short? _CUSTPRIORITY;
        private string _RMOvrpymtWrtoffAcct;
        private short? _RequesterTrx;


        /// <summary>
        /// Class ID
        /// </summary>
        [DataMember]
        public string CLASSID
        {
            get { return _CLASSID; }
            set { _CLASSID = value; }
        }

        /// <summary>
        /// Class description
        /// </summary>
        [DataMember]
        public string CLASDSCR
        {
            get { return _CLASDSCR; }
            set { _CLASDSCR = value; }
        }

        /// <summary>
        /// Credit limit type: 
        /// 0=No credit; 
        /// 1=Unlimited; 
        /// 2=Amount        
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CRLMTTYP
        {
            get { return _CRLMTTYP; }
            set { _CRLMTTYP = value; }
        }

        /// <summary>
        /// Credit amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CRLMTAMT
        {
            get { return _CRLMTAMT; }
            set { _CRLMTAMT = value; }
        }

        /// <summary>
        /// Credit limit period
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CRLMTPER
        {
            get { return _CRLMTPER; }
            set { _CRLMTPER = value; }
        }

        /// <summary>
        /// Credit limit period amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CRLMTPAM
        {
            get { return _CRLMTPAM; }
            set { _CRLMTPAM = value; }
        }

        /// <summary>
        /// Default class
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DEFLTCLS
        {
            get { return _DEFLTCLS; }
            set { _DEFLTCLS = value; }
        }

        /// <summary>
        /// Balance type: 
        /// 0=Open item; 
        /// 1=Balance forward
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? BALNCTYP
        {
            get { return _BALNCTYP; }
            set { _BALNCTYP = value; }
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
        /// Payment term ID
        /// </summary>
        [DataMember]
        public string PYMTRMID
        {
            get { return _PYMTRMID; }
            set { _PYMTRMID = value; }
        }

        /// <summary>
        /// Customer discount/trade discount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CUSTDISC
        {
            get { return _CUSTDISC; }
            set { _CUSTDISC = value; }
        }

        /// <summary>
        /// Minimum payment type:
        /// 0=No minimum; 
        /// 1=Percent; 
        /// 2=Amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? MINPYTYP
        {
            get { return _MINPYTYP; }
            set { _MINPYTYP = value; }
        }

        /// <summary>
        /// Minimum payment dollar
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MINPYDLR
        {
            get { return _MINPYDLR; }
            set { _MINPYDLR = value; }
        }

        /// <summary>
        /// Minimum payment percent
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? MINPYPCT
        {
            get { return _MINPYPCT; }
            set { _MINPYPCT = value; }
        }

        /// <summary>
        /// Maximum write-off type: 
        /// 0=Not allowed; 
        /// 1=Unlimited; 
        /// 2=Maximum
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? MXWOFTYP
        {
            get { return _MXWOFTYP; }
            set { _MXWOFTYP = value; }
        }

        /// <summary>
        /// Maximum write-off amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MXWROFAM
        {
            get { return _MXWROFAM; }
            set { _MXWROFAM = value; }
        }

        /// <summary>
        /// Finance charge amount type: 
        /// 0=None; 
        /// 1=Percent; 
        /// 2=Amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? FNCHATYP
        {
            get { return _FNCHATYP; }
            set { _FNCHATYP = value; }
        }

        /// <summary>
        /// Finance charge dollar
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FINCHDLR
        {
            get { return _FINCHDLR; }
            set { _FINCHDLR = value; }
        }

        /// <summary>
        /// Finance charge percent
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? FNCHPCNT
        {
            get { return _FNCHPCNT; }
            set { _FNCHPCNT = value; }
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
        /// Currency ID
        /// </summary>
        [DataMember]
        public string CURNCYID
        {
            get { return _CURNCYID; }
            set { _CURNCYID = value; }
        }

        /// <summary>
        /// Rate ID
        /// </summary>
        [DataMember]
        public string RATETPID
        {
            get { return _RATETPID; }
            set { _RATETPID = value; }
        }
        /// <summary>
        /// Cash account from: 
        /// 0=Checkbook; 
        /// 1=Customer
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DEFCACTY
        {
            get { return _DEFCACTY; }
            set { _DEFCACTY = value; }
        }

        /// <summary>
        /// Cash account
        /// </summary>
        [DataMember]
        public string CASHACCT
        {
            get { return _CASHACCT; }
            set { _CASHACCT = value; }
        }

        /// <summary>
        /// Account Receivable account
        /// </summary>
        [DataMember]
        public string ACCTRECACCT
        {
            get { return _ACCTRECACCT; }
            set { _ACCTRECACCT = value;}
        }

        /// <summary>
        /// Sales account
        /// </summary>
        [DataMember]
        public string SALESACCT
        {
            get { return _SALESACCT; }
            set { _SALESACCT = value; }
        }

        /// <summary>
        /// Cost of sales account
        /// </summary>
        [DataMember]
        public string COSTOFSALESACCT
        {
            get { return _COSTOFSALESACCT; }
            set { _COSTOFSALESACCT = value; }
        }

        /// <summary>
        /// Inventory account
        /// </summary>
        [DataMember]
        public string IVACCT
        {
            get { return _IVACCT; }
            set { _IVACCT = value; }
        }

        /// <summary>
        /// Terms discount taken account
        /// </summary>
        [DataMember]
        public string TERMDISCTAKENACCT
        {
            get { return _TERMDISCTAKENACCT; }
            set { _TERMDISCTAKENACCT = value; }
        }

        /// <summary>
        /// Terms discount available account
        /// </summary>
        [DataMember]
        public string TERMDISCAVAILACCT
        {
            get { return _TERMDISCAVAILACCT; }
            set { _TERMDISCAVAILACCT = value; }
        }

        /// <summary>
        /// Finance charges account
        /// </summary>
        [DataMember]
        public string FINCHRGACCT
        {
            get { return _FINCHRGACCT; }
            set { _FINCHRGACCT = value; }
        }

        /// <summary>
        /// Write-off account
        /// </summary>
        [DataMember]
        public string WRITEOFFACCT
        {
            get { return _WRITEOFFACCT; }
            set { _WRITEOFFACCT = value; }
        }

        /// <summary>
        /// Sales order returns account
        /// </summary>
        [DataMember]
        public string SALESORDERRETACCT
        {
            get { return _SALESORDERRETACCT; }
            set { _SALESORDERRETACCT = value; }
        }

        /// <summary>
        /// Sales territory
        /// </summary>
        [DataMember]
        public string SALSTERR
        {
            get { return _SALSTERR; }
            set { _SALSTERR = value;  }
        }

        /// <summary>
        /// Sales person ID
        /// </summary>
        [DataMember]
        public string SLPRSNID
        {
            get { return _SLPRSNID; }
            set { _SLPRSNID = value; }
        }

        /// <summary>
        /// Statement cycle: 
        /// 1=No statement; 
        /// 2=Weekly; 
        /// 3=Biweekly; 
        /// 4=Semimonthly; 
        /// 5=Monthly; 
        /// 6=Bimonthly; 
        /// 7=Quarterly
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? STMTCYCL
        {
            get { return _STMTCYCL; }
            set { _STMTCYCL = value; }
        }

        /// <summary>
        /// Keep calendar history:
        /// =False; 
        /// 1=True
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPCALHST
        {
            get { return _KPCALHST; }
            set { _KPCALHST = value; }
        }

        /// <summary>
        /// Keep distribution history:
        /// 0=False; 
        /// 1=True
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPDSTHST
        {
            get { return _KPDSTHST; }
            set { _KPDSTHST = value; }
        }


        /// <summary>
        /// Keep period history: 
        /// 0=False; 
        /// 1=True
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPERHIST
        {
            get { return _KPERHIST; }
            set { _KPERHIST = value; }
        }

        /// <summary>
        /// Keep transaction history:
        /// 0=False; 
        /// 1=True
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? KPTRXHST
        {
            get { return _KPTRXHST; }
            set { _KPTRXHST = value; }
        }

        /// <summary>
        /// Discount grace period
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DISGRPER
        {
            get { return _DISGRPER; }
            set { _DISGRPER = value; }
        }

        /// <summary>
        /// Due date of grace period
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? DUEGRPER
        {
            get { return _DUEGRPER; }
            set { _DUEGRPER = value; }
        }

        /// <summary>
        /// Revalue customer: 
        /// 0=False; 
        /// 1=True
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? Revalue_Customer
        {
            get { return _Revalue_Customer; }
            set { _Revalue_Customer = value; }
        }

        /// <summary>
        /// Post results to: 0=Receivables/discount account 1=Sales offset account
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? Post_Results_To
        {
            get { return _Post_Results_To; }
            set { _Post_Results_To = value; }
        }

        /// <summary>
        /// Order fulfillment shortage default:1=None; 2=Back order remaining; 3=Cancel remaining
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? ORDERFULFILLDEFAULT
        {
            get { return _ORDERFULFILLDEFAULT; }
            set { _ORDERFULFILLDEFAULT = value; }
        }

        /// <summary>
        /// Customer priority; valid input values are 1 (none) to 100
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? CUSTPRIORITY
        {
            get { return _CUSTPRIORITY; }
            set { _CUSTPRIORITY = value; }
        }

        /// <summary>
        /// RM overpayment write-off account
        /// </summary>
        [DataMember]
        public string RMOvrpymtWrtoffAcct
        {
            get { return _RMOvrpymtWrtoffAcct; }
            set { _RMOvrpymtWrtoffAcct = value; }
        }

        /// <summary>
        /// Requester transaction:0=False; 1=True (if True, it populates the requester shadow table)
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
