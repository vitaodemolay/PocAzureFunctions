
namespace PocFunctionWithServiceBus01.Infrastructure
{
    public sealed class ServiceBusConfigs
    {

        public const string XPTopicName = "corporate/finance/sinacorexporter/service/sandbox/event/xpcustomernewentry";
        public const string XPSubscriptionName = "process-xpcustomernewentry-function";

        private ServiceBusConfigs() { }
    }
}
