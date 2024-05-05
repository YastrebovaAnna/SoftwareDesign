using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSubscriptionProject.Subscriptions;

namespace VideoSubscriptionProject.Factories
{
    public class MobileApp : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}
