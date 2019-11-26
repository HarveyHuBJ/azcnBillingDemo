using azcnBillingDemo;
using System;

namespace azcnBillingConsole
{
    internal class Program
    {
        private static readonly string enrollmentNumber = "V5701611S0381";
        private static readonly string accessKey = "{replace the access key of yours here}";
        // private static readonly string accessKey = "eyJ0eXAiOiJKV1QiLCJhbG.........................";

        private static void Main(string[] args)
        {

            ChinaAzureBillingAdapter adapter = new ChinaAzureBillingAdapter(
                 new HttpRequestService());

            System.Collections.Generic.IList<PriceSheetModel> s1 = adapter.GetPriceSheetReport(enrollmentNumber, accessKey, DateTime.Now.AddMonths(-1));
           //var s2 = adapter.GetUsageDetailReport(enrollmentNumber, accessKey, DateTime.Now.AddMonths(-1));
            var s3 = adapter.GetUsageSummaryReport(enrollmentNumber, accessKey, DateTime.Now.AddMonths(-1));

            Console.WriteLine($"PriceSheet lines = {s1.Count}");
           // Console.WriteLine($"UsageDetail lines = {s2.Count}");
            Console.WriteLine($"UsageSummary lines = {s3.Count}");
        }
    }
}
