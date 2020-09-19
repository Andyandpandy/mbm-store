using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Customer
    {
        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city)
        {
            CustomerId = customerId;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }

        private DateTime birthdate;
        
        public int CustomerId;
        public string Firstname;
        public string Lastname;
        public string Address;
        public string Zip;
        public string City;
        public readonly List<string> PhoneNumbers;
        public DateTime BirthDate;
        public readonly int Age;
        public readonly List<Invoice> Invoices;


        public void AddPhoneNumber(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}