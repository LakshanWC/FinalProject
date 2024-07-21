using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int updateEvent(int eventId, string eventName, string eventOrganizer, int eventType, int eventStatus
            , string eventDescription, string startDate, string endDate, string startTime, string endTime)
        {
            DEvent newEvent = new DEvent();
            return newEvent.updateEvent(eventId ,eventName, eventOrganizer, eventType, eventStatus
            , eventDescription, startDate, endDate, startTime, endTime);
        }

        public int getEventId()
        {
            DEvent eventId = new DEvent();
            return eventId.getEventId();
        }

        public DataSet getEventNames(bool isloadById) 
        {
            DEvent dEvent = new DEvent();
            return dEvent.getEventNames(isloadById);
        }
        public DataSet getAllEvents(bool isloadById) 
        {
            DEvent allEvent = new DEvent();
            return allEvent.getAllEvents(isloadById);
        }
    }   
}
