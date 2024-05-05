using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSubscriptionProject.Subscriptions;

namespace VideoSubscriptionProject.Factories
{
    public class WebSite : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            return new PremiumSubscription(); 
        }
    }
}
