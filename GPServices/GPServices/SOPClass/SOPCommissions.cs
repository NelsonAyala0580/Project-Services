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
    public class SOPCommissions
    {
        private short _SOPTYPE;
        private string _SOPNUMBE;
        private int? _LNITMSEQ;
        private string _SLPRSNID;
        private string _SALSTERR;
        private decimal? _COMPRCNT;
        private decimal? _COMMAMNT;
        private decimal? _PRCTOSAL;
        private string _CUSTNMBR;
        private string _CURNCYID;
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
        /// Document number
        /// </summary>
        [DataMember]
        public string SOPNUMBE
        {
            get { return _SOPNUMBE; }
            set { _SOPNUMBE = value;}
        }

        /// <summary>
        /// Line sequence number--leave 0 to autocreate sequence number
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public int? LNITMSEQ
        {
            get { return _LNITMSEQ;}
            set { _LNITMSEQ = value; }
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
        /// Sales territory
        /// </summary>
        [DataMember]
        public string SALSTERR
        {
            get { return _SALSTERR; }
            set { _SALSTERR = value; }
        }

        /// <summary>
        /// Salesperson commission percentage
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? COMPRCNT
        {
            get { return _COMPRCNT; }
            set { _COMPRCNT = value; }
        }

        /// <summary>
        /// Commission amount
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public decimal? COMMAMNT
        {
            get { return _COMMAMNT; }
            set { _COMMAMNT = value; }
        }

        /// <summary>
        /// Percent of sale that the commission is based on
        /// </summary>
        [DataMember]
        [DefaultValue(100)]
        public decimal? PRCTOSAL
        {
            get { return _PRCTOSAL; }
            set { _PRCTOSAL = value; }
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
        /// Currency ID
        /// </summary>
        [DataMember]
        public string CURNCYID
        {
            get { return _CURNCYID; }
            set { _CURNCYID = value;}
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
