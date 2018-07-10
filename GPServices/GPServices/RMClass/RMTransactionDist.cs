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
    public class RMTransactionDist
    {
        private short _RMDTYPAL;
        private string _DOCNUMBR;
        private string _CUSTNMBR;
        private int? _SEQNUMBR;
        private short _DISTTYPE;
        private string _DistRef;
        private int? _DSTINDX;
        private string _ACTNUMST;
        private decimal? _DEBITAMT;
        private decimal? _CRDTAMNT;
        private string _USRDEFND1;
        private string _USRDEFND2;
        private string _USRDEFND3;
        private string _USRDEFND4;
        private string _USRDEFND5;

        /// <summary>
        /// Distribucion valida por cada tipo de documento:
        /// RMDTYPAL	   Distribution types
        ///    1      ---  1, 2, 3, 5, 8, 9, 10, 11, 12, 13, 14, 15, 23, 24
        ///    3      ---  1, 2, 3, 5, 8, 10, 11, 12, 13, 14, 15, 18, 23, 24
        ///    4      ---  1, 2, 3, 5, 8, 10, 11, 12, 13, 14, 15, 16, 23, 24
        ///    5      ---  1, 2, 3, 5, 8, 10, 11, 12, 13, 14, 15, 20, 23, 24
        ///    6      ---  8, 10, 11, 12, 13, 14, 15, 21, 22
        ///    7      ---  1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 19, 23, 24
        ///    8      ---  1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 17, 21
        /// </summary>




        /// <summary>
        /// RM Document Types - RMDTYPAL:
        /// 1=Sales/invoice;
        /// 3=Debit memo;
        /// 4=Finance charge;
        /// 5=Service/repair;
        /// 6=Warranty;
        /// 7=Credit memo;
        /// 8=Return;
        /// 9=Cash receipt;
        /// </summary>
        /// 
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
        /// Customer ID
        /// </summary>
        [DataMember]
        public string CUSTNMBR
        {
            get { return _CUSTNMBR; }
            set { _CUSTNMBR = value; }
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
        /// Distribution type:
        /// 1=Cash;
        /// 2=Taken;
        /// 3=Recv;
        /// 4=Write;
        /// 5=Avail;
        /// 6=Gst;
        /// 7=Wh;
        /// 8=Other;
        /// 9=Sales;
        /// 10=Trade;
        /// 11=Freight;
        /// 12=Misc;
        /// 13=Taxes;
        /// 14=Cogs;
        /// 15=Inv;
        /// 16=Fnchg;
        /// 17=Returns;
        /// 18=DrMemo;
        /// 19=CrMemo;
        /// 20=Service;
        /// 21=Warrexp;
        /// 22=Warrsls;
        /// 23=Commexp;
        /// 24=Cpmmpay
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
        [DefaultValue(0)]
        public int? DSTINDX
        {
            get { return _DSTINDX; }
            set { _DSTINDX = value; }
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
        public decimal? DEBITAMT
        {
            get { return _DEBITAMT; }
            set { _DEBITAMT = value; }
        }

        /// <summary>
        /// Credit amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? CRDTAMNT
        {
            get { return _CRDTAMNT; }
            set { _CRDTAMNT = value; }
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
