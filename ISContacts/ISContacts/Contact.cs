using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_IS
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public override string ToString()
        {
            return FullName + "\t" + HomePhone + "\t" + MobilePhone;
        }
    }
}
