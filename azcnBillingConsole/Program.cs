using azcnBillingDemo;
using System;

namespace azcnBillingConsole
{
    internal class Program
    {
        private static readonly string enrollmentNumber = "V5701611S0381";
        private static readonly string accessKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6InJtSUhHNjNQZElOcWxQenFnQWd1eXZISzdMbyJ9.eyJFbnJvbGxtZW50TnVtYmVyIjoiVjU3MDE2MTFTMDM4MSIsIklkIjoiYWJiYjU5OGUtNjIwNy00N2ZkLWJiNDgtNGQ2YjFmZDRiNWY3IiwiUmVwb3J0VmlldyI6IkVudGVycHJpc2UiLCJQYXJ0bmVySWQiOiIiLCJEZXBhcnRtZW50SWQiOiIiLCJBY2NvdW50SWQiOiIiLCJpc3MiOiJlYS5taWNyb3NvZnRhenVyZS5jb20iLCJhdWQiOiJjbGllbnQuZWEubWljcm9zb2Z0YXp1cmUuY29tIiwiZXhwIjoxNTgwMzY0ODc4LCJuYmYiOjE1NjQ0NjcyNzh9.lwdnXPTF-aadTp0-H3L8M7KTCGsJoBNkY0if1o3K2VdSw7QJiM7cCjSh57juueadI22l0q0RnZTGRvgXfEv2o4CqP0bKt2esyq6-UbKL-y51nlRQSetvlfU3NXwuK6n3oi6wfTaqDAdf1u2Y1ozaQDnJc1lUhospBIpChWm0ocZwS_qjy9KiEzG5xc4EMHzYgnk1noRSk_7gUO-3Ed3VyPf5nJp29UdxV33u0rde6O7zdyIf6ZMaMiieCiAGHoqsc7M_h0-ZSk0wLBjhpXih_ntTbCaAIAnUIFhaWyUYJR6zFzreFHIS-TE-Tsk7bwfFwKJq15rCmZ2aTEnM37nGVA";

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
