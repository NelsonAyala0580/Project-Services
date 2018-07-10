using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace RMClass
{
    [DataContract]
    public class RMApply
    {
        private string _APTODCNM;
        private string _APFRDCNM;
        private decimal _APPTOAMT;
        private int _APFRDCTY;
        private int _APTODCTY;
        private decimal? _DISTKNAM;
        private decimal? _WROFAMNT;
        private DateTime _APPLYDATE;
        private DateTime _GLPOSTDT;

        [DataMember]
        public string APTODCNM
        {
            get
            {
                return _APTODCNM;
            }

            set
            {
                _APTODCNM = value;
            }
        }

        [DataMember]
        public string APFRDCNM
        {
            get
            {
                return _APFRDCNM;
            }

            set
            {
                _APFRDCNM = value;
            }
        }

        [DataMember]
        public decimal APPTOAMT
        {
            get
            {
                return _APPTOAMT;
            }

            set
            {
                _APPTOAMT = value;
            }
        }

        [DataMember]
        public int APFRDCTY
        {
            get
            {
                return _APFRDCTY;
            }

            set
            {
                _APFRDCTY = value;
            }
        }

        [DataMember]
        public int APTODCTY
        {
            get
            {
                return _APTODCTY;
            }

            set
            {
                _APTODCTY = value;
            }
        }

        [DataMember]
        public decimal? DISTKNAM
        {
            get
            {
                return _DISTKNAM;
            }

            set
            {
                _DISTKNAM = value;
            }
        }
        [DataMember]
        [DefaultValue(0)]
        public decimal? WROFAMNT
        {
            get
            {
                return _WROFAMNT;
            }

            set
            {
                _WROFAMNT = value;
            }
        }

        [DataMember]
        public DateTime APPLYDATE
        {
            get
            {
                return _APPLYDATE;
            }

            set
            {
                _APPLYDATE = value;
            }
        }

        [DataMember]
        public DateTime GLPOSTDT
        {
            get
            {
                return _GLPOSTDT;
            }

            set
            {
                _GLPOSTDT = value;
            }
        }
    }
}
