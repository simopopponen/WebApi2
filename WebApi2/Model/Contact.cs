using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Model
{
    public class Contact
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _streetAddress;
        private string _postalCode;
        private string _city;

        public Contact (int id, string firstName, string lastName, string phone, string streetAddress, string postalCode, string city)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _streetAddress = streetAddress;
            _postalCode = postalCode;
            _city = city;
        }

        public Contact() { }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }


    }
}
