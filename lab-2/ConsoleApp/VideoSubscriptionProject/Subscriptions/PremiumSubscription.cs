using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSubscriptionProject.Subscriptions
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(250, 1, new List<string> { "All Channels", "High Definition", "Multiple Streams", "Sport Channels" }){}

        public override void DisplayDetails()
        {
            Console.WriteLine("\nPremium Subscription:\n" + $"Monthly Fee: ${MonthlyFee}" + $"\nMinimum Subscription Period: {MinimumSubscriptionPeriod} month(s)" + "\n" + string.Join(", ", Features));
        }
    }
}
