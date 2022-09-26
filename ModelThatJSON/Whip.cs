using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelThatJSON
{
    public class Whip
    {
        public vehicle[] cars { get; set; }
        public vehicle[] trucks { get; set; }
    }

    public class vehicle
    {
        public string brand { get; set; }
        public _model[] models { get; set; }
    }

    public class _model
    {
        public string model { get; set; }
        //public int? basePrice { get; set; }
        public string[] colors { get; set; }
    }

}
