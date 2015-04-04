using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISContacts.Models
{
    class Person : ContactBase
    {
        private string _FirstName = string.Empty;
        private string _MiddleName = string.Empty;
        private string _LastName = string.Empty;
        private ObservableCollection<Phone> _PhoneNumbers;
        private ObservableCollection<Address> _Addresses;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                if (value != this._FirstName)
                {
                    this._FirstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return _MiddleName;
            }

            set
            {
                if (value != this._MiddleName)
                {
                    this._MiddleName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                if (value != this._LastName)
                {
                    this._LastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Phone> PhoneNumbers
        {
            get
            {
                return _PhoneNumbers;
            }
        }

        public ObservableCollection<Address> Addresses
        {
            get
            {
                return _Addresses;
            }
        }

        public Person()
        {
            _PhoneNumbers = new ObservableCollection<Phone>();
            _Addresses = new ObservableCollection<Address>();
        }

        public Person(string firstName, string lastName) : this()
        {
            this._FirstName = firstName;
            this._LastName = lastName;
        }

        public Person(string firstName, string lastName, Phone phone, Address address) : this(firstName, lastName)
        {
            PhoneNumbers.Add(phone);
            Addresses.Add(address);
        }

        public string FullName()
        {
            return string.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
        }

        public string LastNameFirst()
        {
            return string.Format("{0}, {1} {2}", LastName, FirstName, MiddleName);
        }
    }
}
