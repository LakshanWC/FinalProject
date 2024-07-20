using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BEvent
    {
        public int addNewEvent(string eventName, string eventOrganizer, int eventType, int eventStatus
            , string eventDescription, string startDate, string endDate, string startTime, string endTime)
        {
            DEvent newEvent = new DEvent();
            return newEvent.addNewEvent(eventName, eventOrganizer, eventType, eventStatus
            , eventDescription, startDate, endDate, startTime, endTime);

        }
    }
}
