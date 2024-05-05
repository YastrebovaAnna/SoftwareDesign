using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSubscriptionProject.Subscriptions
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumSubscriptionPeriod { get; set; }
        public List<string> Features { get; set; }

        public Subscription(decimal monthlyFee, int minimumPeriod, List<string> features)
        {
            MonthlyFee = monthlyFee;
            MinimumSubscriptionPeriod = minimumPeriod;
            Features = new List<string>(features);
        }

        public abstract void DisplayDetails();
    }
}
