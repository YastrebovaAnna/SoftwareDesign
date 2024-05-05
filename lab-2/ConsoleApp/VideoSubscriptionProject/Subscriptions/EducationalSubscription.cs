using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSubscriptionProject.Subscriptions
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(80, 6, new List<string> { "Educational Channels", "Documentaries" }){ }

        public override void DisplayDetails()
        {
            Console.WriteLine("\nEducational Subscription:\n" + $"Monthly Fee: ${MonthlyFee}" + $"\nMinimum Subscription Period: {MinimumSubscriptionPeriod} month(s)" + "\n" +  string.Join(", ", Features));
        }
    }
}
