using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace RMClass
{
    [DataContract]
    public class RMSalesPerson
    {

        private string _SLPRSNID;
        private string _SALSTERR;
        private string _EMPLOYID;
        private string _VEDORID;
        private string _SLPRSNFN;
        private string _SPRSNSMN;
        private string _SPRSNSLN;
        private string _ADDRESS1;
        private string _ADDRESS2;
        private string _ADDRESS3;
        private string _CITY;
        private string _STATE;
        private string _ZIP;
        private string _COUNTRY;
        private string _PHONE1;
        private string _PHONE2;
        private string _PHONE3;
        private string _FAX;
        private short? _INACTIVE;
        private string _COMMCODE;
        private decimal? _COMPRCNT;
        private decimal? _STDCPRCT;
        private short? _COMAPPTO;
        private decimal? _COSTTODT;
        private decimal?_CSTLSTYR;
        private decimal? _TTLCOMTD;
        private decimal? _TTLCOMLY;
        private decimal? _COMSLTDT;
        private decimal? _COMSLLYR;
        private decimal? _NCOMSLTD;
        private decimal? _NCOMSLYR;
        private short? _KPCALHST;
        private short? _KPERHIST;
        private DateTime? _MODIFDT;
        private DateTime? _CREATDDT;
        private short? _COMMDEST;
        private short? _UpdateIfExists;
        private short? _RequesterTrx;

        [DataMember]
        public string SLPRSNID
        {
            get
            {
                return _SLPRSNID;
            }

            set
            {
                _SLPRSNID = value;
            }
        }

        [DataMember]
        public string SALSTERR
        {
            get
            {
                return _SALSTERR;
            }

            set
            {
                _SALSTERR = value;
            }
        }

        [DataMember]
        public string EMPLOYID
        {
            get
            {
                return _EMPLOYID;
            }

            set
            {
                _EMPLOYID = value;
            }
        }

        [DataMember]
        public string VEDORID
        {
            get
            {
                return _VEDORID;
            }

            set
            {
                _VEDORID = value;
            }
        }

        [DataMember]
        public string SLPRSNFN
        {
            get
            {
                return _SLPRSNFN;
            }

            set
            {
                _SLPRSNFN = value;
            }
        }

        [DataMember]
        public string SPRSNSMN
        {
            get
            {
                return _SPRSNSMN;
            }

            set
            {
                _SPRSNSMN = value;
            }
        }

        [DataMember]
        public string SPRSNSLN
        {
            get
            {
                return _SPRSNSLN;
            }

            set
            {
                _SPRSNSLN = value;
            }
        }

        [DataMember]
        public string ADDRESS1
        {
            get
            {
                return _ADDRESS1;
            }

            set
            {
                _ADDRESS1 = value;
            }
        }

        [DataMember]
        public string ADDRESS2
        {
            get
            {
                return _ADDRESS2;
            }

            set
            {
                _ADDRESS2 = value;
            }
        }

        [DataMember]
        public string ADDRESS3
        {
            get
            {
                return _ADDRESS3;
            }

            set
            {
                _ADDRESS3 = value;
            }
        }

        [DataMember]
        public string CITY
        {
            get
            {
                return _CITY;
            }

            set
            {
                _CITY = value;
            }
        }

        [DataMember]
        public string STATE
        {
            get
            {
                return _STATE;
            }

            set
            {
                _STATE = value;
            }
        }

        [DataMember]
        public string ZIP
        {
            get
            {
                return _ZIP;
            }

            set
            {
                _ZIP = value;
            }
        }

        [DataMember]
        public string COUNTRY
        {
            get
            {
                return _COUNTRY;
            }

            set
            {
                _COUNTRY = value;
            }
        }

        [DataMember]
        public string PHONE1
        {
            get
            {
                return _PHONE1;
            }

            set
            {
                _PHONE1 = value;
            }
        }

        [DataMember]
        public string PHONE2
        {
            get
            {
                return _PHONE2;
            }

            set
            {
                _PHONE2 = value;
            }
        }

        [DataMember]
        public string PHONE3
        {
            get
            {
                return _PHONE3;
            }

            set
            {
                _PHONE3 = value;
            }
        }

        [DataMember]
        public string FAX
        {
            get
            {
                return _FAX;
            }

            set
            {
                _FAX = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? INACTIVE
        {
            get
            {
                return _INACTIVE;
            }

            set
            {
                _INACTIVE = value;
            }
        }

        [DataMember]
        public string COMMCODE
        {
            get
            {
                return _COMMCODE;
            }

            set
            {
                _COMMCODE = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? COMPRCNT
        {
            get
            {
                return _COMPRCNT;
            }

            set
            {
                _COMPRCNT = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? STDCPRCT
        {
            get
            {
                return _STDCPRCT;
            }

            set
            {
                _STDCPRCT = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? COMAPPTO
        {
            get
            {
                return _COMAPPTO;
            }

            set
            {
                _COMAPPTO = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? COSTTODT
        {
            get
            {
                return _COSTTODT;
            }

            set
            {
                _COSTTODT = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? CSTLSTYR
        {
            get
            {
                return _CSTLSTYR;
            }

            set
            {
                _CSTLSTYR = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? TTLCOMTD
        {
            get
            {
                return _TTLCOMTD;
            }

            set
            {
                _TTLCOMTD = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? TTLCOMLY
        {
            get
            {
                return _TTLCOMLY;
            }

            set
            {
                _TTLCOMLY = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? COMSLTDT
        {
            get
            {
                return _COMSLTDT;
            }

            set
            {
                _COMSLTDT = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? COMSLLYR
        {
            get
            {
                return _COMSLLYR;
            }

            set
            {
                _COMSLLYR = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? NCOMSLTD
        {
            get
            {
                return _NCOMSLTD;
            }

            set
            {
                _NCOMSLTD = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public decimal? NCOMSLYR
        {
            get
            {
                return _NCOMSLYR;
            }

            set
            {
                _NCOMSLYR = value;
            }
        }

        [DataMember]
        [DefaultValue(1)]
        public short? KPCALHST
        {
            get
            {
                return _KPCALHST;
            }

            set
            {
                _KPCALHST = value;
            }
        }

        [DataMember]
        [DefaultValue(1)]
        public short? KPERHIST
        {
            get
            {
                return _KPERHIST;
            }

            set
            {
                _KPERHIST = value;
            }
        }

        [DataMember]
        public DateTime? MODIFDT
        {
            get
            {
                return _MODIFDT;
            }

            set
            {
                _MODIFDT = value;
            }
        }

        [DataMember]
        public DateTime? CREATDDT
        {
            get
            {
                return _CREATDDT;
            }

            set
            {
                _CREATDDT = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? COMMDEST
        {
            get
            {
                return _COMMDEST;
            }

            set
            {
                _COMMDEST = value;
            }
        }

        [DataMember]
        [DefaultValue(0)]
        public short? UpdateIfExists
        {
            get
            {
                return _UpdateIfExists;
            }

            set
            {
                _UpdateIfExists = value;
            }
        }

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
