using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RMClass
{
    [DataContract]
    public class RMDocumentTaxes
    {
        private string _CUSTNMBR;
        private string _DOCNUMBR;
        private short _RMDTYPAL;
        private string _BACHNUMB;
        private string _TAXDTLID;
        private decimal _TAXAMNT;
        private decimal _STAXAMNT;
        private decimal? _FRTTXAMT;
        private decimal? _MSCTXAMT;
        private decimal _TAXDTSLS;
        private int? _SEQNUMBR;
        private int? _ACTINDX;
        private string _ACTNUMST;
        private decimal _TDTTXSLS;
        private short? _RequesterTrx;
        private string _USRDEFND1;
        private string _USRDEFND2;
        private string _USRDEFND3;
        private string _USRDEFND4;
        private string _USRDEFND5;

        /// <summary>
        /// Customer ID
        /// </summary>
        [DataMember]
        public string CUSTNMBR
        {
            get { return _CUSTNMBR; }
            set { _CUSTNMBR = value; }
        }
        /// <summary>
        /// Document number--must be unique
        /// </summary>
        [DataMember]
        public string DOCNUMBR
        {
            get { return _DOCNUMBR; }
            set { _DOCNUMBR = value; }
        }
        /// <summary>
        /// Document type
        /// </summary>
        [DataMember]
        public short RMDTYPAL
        {
            get { return _RMDTYPAL; }
            set { _RMDTYPAL = value; }
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
        /// Sales tax amounts
        /// </summary>
        [DataMember]
        public decimal STAXAMNT
        {
            get { return _STAXAMNT; }
            set { _STAXAMNT = value; }
        }
        /// <summary>
        /// Freight tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? FRTTXAMT
        {
            get { return _FRTTXAMT; }
            set { _FRTTXAMT = value; }
        }
        /// <summary>
        /// Miscellaneous tax amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? MSCTXAMT
        {
            get { return _MSCTXAMT; }
            set { _MSCTXAMT = value; }
        }
        /// <summary>
        /// Tax detail total sales
        /// </summary>
        [DataMember]
        public decimal TAXDTSLS
        {
            get { return _TAXDTSLS; }
            set { _TAXDTSLS = value; }
        }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? SEQNUMBR
        {
            get { return _SEQNUMBR; }
            set { _SEQNUMBR = value; }
        }
        /// <summary>
        /// Account index
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? ACTINDX
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
        /// 
        /// </summary>
        [DataMember]
        public decimal TDTTXSLS
        {
            get { return _TDTTXSLS; }
            set { _TDTTXSLS = value; }
        }
        /// <summary>
        /// Tax detail of total taxable sales
        /// Requester transaction:
        /// 0=False,
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
        /// User-defined field--developer use only
        /// </summary>
        [DataMember]
        public string USRDEFND1
        {
            get { return _USRDEFND1; }
            set { _USRDEFND1 = value; }
        }
        /// <summary>
        /// User-defined field--developer use only
        /// </summary>
        [DataMember]
        public string USRDEFND2
        {
            get { return _USRDEFND2; }
            set { _USRDEFND2 = value; }
        }
        /// <summary>
        /// User-defined field--developer use only
        /// </summary>
        [DataMember]
        public string USRDEFND3
        {
            get { return _USRDEFND3; }
            set { _USRDEFND3 = value; }
        }
        /// <summary>
        /// User-defined field--developer use only
        /// </summary>
        [DataMember]
        public string USRDEFND4
        {
            get { return _USRDEFND4; }
            set { _USRDEFND4 = value; }
        }
        /// <summary>
        /// User-defined field--developer use only
        /// </summary>
        [DataMember]
        public string USRDEFND5
        {
            get { return _USRDEFND5; }
            set { _USRDEFND5 = value; }
        }
    }
}
