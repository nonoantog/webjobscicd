using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureWebJobsCICD_2
{
    public class Functions
    {
        [NoAutomaticTrigger]
        public static void ProcessQueueMessage(ILogger logger)
        {
            logger.LogInformation($"Test Job 2 is Running");
        }
    }
}
