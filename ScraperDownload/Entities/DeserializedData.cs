using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Automator.Entities
{
    public class DeserializedData
    {
        public string majorDimension { get; set; }
        public string range { get; set; }
        public List<List<string>> values { get; set; }
        public object ETag { get; set; }
    }

}