using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSubscriptionProject.Subscriptions
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(120, 1, new List<string> { "Basic Channels", "News Channels" }){}

        public override void DisplayDetails()
        {
            Console.WriteLine("\nDomestic Subscription:\n" + $"Monthly Fee: ${MonthlyFee}" + $"\nMinimum Subscription Period: {MinimumSubscriptionPeriod} month(s)"  + "\n" +  string.Join(", ", Features));
        }
    }
}
