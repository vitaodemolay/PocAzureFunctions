using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using PocFunctionWithServiceBus01.Infrastructure;

namespace PocFunctionWithServiceBus01.Functions
{
    public static class CustomerNewEntryProcessFunction
    {
        [FunctionName("CustomerNewEntryProcessFunction")]
        public static void Run(
            [ServiceBusTrigger(ServiceBusConfigs.XPTopicName, ServiceBusConfigs.XPSubscriptionName, Connection = "ServiceBusConnectionString")]
            string mySbMsg, 
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
