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
    public class GLTrasactionHeader
    {
        private string _BACHNUMB;
        private int _JRNENTRY;
        private string _REFRENCE;
        private DateTime _TRXDATE;
        private short _TRXTYPE;
        private decimal? _SQNCLINE;
        private short? _SERIES;
        private string _CURNCYID;
        private decimal? _XCHGRATE;
        private string _RATETPID;
        private DateTime? _EXPNDATE;
        private DateTime? _EXCHDATE;
        private string _EXGTBDSC;
        private string _EXTBLSRC;
        private short? _RATEEXPR;
        private decimal? _RATEVARC;
        private short? _TRXDTDEF;
        private short? _PRVDSLMT;
        private short? _DATELMTS;
        private short? _RequesterTrx;
        private string _SOURCDOC;
        private short? _Ledger_ID;
        private string _USERID;
        private short? _Adjustment_Transaction;
        private string _NOTETEXT;

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
        /// Reference
        /// </summary>
        [DataMember]
        public string REFRENCE
        {
            get { return _REFRENCE; }
            set { _REFRENCE = value; }
        }

        /// <summary>
        /// Transaction date
        /// </summary>
        [DataMember]
        public DateTime TRXDATE
        {
            get { return _TRXDATE; }
            set { _TRXDATE = value; }
        }

        /// <summary>
        /// Transaction type:
        /// 0=Regular;
        /// 1=Reversing
        /// </summary>
        [DataMember]
        public short TRXTYPE
        {
            get { return _TRXTYPE; }
            set { _TRXTYPE = value; }
        }

        /// <summary>
        /// Sequence line
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? SQNCLINE
        {
            get { return _SQNCLINE; }
            set { _SQNCLINE = value; }
        }

        /// <summary>
        /// Series:
        /// 1=All;
        /// 2=Financial;
        /// 3=Sales;
        /// 4=Purchasing;
        /// 5=Inventory;
        /// 6=Payroll;
        /// 7=Project
        /// </summary>
        [DataMember]
        [DefaultValue(2)]
        public short? SERIES
        {
            get { return _SERIES; }
            set { _SERIES = value; }
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
        [DefaultValue(0.00)]
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
        /// Source document
        /// </summary>
        [DataMember]
        public string SOURCDOC
        {
            get { return _SOURCDOC; }
            set { _SOURCDOC = value; }
        }

        /// <summary>
        /// Ledger ID
        /// 1=Base,
        /// 2=IFRS,
        /// 3=Local
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? Ledger_ID
        {
            get { return _Ledger_ID; }
            set { _Ledger_ID = value; }
        }

        /// <summary>
        /// User ID
        /// </summary>
        [DataMember]
        public string USERID
        {
            get { return _USERID; }
            set { _USERID = value; }
        }

        /// <summary>
        /// Adjustment transaction checkbox 0=False
        /// 1=True
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? Adjustment_Transaction
        {
            get { return _Adjustment_Transaction; }
            set { _Adjustment_Transaction = value; }
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
    }
}
