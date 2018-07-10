using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace RMClass
{
    [DataContract]
    public class RMUnapply
    {
        private string _CUSTNMBR;
        private string _DOCNUMBR;
        private short _RMDTYPAL;
        private short? _APTODCTY;
        private string _APTODCNM;
        private DateTime? _GLPOSTDT;

        [DataMember]
        public string CUSTNMBR
        {
            get
            {
                return _CUSTNMBR;
            }

            set
            {
                _CUSTNMBR = value;
            }
        }

        [DataMember]
        public string DOCNUMBR
        {
            get
            {
                return _DOCNUMBR;
            }

            set
            {
                _DOCNUMBR = value;
            }
        }

        [DataMember]
        public short RMDTYPAL
        {
            get
            {
                return _RMDTYPAL;
            }

            set
            {
                _RMDTYPAL = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? APTODCTY
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
        public DateTime? GLPOSTDT
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
