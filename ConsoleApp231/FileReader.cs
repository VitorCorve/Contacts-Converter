using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataConverter
{
    public class FileReader
    {
        public static List<string> Read(string path)
        {
            var file = File.ReadAllLinesAsync(path);
            return file.Result.ToList();
        }
    }
}
