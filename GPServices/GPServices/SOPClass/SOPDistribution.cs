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
    public class SOPDistribution
    {
        private short _SOPTYPE;
        private string _SOPNUMBE;
        private int? _SEQNUMBR;
        private short _DISTTYPE;
        private string _DistRef;
        private int? _ACTINDX;
        private string _ACTNUMST;
        private decimal? _DEBITAMT;
        private decimal? _CRDTAMNT;
        private string _CUSTNMBR;
        private short? _RequesterTrx;


        /// <summary>
        /// 1=Quote; 
        /// 2=Order; 
        /// 3=Invoice; 
        /// 4=Return; 
        /// 5=Bkorder; 
        /// 6=Fulfillment order
        /// </summary>
        [DataMember]
        public short SOPTYPE
        {
            get { return _SOPTYPE; }
            set { _SOPTYPE = value; }
        }

        /// <summary>
        /// Document number, SOP number
        /// </summary>
        [DataMember]
        public string SOPNUMBE
        {
            get { return _SOPNUMBE; }
            set { _SOPNUMBE = value; }
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
        /// 1=Sales; 
        /// 2=Receiving; 
        /// 3=Cash; 
        /// 4=Taken; 
        /// 5=Available; 
        /// 6=Trade; 
        /// 7=Freight; 
        /// 8=Miscellaneous;
        /// 9=Taxes; 
        /// 10=Mark; 
        /// 11=Commission Expense;
        /// 12=Commission pay; 
        /// 13=Other; 
        /// 14=COGS; 
        /// 15=Invoice; 
        /// 16=Returns; 
        /// 17=In use; 
        /// 18=In service; 
        /// 19=Damaged; 
        /// 20=Unit; 
        /// 21=Deposits; 
        /// 22=Round
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
        /// Customer number
        /// </summary>
        [DataMember]
        public string CUSTNMBR
        {
            get { return _CUSTNMBR; }
            set { _CUSTNMBR = value; }
        }

        /// <summary>
        /// Requester transaction:0=False; 1=True(if True, it populates the requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get { return _RequesterTrx;}
            set { _RequesterTrx = value; }
        }


    }
}
