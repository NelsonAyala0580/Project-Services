using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace RMClass
{
    [DataContract]
    public class RMParentID
    {
        private string _CPRCSTNM;
        private short? _NAALLOWRECEIPTS;
        private short? _NACREDITCHECK;
        private short? _NAFINANCECHARGE;
        private short? _NAHOLDINACTIVE;
        private short? _NADEFPARENTVEN;
        private short? _UpdateIfExists;
        private short? _RequesterTrx;

        /// <summary>
        /// Corporate customer number
        /// </summary>
        [DataMember]
        public string CPRCSTNM
        {
            get { return _CPRCSTNM; }
            set { _CPRCSTNM = value; }
        }

        /// <summary>
        /// Allow receipts entry for children of the national account
        /// </summary>
        [DataMember]
        [DefaultValue(1)]
        public short? NAALLOWRECEIPTS
        {
            get { return _NAALLOWRECEIPTS; }
            set { _NAALLOWRECEIPTS = value; }
        }

        /// <summary>
        /// Base credit check on consolidated national account
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? NACREDITCHECK
        {
            get { return _NACREDITCHECK; }
            set { _NACREDITCHECK = value; }
        }

        /// <summary>
        /// Base finance charge on consolidated national account
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? NAFINANCECHARGE
        {
            get { return _NAFINANCECHARGE; }
            set { _NAFINANCECHARGE = value; }
        }

        /// <summary>
        /// Apply hold/inactive status of parent across national account
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? NAHOLDINACTIVE
        {
            get { return _NAHOLDINACTIVE; }
            set { _NAHOLDINACTIVE = value; }
        }

        /// <summary>
        /// Default parent vendor for children refund checks
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? NADEFPARENTVEN
        {
            get { return _NADEFPARENTVEN; }
            set { _NADEFPARENTVEN = value; }
        }

        /// <summary>
        /// Flag to allow customer data to be updated if it exists:0=No; 1=Yes
        /// </summary>
        [DataMember]
        [DefaultValue(0)]
        public short? UpdateIfExists
        {
            get { return _UpdateIfExists; }
            set { _UpdateIfExists = value; }
        }

        /// <summary>
        /// Requester transaction: 0=False; 1=True (if True, it populates the requester shadow table)
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
