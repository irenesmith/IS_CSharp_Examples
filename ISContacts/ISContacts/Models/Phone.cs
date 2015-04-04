using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISContacts.Models
{
    class Phone : ContactBase
    {
        private string _Number = string.Empty;
        private int _NumberType = 0;

        public string Number
        {
            get
            {
                return this._Number;
            }

            set
            {
                if (value != this._Number)
                {
                    this._Number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int NumberType
        {
            get
            {
                return _NumberType;
            }

            set
            {
                if(value != this._NumberType)
                {
                    this._NumberType = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
