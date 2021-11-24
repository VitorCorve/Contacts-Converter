using DataConverter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataConverter
{
    public class Converter
    {
        public static List<Contact> Convert(ICollection<string> collection)
        {
            List<Contact> contactsList = new();

            ContactCreator contactCreator = new();

            foreach (var item in collection)
            {
                Regex pattern = new Regex("[;,()\t\r+ ]|[\n]{2}");

                var replaced = pattern.Replace(item, " ").Replace("\t", " ").Trim();

                var name = Regex.Replace(replaced, @"[\d-]", string.Empty);

                string phoneNumber = string.Concat(item.Where(Char.IsDigit));

                contactsList.Add(contactCreator.Create(name.Split(" "), string.Concat(item.Where(Char.IsDigit))));
            }

            return contactsList;
        }
    }
}
