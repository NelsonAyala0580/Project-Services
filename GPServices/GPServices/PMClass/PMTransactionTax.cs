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
    public class PMTransactionTax
    {
        private string _VENDORID;
        private string _VCHRNMBR;
        private short _DOCTYPE;
        private string _BACHNUMB;
        private string _TAXDTLID;
        private decimal _TAXAMNT;
        private decimal _PCTAXAMT;
        private decimal _FRTTXAMT;
        private decimal _MSCTXAMT;
        private decimal _TDTTXPUR;
        private decimal _TXDTTPUR;
        private short _ACTINDX;
        private string _ACTNUMST;
        private short? _RequesterTrx;

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
        /// Voucher number--must be a unique number
        /// </summary>
        [DataMember]
        public string VCHRNMBR
        {
            get { return _VCHRNMBR; }
            set { _VCHRNMBR = value; }
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
        /// Batch number--batch for cash receipt;. created on the fly, populates SY00500 and RM10301
        /// </summary>
        [DataMember]
        public string BACHNUMB
        {
            get { return _BACHNUMB; }
            set { _BACHNUMB = value; }
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
        public decimal TAXAMNT
        {
            get { return _TAXAMNT; }
            set { _TAXAMNT = value; }
        }

        /// <summary>
        /// Purchases tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal PCTAXAMT
        {
            get { return _PCTAXAMT; }
            set { _PCTAXAMT = value; }
        }

        /// <summary>
        /// Freight tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal FRTTXAMT
        {
            get { return _FRTTXAMT; }
            set { _FRTTXAMT = value; }
        }

        /// <summary>
        /// Miscellaneous tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal MSCTXAMT
        {
            get { return _MSCTXAMT; }
            set { _MSCTXAMT = value; }
        }

        /// <summary>
        /// Tax detail purchases--this is the goods value
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal TDTTXPUR
        {
            get { return _TDTTXPUR; }
            set { _TDTTXPUR = value; }
        }

        /// <summary>
        /// Total tax detail purchased
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal TXDTTPUR
        {
            get { return _TXDTTPUR; }
            set { _TXDTTPUR = value; }
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
    }
}
