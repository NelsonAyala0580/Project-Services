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
    public class PMTransactionDist
    {
        private short _DOCTYPE;
        private string _VCHRNMBR;
        private string _VENDORID;
        private int _DSTSQNUM;
        private short _DISTTYPE;
        private string _DistRef;
        private short _ACTINDX;
        private string _ACTNUMST;
        private decimal _DEBITAMT;
        private decimal _CRDTAMNT;
        private short? _RequesterTrx;


        /// <summary>
        /// Document type:
        /// 1=Invoice;
        /// 2=Finance charge;
        /// 3=Miscellaneous charge;
        /// 4=Return;
        /// 5=Credit memo;
        /// 6=Manual checks
        /// </summary>
        [DataMember]
        public short DOCTYPE
        {
            get { return _DOCTYPE; }
            set { _DOCTYPE = value; }
        }

        /// <summary>
        /// Voucher number/payment number; if passing a manual check, pass in payment number
        /// </summary>
        [DataMember]
        public string VCHRNMBR
        {
            get { return _VCHRNMBR; }
            set { _VCHRNMBR = value; }
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
        /// Sequence number
        /// </summary>
        [DataMember]
        public int DSTSQNUM
        {
            get { return _DSTSQNUM; }
            set { _DSTSQNUM = value; }
        }

        /// <summary>
        /// Distribution type:
        /// 1=Cash;
        /// 2=Pay;
        /// 3=Avail;
        /// 4=Taken;
        /// 5=Fnchg;
        /// 6=Purch;
        /// 7=Trade;
        /// 8=Misc;
        /// 9=Freight;
        /// 10=Taxes;
        /// 11=Write;
        /// 12=Other;
        /// 13=Gst;
        /// 14=Wh;
        /// 15=Unit;
        /// 16=Round
        /// </summary>
        [DataMember]
        public short DISTTYPE
        {
            get { return _DISTTYPE; }
            set { _DISTTYPE = value; }
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
        /// Account index
        /// </summary>
        [DataMember]
        public short ACTINDX
        {
            get { return _ACTINDX; }
            set { _ACTINDX = value; }
        }

        /// <summary>
        /// Account number string
        /// </summary>
        [DataMember]
        public string ACTNUMST
        {
            get { return _ACTNUMST; }
            set { _ACTNUMST = value; }
        }

        /// <summary>
        /// Debit amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal DEBITAMT
        {
            get { return _DEBITAMT; }
            set { _DEBITAMT = value; }
        }

        /// <summary>
        /// Credit amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal CRDTAMNT
        {
            get { return _CRDTAMNT; }
            set { _CRDTAMNT = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False;
        /// 1=True(if True, it populates requester shadow table)
        /// </summary>
        [DataMember]
        public short? RequesterTrx
        {
            get { return _RequesterTrx; }
            set { _RequesterTrx = value; }
        }

    }
}
