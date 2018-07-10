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
    public class SOPTax
    {
        private short _SOPTYPE;
        private short _TAXTYPE;
        private string _SOPNUMBE;
        private string _CUSTNMBR;
        private int? _LNITMSEQ;
        private decimal? _SALESAMT;
        private decimal? _FRTTXAMT;
        private decimal? _MSCTXAMT;
        private decimal? _FREIGHT;
        private decimal? _MISCAMNT;
        private string _TAXDTLID;
        private int _ACTINDX;
        private string _ACTNUMST;
        private decimal? _STAXAMNT;
        private decimal? _TDTTXSLS;
        private decimal? _TXDTOTTX;
        private short? _RequesterTrx;

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
        /// 0=Regular; 
        /// 1=Freight; 
        /// 2=Miscellaneous(required/optional field)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short TAXTYPE
        {
            get { return _TAXTYPE; }
            set { _TAXTYPE = value; }
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
        /// Line item sequence--ignored for freight/miscellaneous required/optional field
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? LNITMSEQ
        {
            get { return _LNITMSEQ; }
            set { _LNITMSEQ = value; }
        }

        /// <summary>
        /// Details taxable amount for sales
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? SALESAMT
        {
            get { return _SALESAMT; }
            set { _SALESAMT = value; }
        }

        /// <summary>
        /// Freight tax--must be on freight record and 0 sequence number record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FRTTXAMT
        {
            get { return _FRTTXAMT; }
            set { _FRTTXAMT = value; }
        }

        /// <summary>
        /// Miscellaneous tax--must be on miscellaneous record and 0 sequence number record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MSCTXAMT
        {
            get { return _MSCTXAMT; }
            set { _MSCTXAMT = value; }
        }

        /// <summary>
        /// Freight amount--must be on freight record and 0 sequence number record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FREIGHT
        {
            get { return _FREIGHT; }
            set { _FREIGHT = value; }
        }

        /// <summary>
        /// Miscellaneous amount--must be on miscellaneous record and 0 sequence number record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MISCAMNT
        {
            get { return _MISCAMNT; }
            set { _MISCAMNT = value; }
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
        /// Account index
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int ACTINDX
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
        /// Sales tax amount--not used for freight
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? STAXAMNT
        {
            get { return _STAXAMNT; }
            set { _STAXAMNT = value; }
        }

        /// <summary>
        /// Total taxable sales amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TDTTXSLS
        {
            get { return _TDTTXSLS; }
            set { _TDTTXSLS = value; }
        }

        /// <summary>
        /// Tax detail total tax potential
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? TXDTOTTX
        {
            get { return _TXDTOTTX; }
            set { _TXDTOTTX = value; }
        }

        /// <summary>
        /// Requester transaction:
        /// 0=False; 
        /// 1=True (if True, it populates the requester shadow table)
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
