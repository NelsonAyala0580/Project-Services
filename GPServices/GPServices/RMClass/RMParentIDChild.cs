using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace RMClass
{
    [DataContract]
    public class RMParentIDChild
    {
        private string _CPRCSTNM;
        private string _CUSTNMBR;
        private short? _CreateRemove;
        private short? _RequesterTrx;

        /// <summary>
        /// Corporate customer number
        /// </summary>
        [DataMember]
        public string CPRCSTNM
        {
            get
            {
                return _CPRCSTNM;
            }

            set
            {
                _CPRCSTNM = value;
            }
        }

        /// <summary>
        /// Customer number to assign as child
        /// </summary>
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

        /// <summary>
        /// Create/Remove flag:0=Create new child record; 1=Remove child record
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? CreateRemove
        {
            get
            {
                return _CreateRemove;
            }

            set
            {
                _CreateRemove = value;
            }
        }

        /// <summary>
        /// Requester transaction: 0=False; 1=True (if True, it populates the requester shadow table)
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? RequesterTrx
        {
            get
            {
                return _RequesterTrx;
            }

            set
            {
                _RequesterTrx = value;
            }
        }
    }
}
