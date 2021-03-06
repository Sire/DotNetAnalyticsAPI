
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class GoalConversions
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The page path or screen name that matched any destination type goal completion.")]
            public static DataItem goalCompletionLocation = new DataItem("goalCompletionLocation");
                                      
            [DescriptionAttribute("The page path or screen name that matched any destination type goal, one step prior to the goal completion location.")]
            public static DataItem goalPreviousStep1 = new DataItem("goalPreviousStep1");
                                      
            [DescriptionAttribute("The page path or screen name that matched any destination type goal, two steps prior to the goal completion location.")]
            public static DataItem goalPreviousStep2 = new DataItem("goalPreviousStep2");
                                      
            [DescriptionAttribute("The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.")]
            public static DataItem goalPreviousStep3 = new DataItem("goalPreviousStep3");
                                      
        }

        public sealed class Metrics
        {

			[DescriptionAttribute("The total number of starts for the requested goal number.")]
			public static DataItem goalXXStarts(int index) { return new DataItem("goalXXStarts", index); }

			[DescriptionAttribute("The total number of starts for all goals defined for your profile.")]
			public static DataItem goalStartsAll = new DataItem("goalStartsAll");

			[DescriptionAttribute("The total number of completions for the requested goal number.")]
			public static DataItem goalXXCompletions(int index) { return new DataItem("goalXXCompletions", index); }

			[DescriptionAttribute("The total number of completions for all goals defined for your profile.")]
			public static DataItem goalCompletionsAll = new DataItem("goalCompletionsAll");

			[DescriptionAttribute("The total numeric filter for the requested goal number.")]
			public static DataItem goalXXValue(int index) { return new DataItem("goalXXValue", index); }

			[DescriptionAttribute("The total numeric filter for all goals defined for your profile.")]
			public static DataItem goalValueAll = new DataItem("goalValueAll");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average goal filter of a visit to your property. ((ga:goalValueAll / ga:visits) ) ")]
            public static DataItem goalValuePerVisit = new DataItem("goalValuePerVisit");

			[DescriptionAttribute("The percentage of visits which resulted in a conversion to the requested goal number. (ga:goalXXCompletions / ga:visits ) ")]
			public static DataItem goalXXConversionRate(int index) { return new DataItem("goalXXConversionRate", index); }

			[DescriptionAttribute("The percentage of visits which resulted in a conversion to at least one of your goals. (ga:goalCompletionsAll / ga:visits ) ")]
			public static DataItem goalConversionRateAll = new DataItem("goalConversionRateAll");

			[DescriptionAttribute("The number of times visitors started conversion activity on the requested goal number without actually completing it. ((ga:goalXXStarts - ga:goalXXCompletions) ) ")]
			public static DataItem goalXXAbandons(int index) { return new DataItem("goalXXAbandons", index); }

			[DescriptionAttribute("The overall number of times visitors started goals without actually completing them. ((ga:goalStartsAll - ga:goalCompletionsAll) ) ")]
			public static DataItem goalAbandonsAll = new DataItem("goalAbandonsAll");

			[DescriptionAttribute("The rate at which the requested goal number was abandoned. (((ga:goalXXStarts - ga:goalXXCompletions)) / (ga:goalXXStarts) ) ")]
			public static DataItem goalXXAbandonRate(int index) { return new DataItem("goalXXAbandonRate", index); }
                                      
            [DescriptionAttribute("The rate at which goals were abandoned. (((ga:goalStartsAll - ga:goalCompletionsAll)) / (ga:goalStartsAll) ) ")]
            public static DataItem goalAbandonRateAll = new DataItem("goalAbandonRateAll");
                                      
            }
        }
    }
}
