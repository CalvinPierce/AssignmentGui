using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentGui
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;
        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }
        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public void incrementBookings() { bookings++; }
        public int getNumBookings() { return bookings; }
        public bool registeredEvents()
        {
            return true;
        }
        public override string ToString()
        {
            string s = "Customer " + customerId;
            s = s + "\r\nName: " + firstName + " " + lastName;
            s = s + "\r\nPhone: " + phone;
            s = s + "\r\nBookings: " + bookings;
            return s;
        }
    }
}
