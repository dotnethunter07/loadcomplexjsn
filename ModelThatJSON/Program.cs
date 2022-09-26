using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ModelThatJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //repath file on your computer
            string fileName = 
                @"C:\tmp\arrays.json";

            string jsonText = File.ReadAllText(fileName);

            var data = Newtonsoft.Json.
                    JsonConvert.DeserializeObject<Whip>(jsonText);
        }
    }
}
