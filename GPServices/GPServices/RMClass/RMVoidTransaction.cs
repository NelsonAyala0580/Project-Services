using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace RMClass
{
    [DataContract]
    public class RMVoidTransaction
    {
        private string _CUSTNMBR;
        private string _DOCNUMBR;
        private short _VOIDSTTS;
        private short _RMDTYPAL;
        private DateTime _VOIDDATE;
        private DateTime _GLPOSTDT;

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
        public short VOIDSTTS
        {
            get
            {
                return _VOIDSTTS;
            }

            set
            {
                _VOIDSTTS = value;
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
        public DateTime VOIDDATE
        {
            get
            {
                return _VOIDDATE;
            }

            set
            {
                _VOIDDATE = value;
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
