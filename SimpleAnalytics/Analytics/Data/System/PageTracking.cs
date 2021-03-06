
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class PageTracking
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The hostname from which the tracking request was made.")]
            public static DataItem hostname = new DataItem("hostname");
                                      
            [DescriptionAttribute("A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.")]
            public static DataItem pagePath = new DataItem("pagePath");
                                      
            [DescriptionAttribute("This dimension rolls up all the page paths in the first hierarchical level in pagePath.")]
            public static DataItem pagePathLevel1 = new DataItem("pagePathLevel1");
                                      
            [DescriptionAttribute("This dimension rolls up all the page paths in the second hierarchical level in pagePath.")]
            public static DataItem pagePathLevel2 = new DataItem("pagePathLevel2");
                                      
            [DescriptionAttribute("This dimension rolls up all the page paths in the third hierarchical level in pagePath.")]
            public static DataItem pagePathLevel3 = new DataItem("pagePathLevel3");
                                      
            [DescriptionAttribute("This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension.")]
            public static DataItem pagePathLevel4 = new DataItem("pagePathLevel4");
                                      
            [DescriptionAttribute("The title of a page. Keep in mind that multiple pages might have the same page title.")]
            public static DataItem pageTitle = new DataItem("pageTitle");
                                      
            [DescriptionAttribute("The first page in a users session, or landing page.")]
            public static DataItem landingPagePath = new DataItem("landingPagePath");
                                      
            [DescriptionAttribute("The second page in a users session.")]
            public static DataItem secondPagePath = new DataItem("secondPagePath");
                                      
            [DescriptionAttribute("The last page in a users session, or exit page.")]
            public static DataItem exitPagePath = new DataItem("exitPagePath");
                                      
            [DescriptionAttribute("A page on your property that was visited before another page on the same property. Typically used with the pagePath dimension.")]
            public static DataItem previousPagePath = new DataItem("previousPagePath");
                                      
            [DescriptionAttribute("A page on your website that was visited after another page on your website. Typically used with the previousPagePath dimension.")]
            public static DataItem nextPagePath = new DataItem("nextPagePath");
                                      
            [DescriptionAttribute("The number of pages visited by visitors during a session (visit). The filter is a histogram that counts pageviews across a range of possible values. In this calculation, all visits will have at least one pageview, and some percentage of visits will have more.")]
            public static DataItem pageDepth = new DataItem("pageDepth");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The average filter of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).")]
            public static DataItem pageValue = new DataItem("pageValue");
                                      
            [DescriptionAttribute("The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath")]
            public static DataItem entrances = new DataItem("entrances");
                                      
            [DescriptionAttribute("The total number of pageviews for your property.")]
            public static DataItem pageviews = new DataItem("pageviews");
                                      
            [DescriptionAttribute("The number of different (unique) pages within a session. This takes into both the pagePath and pageTitle to determine uniqueness.")]
            public static DataItem uniquePageviews = new DataItem("uniquePageviews");
                                      
            [DescriptionAttribute("How long a visitor spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.")]
            public static DataItem timeOnPage = new DataItem("timeOnPage");
                                      
            [DescriptionAttribute("The number of exits from your property.")]
            public static DataItem exits = new DataItem("exits");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The percentage of pageviews in which this page was the entrance. (ga:entrances / ga:pageviews ) ")]
            public static DataItem entranceRate = new DataItem("entranceRate");
                                      
            [DescriptionAttribute("The average number of pages viewed during a visit to your property. Repeated views of a single page are counted. (ga:pageviews / ga:visits ) ")]
            public static DataItem pageviewsPerVisit = new DataItem("pageviewsPerVisit");
                                      
            [DescriptionAttribute("The average amount of time visitors spent viewing this page or a set of pages. (ga:timeOnPage / (ga:pageviews - ga:exits) ) ")]
            public static DataItem avgTimeOnPage = new DataItem("avgTimeOnPage");
                                      
            [DescriptionAttribute("The percentage of exits from your property that occurred out of the total page views. (ga:exits / (ga:pageviews + ga:screenviews) ) ")]
            public static DataItem exitRate = new DataItem("exitRate");
                                      
            }
        }
    }
}
