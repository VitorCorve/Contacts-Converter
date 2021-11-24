using DataConverter.Service;
using System;
using System.Collections.Generic;

namespace DataConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = FileReader.Read(Environment.CurrentDirectory + "\\data.txt");

            List<Contact> convertedData = Converter.Convert(data);

            JsonDataSerializer.Serialize(convertedData);
        }
    }
}
