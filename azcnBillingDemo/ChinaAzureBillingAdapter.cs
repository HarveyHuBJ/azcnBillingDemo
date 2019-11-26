// Date :    2017- 09-14
// Author : Harvey Hu
// -----------------------------------------------------------------------
// <copyright file="ChinaAzureBillingAdapter.cs" company="Microsoft">
//     Microsoft@2017.
// </copyright>
// -----------------------------------------------------------------------

namespace azcnBillingDemo
{

    using System;
    using System.Collections.Generic;
    using System.Net;
  


    /// <summary>
    ///     China Azure Billing Adapter
    /// </summary>
    /// <seealso cref="ChinaAzureBillingAdapter" />
    public class ChinaAzureBillingAdapter  
    {

        /// <summary>
        ///     The usage report rest api url template
        /// </summary>
        /// <example>
        ///     rest/V5701118000/usage-report?month=2016-11&type=summary&fmt=Csv
        ///     rest/V5701118000/usage-report?month=2016-11&type=detail&fmt=Csv
        /// </example>
        private const string UsageReportApiUrlTemplate =
            "https://ea.azure.cn/rest/{0}/usage-report?month={1}&type={2}&fmt={3}";

   

        /// <summary>
        ///     Add request headers for get usage report.
        /// </summary>
        /// <param name="request">The web request</param>
        /// <param name="accessKey">The access key of usage billing request</param>
        private static void AddRequestHeader(
            WebRequest request,
            string accessKey)
        {
            string bearerTokenHeader = BearerToken.FromAccessKey(accessKey).
                BearerTokenHeader;
            request.Headers.Add("authorization", bearerTokenHeader);
            request.Headers.Add("api-version", "2014-09-02");
            //request.Headers.Add("api-version", "1.0");
        }

        private readonly HttpRequestService _httpRequestService = null;

        public ChinaAzureBillingAdapter(HttpRequestService httpRequestService)
        {
            this._httpRequestService = httpRequestService;
        }

        /// <summary>
        ///     Get the usage billing detail report.
        /// </summary>
        /// <param name="enrollmentNumber">The enrollment number.</param>
        /// <param name="accessKey">The billing report request access key.</param>
        /// <param name="month">The billing report month</param>
        /// <param name="fmtType">The report format type,default 'json'.</param>
        /// <returns>return usage detail list</returns>
        public IList<UsageDetailModel> GetUsageDetailReport(
            string enrollmentNumber,
            string accessKey,
            DateTime month,
            UsageReportFormatType fmtType = UsageReportFormatType.JSON
        )
        {
            string url = string.Format(UsageReportApiUrlTemplate,
                                       enrollmentNumber,
                                       month.ToString("yyyy-MM"),
                                       UsageReportType.Detail,
                                       fmtType);
            Console.WriteLine(string.Format("Get usage detail from {0}", url));
            return this._httpRequestService.ReadResponseWithBearToken<List<UsageDetailModel>>(url, accessKey);
        }

        /// <summary>
        ///     Get the usage billing summary report.
        /// </summary>
        /// <param name="enrollmentNumber">The enrollment number.</param>
        /// <param name="accessKey">The billing report request access key.</param>
        /// <param name="month">The billing report month</param>
        /// <param name="fmtType">The report format type,default 'json'.</param>
        /// <returns>return usage summary list</returns>
        public IList<UsageSummaryModel> GetUsageSummaryReport(
            string enrollmentNumber,
            string accessKey,
            DateTime month,
            UsageReportFormatType fmtType = UsageReportFormatType.JSON
        )
        {
            string url = string.Format(UsageReportApiUrlTemplate,
                                       enrollmentNumber,
                                       month.ToString("yyyy-MM"),
                                       UsageReportType.Summary,
                                       fmtType);
            Console.WriteLine(string.Format("Get usage summary from {0}", url));
            return this._httpRequestService.ReadResponseWithBearToken<List<UsageSummaryModel>>(url, accessKey);
        }
         

        public IList<PriceSheetModel> GetPriceSheetReport(
            string enrollmentNumber,
            string accessKey,
            DateTime month,
            UsageReportFormatType fmtType = UsageReportFormatType.JSON
        )
        {
            string url = string.Format(UsageReportApiUrlTemplate,
                                       enrollmentNumber,
                                       month.ToString("yyyy-MM"),
                                       UsageReportType.PriceSheet,
                                       fmtType);
            Console.WriteLine(string.Format("Get price sheet from {0}", url));
            return this._httpRequestService.ReadResponseWithBearToken<List<PriceSheetModel>>(url, accessKey);
        }
    }
}