using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ip_Client
{
    class Groupe
    {
        public string Name { get; set; }
        private List<string>  domains { get; }= new List<string>();
        public DNSProvider DnsProvider { get; set; }
        public  string Username { get; set; }
        public  string Password { get; set; }
        public void AddDomain(string domain)
        {
            domains.Add(domain);
        }
    }
}
