using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.ListManagement.SkillEvents;
using Alexa.NET.Request.Type;

namespace Alexa.NET
{
    public class ListSkillEventRequestTypeConverter:IRequestTypeConverter
    {
        private const string ListItemCreated = "AlexaHouseholdListEvent.ItemsCreated";
        private const string ListItemUpdated = "AlexaHouseholdListEvent.ItemsUpdated";
        private const string ListItemDeleted = "AlexaHouseholdListEvent.ItemsDeleted";
        private const string ListCreated = "AlexaHouseholdListEvent.ListCreated";
        private const string ListUpdated = "AlexaHouseholdListEvent.ListUpdated";
        private const string ListDeleted = "AlexaHouseholdListEvent.ListDeleted";

        public bool CanConvert(string requestType)
        {
            return requestType == ListItemCreated ||
                   requestType == ListItemUpdated ||
                   requestType == ListItemDeleted ||
                   requestType == ListCreated ||
                   requestType == ListUpdated ||
                   requestType == ListDeleted;
        }

        public Request.Type.Request Convert(string requestType)
        {
            switch (requestType)
            {
                case ListItemCreated:
                    return new ListSkillItemCreatedRequest();
                case ListItemUpdated:
                    return new ListSkillItemUpdatedRequest();
                case ListItemDeleted:
                    return new ListSkillItemDeletedRequest();
                case ListCreated:
                    return new ListSkillListCreatedRequest();
                case ListUpdated:
                    return new ListSkillListUpdatedRequest();
                case ListDeleted:
                    return new ListSkillListDeletedRequest();
            }

            return null;
        }
    }
}
