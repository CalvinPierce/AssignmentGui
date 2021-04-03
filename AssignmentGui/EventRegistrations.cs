using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentGui
{
    public class EventRegistrations
    {
        private int regId;
        private string date;
        private Customer cid;
        private Event eid;
        public EventRegistrations(string date, int regId, Event eid, Customer cid)
        {
            this.regId = regId;
            this.eid = eid;
            this.cid = cid;
            this.date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }
        public int getId() { return regId; }
        public string getDate() { return date; }
        public string getCustomerName() { return cid.getFirstName() + " " + cid.getLastName(); }
        public string getEventName() { return eid.getEventName(); }
        public int getAvaiableSpaces() { return eid.getMaxAttendees() - eid.getNumAttendees(); }
        public override string ToString()
        {
            string s = "Registration: " + regId;
            s = "\r\nDate: " + date;
            s = "\r\nCustomer Name: " + cid.getFirstName() + " " + cid.getLastName();
            s = "\r\nEvent Name: " + eid.getEventName();
            return s;
        }
    }
}
