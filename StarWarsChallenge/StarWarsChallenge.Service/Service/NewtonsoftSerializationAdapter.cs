﻿using Newtonsoft.Json;
using RestClient.Net.Abstractions;
using System.Text;

namespace StarWarsChallenge.Service.Service
{
    public class NewtonsoftSerializationAdapter : ISerializationAdapter
    {
        #region Implementation
        public TResponseBody Deserialize<TResponseBody>(RestClient.Net.Abstractions.Response response)
        {
            //Note: on some services the headers should be checked for encoding 
            var markup = Encoding.UTF8.GetString(response.GetResponseData());

            object markupAsObject = markup;

            if (typeof(TResponseBody) == typeof(string))
            {
                return (TResponseBody)markupAsObject;
            }

            return JsonConvert.DeserializeObject<TResponseBody>(markup);
        }

        public byte[] Serialize<TRequestBody>(TRequestBody value, IHeadersCollection requestHeaders)
        {
            var json = JsonConvert.SerializeObject(value);

            var binary = Encoding.UTF8.GetBytes(json);

            return binary;
        }
        #endregion
    }
}
