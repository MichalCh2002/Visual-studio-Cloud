using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstMVC.Helpers
{
    public class DBSettings
    {

        public Dictionary<string, string> ConnectionStrings { get; set; }
        public Int32 MaxRows { get; set; }
    }
}
