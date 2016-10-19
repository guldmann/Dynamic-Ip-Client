using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ip_Client
{
    class Router
    {
        public string Path { get; set; }
        public string Regex { get; set; }
        public string Name { get; set; }
        public bool Custom { get; set; }
    }
}
