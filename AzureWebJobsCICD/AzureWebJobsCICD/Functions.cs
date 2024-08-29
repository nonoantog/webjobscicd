using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureWebJobsCICD
{
    public class Functions
    {
        [NoAutomaticTrigger]
        public static void ProcessQueueMessage(ILogger logger)
        {
            logger.LogInformation($"Test Job is Running");
        }
    }
}
