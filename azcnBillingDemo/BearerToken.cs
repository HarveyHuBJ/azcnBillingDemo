// Date :    2017- 09-14
// Author : Harvey Hu
// -----------------------------------------------------------------------
// <copyright file="BearerToken.cs" company="Microsoft">
//     Microsoft@2017.
// </copyright>
// -----------------------------------------------------------------------

namespace azcnBillingDemo
{
    using System;

    /// <summary>
    ///     This class is a representation of a bearer token, the token in the authorization header.
    /// </summary>
    internal class BearerToken
    {
        private BearerToken()
        {
        }

        /// <summary>
        ///     "bearer "+access key in our case
        /// </summary>
        public string BearerTokenHeader { get; private set; }

        /// <summary>
        ///     the access key in our case.
        /// </summary>
        public string Token { get; private set; }

        /// <summary>
        ///     Convert access key string to BearerToken object.
        /// </summary>
        public static BearerToken FromAccessKey(
            string accessKey)
        {
            string bearerToken = string.Concat("bearer ", accessKey);
            return Parse(bearerToken);
        }

        /// <summary>
        ///     Parse the authorization header into BearerToken, which is used as auth token in our case.
        ///     header looks like
        ///     authorization: bearer {access key}.
        /// </summary>
        /// <param name="tokenHeader"></param>
        /// <returns></returns>
        public static BearerToken Parse(
            string tokenHeader)
        {
            if (!tokenHeader.StartsWith("bearer", StringComparison.InvariantCultureIgnoreCase) ||
                tokenHeader.Length < 8) //meaning the string after "bearer " is empty
            {
                throw new InvalidOperationException("not a valid bearer token");
            }

            return new BearerToken
                   {
                       Token = tokenHeader.Substring(7),
                       BearerTokenHeader = tokenHeader
                   }; //"bearer "
        }
    }
}