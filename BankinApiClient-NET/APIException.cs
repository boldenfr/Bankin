using System;
using System.Net;
using System.Net.Http;
using System.Web;
using BankinApi.Client.Logger;

namespace BankinApi.Client
{
    public class APIException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; private set; }

        public APIException(HttpResponseMessage response)
        {
            HttpStatusCode = response.StatusCode;

            var result = response.Content.ReadAsStringAsync().Result;

            if (IsJson(result))
            {
                BankinLogger.Logger.Trace(result);
            }
            else
            {
                var message = string.Format("Exception : code [{0}] Phrase=\"{1}\" Message=\"{2}\" Result = [{3}]",
                                            response.StatusCode, response.ReasonPhrase, response.RequestMessage, result);
                BankinLogger.Logger.Trace(message);
                throw new HttpException((int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static bool IsJson(string jsonData)
        {
            if (String.IsNullOrWhiteSpace(jsonData))
            {
                return false;
            }

            return jsonData.Trim().Substring(0, 1).IndexOfAny(new[] { '[', '{' }) == 0;
        }
    }
}