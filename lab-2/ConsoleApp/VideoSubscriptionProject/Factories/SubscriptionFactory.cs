using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSubscriptionProject.Subscriptions;

namespace VideoSubscriptionProject.Factories
{
    public abstract class SubscriptionFactory
    {
        public abstract Subscription CreateSubscription();
    }
}
