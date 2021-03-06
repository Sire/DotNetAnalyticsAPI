
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class EventTracking
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The category of the event.")]
            public static DataItem eventCategory = new DataItem("eventCategory");
                                      
            [DescriptionAttribute("The action of the event.")]
            public static DataItem eventAction = new DataItem("eventAction");
                                      
            [DescriptionAttribute("The label of the event.")]
            public static DataItem eventLabel = new DataItem("eventLabel");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The total number of events for the profile, across all categories.")]
            public static DataItem totalEvents = new DataItem("totalEvents");
                                      
            [DescriptionAttribute("The total number of unique events for the profile, across all categories.")]
            public static DataItem uniqueEvents = new DataItem("uniqueEvents");
                                      
            [DescriptionAttribute("The total filter of events for the profile.")]
            public static DataItem eventValue = new DataItem("eventValue");
                                      
            [DescriptionAttribute("The total number of visits with events.")]
            public static DataItem visitsWithEvent = new DataItem("visitsWithEvent");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average filter of an event. (ga:eventValue / ga:totalEvents ) ")]
            public static DataItem avgEventValue = new DataItem("avgEventValue");
                                      
            [DescriptionAttribute("The average number of events per visit with event. (ga:totalEvents / ga:visitsWithEvent ) ")]
            public static DataItem eventsPerVisitWithEvent = new DataItem("eventsPerVisitWithEvent");
                                      
            }
        }
    }
}
