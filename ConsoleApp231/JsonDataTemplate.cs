using DataConverter.Service;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataConverter
{
    public class JsonDataTemplate
    {
        [JsonProperty("contacts")]
        public ICollection<Contact> Contacts { get; private set; }
        [JsonProperty("count")]
        public int Count { get; private set; }
        [JsonProperty("Log")]
        public List<string> Log { get; private set; } = new();
        public void Build(ICollection<Contact> contacts)
        {
            Contacts = contacts;
            Count = Contact.Count;

            foreach (var item in ErrorsHandler.Errors)
                Log.Add(item);

            if (Log is null)
                Log = new List<string> { "Successfull" };
        }
    }
}
