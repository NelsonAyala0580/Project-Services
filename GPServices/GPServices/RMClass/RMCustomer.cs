using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace RMClass
{
    [DataContract]
    public class RMCustomer
    {
        private string _CUSTNMBR;
        private short? _HOLD;
        private short? _INACTIVE;
        private string _CUSTNAME;
        private string _SHRTNAME;
        private string _STMTNAME;
        private string _CUSTCLASS;
        private string _ADRSCODE;
        private string _CNTCPRSN;
        private string _ADDRESS1;
        private string _ADDRESS2;
        private string _ADDRESS3;
        private string _CITY;
        private string _STATE;
        private string _ZIPCODE;
        private string _CCode;
        private string _COUNTRY;
        private string _PHNUMBR1;
        private string _PHNUMBR2;
        private string _PHNUMBR3;
        private string _FAX;
        private string _TAXSCHID;
        private string _SLPRSNID;
        private string _SALESTERR;
        private string _USERDEF1;
        private string _USERDEF2;
        private short? _CRLMTTYP;
        private decimal? _CRLMTAMT;
        private short? _CRLMTPER;
        private string _TXRGNNUM;
        private string _CURNCYID;
        private string _CHEKBKID;
        private short? _UseCustomerClass;
        private short? _CreateAddress;
        private string _INTEGRATIONID;
        private short? _UpdateIfExists;

        [DataMember]
        [Description("Customer number")]
        public string CUSTNMBR
        {
            get { return _CUSTNMBR; }
            set { _CUSTNMBR = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        [Description("Hold status: 0=Not on hold;1=On hold Default is zero on new record")]
        public short? HOLD
        {
            get { return _HOLD; }
            set { _HOLD = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        [Description("Inactive:0=Active;1=InactiveDefault is zero on new record")]
        public short? INACTIVE
        {
            get { return _INACTIVE; }
            set { _INACTIVE = value; }
        }

        [DataMember]
        [Description("Customer name")]
        public string CUSTNAME
        {
            get { return _CUSTNAME; }
            set { _CUSTNAME = value; }
        }


        [DataMember]
        [Description("Short name; if not passed in, default is CUSTNAME")]
        public string SHRTNAME
        {
            get { return _SHRTNAME; }
            set { _SHRTNAME = value; }
        }


        [DataMember]
        [Description("Statement name; if not passed in, default is CUSTNAME")]
        public string STMTNAME
        {
            get { return _STMTNAME; }
            set { _STMTNAME = value; }
        }


        [DataMember]
        [Description("Customer class ID")]
        public string CUSTCLASS
        {
            get { return _CUSTCLASS; }
            set { _CUSTCLASS = value; }
        }

        [DataMember]
        [Description("Primary address ID")]
        public string ADRSCODE
        {
            get { return _ADRSCODE; }
            set { _ADRSCODE = value; }
        }

        [DataMember]
        [Description("Contact person")]
        public string CNTCPRSN
        {
            get { return _CNTCPRSN; }
            set { _CNTCPRSN = value; }
        }

        [DataMember]
        [Description("Customer address one")]
        public string ADDRESS1
        {
            get { return _ADDRESS1; }
            set { _ADDRESS1 = value; }
        }

        [DataMember]
        [Description("Customer address two")]
        public string ADDRESS2
        {
            get { return _ADDRESS2; }
            set { _ADDRESS2 = value; }

        }

        [DataMember]
        [Description("Customer address three")]
        public string ADDRESS3
        {
            get { return _ADDRESS3; }
            set { _ADDRESS3 = value; }
        }

        [DataMember]
        [Description("City")]
        public string CITY
        {
            get { return _CITY; }
            set { _CITY = value; }
        }

        [DataMember]
        [Description("State")]
        public string STATE
        {
            get { return _STATE; }
            set { _STATE = value; }
        }

        [DataMember]
        [Description("Zip Code")]
        public string ZIPCODE
        {
            get { return _ZIPCODE; }
            set { _ZIPCODE = value; }
        }

        [DataMember]
        [Description("Country Code")]
        public string CCode
        {
            get { return _CCode; }
            set { _CCode = value; }
        }
        [DataMember]
        [Description("Country")]
        public string COUNTRY
        {
            get { return _COUNTRY; }
            set { _COUNTRY = value; }
        }

        [DataMember]
        [Description("Phone 1")]
        public string PHNUMBR1
        {
            get { return _PHNUMBR1; }
            set { _PHNUMBR1 = value; }
        }

        [DataMember]
        [Description("Phone 2")]
        public string PHNUMBR2
        {
            get { return _PHNUMBR2; }
            set { _PHNUMBR2 = value; }
        }

        [DataMember]
        [Description("Phone 3")]
        public string PHNUMBR3
        {
            get { return _PHNUMBR3; }
            set { _PHNUMBR3 = value; }
        }

        [DataMember]
        [Description("Fax")]
        public string FAX
        {
            get { return _FAX; }
            set { _FAX = value; }
        }

        [DataMember]
        [Description("Tax Schedule ID")]
        public string TAXSCHID
        {
            get { return _TAXSCHID; }
            set { _TAXSCHID = value; }
        }

        [DataMember]
        [Description("Salesperson ID")]
        public string SLPRSNID
        {
            get { return _SLPRSNID; }
            set { _SLPRSNID = value; }
        }

        [DataMember]
        [Description("Sales Territory")]
        public string SALESTERR
        {
            get { return _SALESTERR; }
            set { _SALESTERR = value; }
        }


        [DataMember]
        [Description("User-defined one")]
        public string USERDEF1
        {
            get { return _USERDEF1; }
            set { _USERDEF1 = value; }
        }

        [DataMember]
        [Description("User-defined two")]
        public string USERDEF2
        {
            get { return _USERDEF2; }
            set { _USERDEF2 = value; }
        }


        [DataMember]
        [DefaultValue(0)]
        [Description("Credit limit type:0 = No credit; 1 = Unlimited;2 = Amount. Default is zero on new record")]
        public short? CRLMTTYP
        {
            get { return _CRLMTTYP; }
            set { _CRLMTTYP = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        [Description("Credit limit amount; used if CRLMTTYP=2")]
        public decimal? CRLMTAMT
        {
            get { return _CRLMTAMT; }
            set { _CRLMTAMT = value; }
        }

        [DataMember]
        [DefaultValue(0)]
        [Description("Credit limit period; used if CRLMTTYP=2 and the credit limit warning is used in Microsoft Dynamics GP application")]
        public short? CRLMTPER
        {
            get { return _CRLMTPER; }
            set { _CRLMTPER = value; }
        }

        [DataMember]
        [Description("Tax registration number")]
        public string TXRGNNUM
        {
            get { return _TXRGNNUM; }
            set { _TXRGNNUM = value; }
        }

        [DataMember]
        [Description("Currency ID")]
        public string CURNCYID
        {
            get { return _CURNCYID; }
            set { _CURNCYID = value; }
        }


        [DataMember]
        [Description("Checkbook ID")]
        public string CHEKBKID
        {
            get { return _CHEKBKID; }
            set { _CHEKBKID = value; }

        }

        [DataMember]
        [DefaultValue(0)]
        [Description("UseCustomerClass")] 
        public short? UseCustomerClass
        {
            get { return _UseCustomerClass; }
            set { _UseCustomerClass = value; }
        }

        [DataMember]
        [DefaultValue(1)]
        [Description("Flag to allow a primary address code to be created on the fly:0 = Do not create address code;1 = Create address code")]
        public short? CreateAddress
        {
            get { return _CreateAddress; }
            set { _CreateAddress = value; }
        }

        [DataMember]
        [Description("Integration ID")]
        public string INTEGRATIONID
        {
            get { return _INTEGRATIONID; }
            set { _INTEGRATIONID = value; }
        }

        [DataMember]
        [Description("Flag to allow customer data to be updated if it exists: 0=Do not update; 1=Update if record exists;2=Create if record does not exist and exits without error if record does exist")]
        public short? UpdateIfExists
        {
            get { return _UpdateIfExists; }
            set { _UpdateIfExists = value; }
        }
    }
}
