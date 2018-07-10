using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace RMClass
{
    [DataContract]
    public class RMCashReceipt
    {
        private string _CUSTNMBR;
        private string _DOCNUMBR;
        private DateTime _DOCDATE;
        private decimal _ORTRXAMT;
        private DateTime _GLPOSTDT;
        private string _BACHNUMB;
        private short _CSHRCTYP;
        private string _CHEKBKID;
        private string _CHEKNMBR;
        private string _CRCARDID;
        private string _TRXDSCRN;
        private string _LSTUSRED;
        private string _BatchCHEKBKID;
        private string _CURNCYID;
        private decimal? _XCHGRATE;
        private string _RATETPID;
        private DateTime? _EXPNDATE;
        private DateTime? _EXCHDATE;
        private string _EXGTBDSC;
        private string _EXTBLSRC;
        private short? _RATEEXPR;
        private short? _DYSTINCR;
        private decimal? _RATEVARC;
        private short? _TRXDTDEF;
        private short? _RTCLCMTD;
        private short? _PRVDSLMT;
        private short? _DATELMTS;
        private DateTime? _TIME1;
        private short? _CREATEDIST;
        private short? _RequesterTrx;




        [DataMember]
        public string CUSTNMBR
        {
            get { return _CUSTNMBR; }
            set { _CUSTNMBR = value; }
        }

        [DataMember]
        public string DOCNUMBR
        {
            get { return _DOCNUMBR; }
            set { _DOCNUMBR = value; }
        }

        [DataMember]
        public DateTime DOCDATE
        {
            get { return _DOCDATE; }
            set { _DOCDATE = value; }
        }

        [DataMember]
        public decimal ORTRXAMT
        {
            get { return _ORTRXAMT; }
            set { _ORTRXAMT = value; }
        }

        [DataMember]
        public DateTime GLPOSTDT
        {
            get { return _GLPOSTDT; }
            set { _GLPOSTDT = value; }
        }

        [DataMember]
        public string BACHNUMB
        {
            get { return _BACHNUMB; }
            set { _BACHNUMB = value; }
        }

        [DataMember]
        public short CSHRCTYP
        {
            get { return _CSHRCTYP; }
            set { _CSHRCTYP = value; }
        }

        [DataMember]
        public string CHEKBKID
        {
            get { return _CHEKBKID; }
            set { _CHEKBKID = value; }
        }

        [DataMember]
        public string CHEKNMBR
        {
            get { return _CHEKNMBR; }
            set { _CHEKNMBR = value; }
        }

        [DataMember]
        public string CRCARDID
        {
            get { return _CRCARDID; }
            set { _CRCARDID = value; }
        }

        [DataMember]
        public string TRXDSCRN
        {
            get { return _TRXDSCRN; }
            set { _TRXDSCRN = value; }
        }

        [DataMember]
        public string LSTUSRED
        {
            get { return _LSTUSRED; }
            set { _LSTUSRED = value; }
        }

        [DataMember]
        public string BatchCHEKBKID
        {
            get { return _BatchCHEKBKID; }
            set { _BatchCHEKBKID = value; }
        }

        [DataMember]
        public string CURNCYID
        {
            get { return _CURNCYID; }
            set { _CURNCYID = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? XCHGRATE
        {
            get { return _XCHGRATE; }
            set { _XCHGRATE = value; }
        }

        [DataMember]
        public string RATETPID
        {
            get { return _RATETPID; }
            set { _RATETPID = value; }
        }

        [DataMember]
        public DateTime? EXPNDATE
        {
            get { return _EXPNDATE; }
            set { _EXPNDATE = value; }
        }

        [DataMember]
        public DateTime? EXCHDATE
        {
            get { return _EXCHDATE; }
            set { _EXCHDATE = value; }
        }

        [DataMember]
        public string EXGTBDSC
        {
            get { return _EXGTBDSC; }
            set { _EXGTBDSC = value; }
        }

        [DataMember]
        public string EXTBLSRC
        {
            get { return _EXTBLSRC; }
            set { _EXTBLSRC = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? RATEEXPR
        {
            get { return _RATEEXPR; }
            set { _RATEEXPR = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? DYSTINCR
        {
            get { return _DYSTINCR; }
            set { _DYSTINCR = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? RATEVARC
        {
            get { return _RATEVARC; }
            set { _RATEVARC = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? TRXDTDEF
        {
            get { return _TRXDTDEF; }
            set { _TRXDTDEF = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? RTCLCMTD
        {
            get { return _RTCLCMTD; }
            set { _RTCLCMTD = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? PRVDSLMT
        {
            get { return _PRVDSLMT; }
            set { _PRVDSLMT = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? DATELMTS
        {
            get { return _DATELMTS; }
            set { _DATELMTS = value; }
        }

        [DataMember]
        public DateTime? TIME1
        {
            get { return _TIME1; }
            set { _TIME1 = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? CREATEDIST
        {
            get { return _CREATEDIST; }
            set { _CREATEDIST = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get { return _RequesterTrx; }
            set { _RequesterTrx = value; }
        }
    }
}
