
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Systems
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The versions of Flash supported by visitors browsers, including minor versions.")]
            public static DataItem flashVersion = new DataItem("flashVersion");
                                      
            [DescriptionAttribute("Indicates Java support for visitors browsers. The possible values are Yes or No where the first letter must be capitalized.")]
            public static DataItem javaEnabled = new DataItem("javaEnabled");
                                      
            [DescriptionAttribute("The language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English).")]
            public static DataItem language = new DataItem("language");
                                      
            [DescriptionAttribute("The color depth of visitors monitors, as retrieved from the DOM of the visitors browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.")]
            public static DataItem screenColors = new DataItem("screenColors");
                                      
            [DescriptionAttribute("The screen resolution of visitors monitors, as retrieved from the DOM of the visitors browser. For example: 1024x738.")]
            public static DataItem screenResolution = new DataItem("screenResolution");
                                      
        }

        public sealed class Metrics
        {
            

            public sealed class Calculated
            {
                
            }
        }
    }
}
