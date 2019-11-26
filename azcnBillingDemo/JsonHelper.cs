// Date :    2017- 08-03
// Author : Harvey Hu
// -----------------------------------------------------------------------
// <copyright file="JsonHelper.cs" company="Microsoft">
//     Microsoft@2017.
// </copyright>
// -----------------------------------------------------------------------

namespace azcnBillingDemo
{
    using Newtonsoft.Json;

    /// <summary>
    ///     Class JsonHelper.
    /// </summary>
    public static class JsonHelper
    {
        /// <summary>
        ///     把 json 字 符 串 转 成 对 象
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="data">json 字 符 串</param>
        /// <returns>The element type of deserialize object.</returns>
        public static T Deserialize<T>(
            string data)
        {
            T result = JsonConvert.DeserializeObject<T>(data);
            return result;
        }

        /// <summary>
        ///     把 对 象 转 成 json 字 符 串
        /// </summary>
        /// <param name="obj">对 象</param>
        /// <param name="indented">if set to <c>true</c> [indented].</param>
        /// <returns>The json 字 符 串</returns>
        public static string Serialize(
            object obj,
            bool indented = false)
        {
            string result = JsonConvert.SerializeObject(
                                                        obj,
                                                        indented ? Formatting.Indented : Formatting.None);
            return result;
        }

        /// <summary>
        ///     Serializes the with microsoft date format -- \/Date(238333333333)\/.
        ///     Normally, date format is iso format:  "2000-01-01T19:00:00,888"
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>The System.String.</returns>
        public static string SerializeWithMicrosofDateFormat(
            object obj)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                                                                 {
                                                                     DateFormatHandling =
                                                                         DateFormatHandling.MicrosoftDateFormat
                                                                 };

            string result = JsonConvert.SerializeObject(obj, microsoftDateFormatSettings);
            return result;
        }
    }
}