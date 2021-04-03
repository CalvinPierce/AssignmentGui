using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentGui
{
    public class RegistrationManager
    {
        private static int currentRegId;
        private int maxRegs;
        private int numRegs;
        private string regDate;
        private EventRegistrations[] regList;
        public RegistrationManager(int idSeed, int max)
        {
            currentRegId = idSeed;
            maxRegs = max;
            numRegs = 0;
            regList = new EventRegistrations[maxRegs];
        }
        public bool addEventRegistration(Customer cid, Event eid)
        {
            if (numRegs >= maxRegs) { return false; }
            if ((eid.getMaxAttendees() - eid.getNumAttendees()) == 0) { return false; }
            EventRegistrations e = new EventRegistrations(regDate, currentRegId, eid, cid);
            regList[numRegs] = e;
            numRegs++;
            currentRegId++;
            return true;
        }
        public string viewAllRegistrations()
        {
            string s = "Event Registration:";
            s = s + "\r\nId\r\tDate\r\t\t\tName\r\t\tEvent Name\r\tAvaiable Spaces";
            for (int x = 0; x < numRegs; x++)
            {
                s = s + "\r\n" + regList[x].getId() + "\r\t" + regList[x].getDate() + "\r\t" + regList[x].getCustomerName() + "\r\t" + regList[x].getEventName() + "\r\t" + regList[x].getAvaiableSpaces();
            }
            return s;
        }
    }
}
