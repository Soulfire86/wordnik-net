using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordnik_net
{
    public class WordnikClient
    {
        private readonly string _apiKey;
        private const string BaseUrl =  "http://developer.wordnik.com/v4";

        private JsonSerializerSettings _serializerSettings
        {
            get
            {
                var serializer = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    DateFormatHandling = DateFormatHandling.IsoDateFormat
                };
                serializer.Converters.Add(new StringEnumConverter { CamelCaseText = true });

                return serializer;
            }
        }

        public WordnikClient(string apiKey)
        {
            _apiKey = apiKey;
        }





    }
}
