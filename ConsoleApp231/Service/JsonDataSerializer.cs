using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataConverter.Service
{
    public class JsonDataSerializer
    {
        public static void Serialize(ICollection<Contact> collection)
        {
            JsonDataTemplate data = new();

            data.Build(collection);

            var jsonData = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            File.WriteAllText(Environment.CurrentDirectory + "\\result.json", jsonData);
        }
    }
}
