using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstAPI.Helpers
{
    public class DBSettings
    {
        public string ConnectionStringPV { get; set; }
        public string ConnectionStringLocal { get; set; }
        public Int32 MaxRows { get; set; }

    }
}
