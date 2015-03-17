using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace wordnik_net.Models
{
    public class WordList
    {
        [DefaultValue(0)]
        public long Id { get; set; }
        public string Permalink { get; set; }
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? LastActivityAt { get; set; }
        public string UserName { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public long NumberWordsInList { get; set; }
        public string Type { get; set; }
    }

    public class WordListWord
    {
        public long Id { get; set; }
        public string Word { get; set; }
        public string Username { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long NumberCommentsOnWord { get; set; }
        public long NumberLists { get; set; }
    }
}