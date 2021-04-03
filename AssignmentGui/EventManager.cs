using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentGui
{
    public class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event[] eventList;
        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event[maxEvents];
        }
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            bool flag = false;
            if (numEvents < maxEvents)
            {
                if (!(isSameVenueOnSameDay(venue, eventDate)))
                {
                    //Console.WriteLine("addEvent--not same venue and same day");
                    Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees);
                    eventList[numEvents] = e;
                    numEvents++;
                    currentEventId++;
                    flag = true;
                }
                else
                {
                    Console.WriteLine("You cannot book the same venue on the same day as another event!");
                }
            }
            return flag;
        }
        private bool isSameVenueOnSameDay(string venue, Date eventDate)
        {
            bool flag = false;
            if (numEvents > 0)
            {
                //Console.WriteLine("isSameVenueOnSameDay()--numEvents[" + numEvents + "]");
                for (int x = 0; x < numEvents; x++)
                {
                    //  Console.WriteLine("isSameVenueOnSameDay()--venue[" + venue + "],eventDate[" + eventDate + "]");
                    //  Console.WriteLine("isSameVenueOnSameDay()--event["+x+"] venue["+ eventList[x].getVenue() + "],date["+ eventList[x].getEventDate() + "]");
                    if (eventList[x].getVenue() == venue)
                    {
                        //Console.WriteLine("isSameVenueOnSameDay()--same venue");
                        if (isSameDay(eventList[x].getDate(), eventDate))
                        {
                            //Console.WriteLine("isSameVenueOnSameD
                            flag = true;
                            break;
                        }
                    }
                }

            }
            // Console.WriteLine("isSameVenueOnSameDay()--flag["+ flag + "]");
            return flag;
        }
        private bool isSameDay(Date date_one, Date date_two)
        {
            bool flag = false;
            if ((date_one.day == date_two.day) && (date_one.month == date_two.month) && (date_one.year == date_two.year))
            {
                flag = true;
            }
            return flag;
        }
        private int findEvent(int eid)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }
        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }
        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }
        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return eventList[loc].ToString();
        }
        public string getEventList()
        {
            string s = "Event List:";
            s = s + "\r\nNumber\r\tName\r\tVenue\r\n";
            for (int x = 0; x < numEvents; x++)
            {
                s = s + eventList[x].getEventId() + "\r\t" + eventList[x].getEventName()
                   + "\r\t" + eventList[x].getVenue();
            }
            return s;
        }
    }
}
