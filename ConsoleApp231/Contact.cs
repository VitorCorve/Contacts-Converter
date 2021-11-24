using DataConverter.Interfaces;
using Newtonsoft.Json;

namespace DataConverter
{
    public class Contact : IContact
    {
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("middlename")]
        public string Middlename { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        public static int Count { get; set; }
    }
}
