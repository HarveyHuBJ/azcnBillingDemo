namespace azcnBillingDemo
{
    using System;
    using System.IO;
    using System.Net;
  
   

    public class HttpRequestService  
    {

        /// <summary>
        ///     Get the response of billing usage report request.
        /// </summary>
        /// <typeparam name="T">result Type</typeparam>
        /// <param name="url">The billing report request url</param>
        /// <param name="accessKey">The access key</param>
        /// <returns></returns>
        /// <returns>return object based on response</returns>
        public T ReadResponseWithBearToken<T>(
            string url,
            string accessKey)
        {
            WebRequest request = WebRequest.Create(url);
            request.Timeout = 600000;
            if (!string.IsNullOrEmpty(accessKey))
            {
                AddRequestHeader(request, accessKey);
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
                if (response != null &&
                    response.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string content = reader.ReadToEnd();
                        return JsonHelper.Deserialize<T>(content);
                    }
                }

                return default(T);
            }
            catch (WebException ex)
            {
                Console.WriteLine("Unexpected error occurred at get usage billing report. message = "+ex.Message, ex);
                return default(T);
            }
        }


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
            request.Headers.Add("api-version", "1.0");
        }
    }
}