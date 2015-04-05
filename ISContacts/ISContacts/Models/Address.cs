using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISContacts.Models
{
    public class Address : ContactBase
    {
        private int _AddressType = 0;
        private string _Street = string.Empty;
        private string _City = string.Empty;
        private string _State = string.Empty;
        private string _PostalCode = string.Empty;
        private string _Country = string.Empty;

        public int AddressType
        {
            get
            {
                return this._AddressType;
            }

            set
            {
                if (this._AddressType != value)
                {
                    this._AddressType = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Street
        {
            get
            {
                return this._Street;
            }

            set
            {
                if(this._Street != value)
                {
                    this._Street = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string City
        {
            get
            {
                return this._City;
            }

            set
            {
                if(this._City != value)
                {
                    this._City = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string State
        {
            get
            {
                return this._State;
            }

            set
            {
                if(this._State != value)
                {
                    this._State = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }

            set
            {
                if(this._PostalCode != value)
                {
                    this._PostalCode = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Country
        {
            get
            {
                return this._Country;
            }

            set
            {
                if (this._Country != value)
                {
                    this._Country = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
