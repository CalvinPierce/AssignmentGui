using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentGui
{
    public class Event
    {
        private int eventId;
        private string eventName;
        private string venue;
        private Date eventDate;
        private int maxAttendees;
        private int numAttendees;
        private string dateCreated;
        private Customer[] attendeeList;
        public Event(int eventId, string name, string venue, Date eventDate, int maxAttendees)
        {
            this.eventId = eventId;
            this.eventName = name;
            this.venue = venue;
            this.eventDate = eventDate;
            this.maxAttendees = maxAttendees;
            numAttendees = 0;
            attendeeList = new Customer[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }
        public int getEventId() { return eventId; }
        public string getEventName() { return eventName; }
        public string getVenue() { return venue; }
        public int getMaxAttendees() { return maxAttendees; }
        public int getNumAttendees() { return numAttendees; }
        public bool addAttendee(Customer c)
        {
            if (numAttendees >= maxAttendees) { return false; }
            attendeeList[numAttendees] = c;
            numAttendees++;
            return true;
        }
        private int findAttendee(int custId)
        {
            for (int x = 0; x < maxAttendees; x++)
            {
                if (attendeeList[x].getId() == custId)
                    return x;
            }
            return -1;
        }
        public Date getDate()
        {
            return eventDate;
        }
        public bool removeAttendee(int custId)
        {
            int loc = findAttendee(custId);
            if (loc == -1) return false;
            attendeeList[loc] = attendeeList[numAttendees - 1];
            numAttendees--;
            return true;
        }
        public string getAttendees()
        {
            string s = "\nCustomers registered :";
            for (int x = 0; x < numAttendees; x++)
            {
                s = s + "\n" + attendeeList[x].getId() + " " + attendeeList[x].getFirstName() + " " +
               attendeeList[x].getLastName();
            }
            return s;
        }
        public override string ToString()
        {
            string s = "Event: " + eventId + "\r\nName: " + eventName;
            s = s + "\r\nVenue: " + venue;
            s = s + "\r\nDate:" + eventDate;
            s = s + "\r\nRegistered Attendees:" + numAttendees;
            s = s + "\r\nAvailable spaces:" + (maxAttendees - numAttendees);
            s = s + "\r\n" + getAttendees();
            return s;
        }
    }
}
