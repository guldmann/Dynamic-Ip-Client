using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ip_Client
{
    class DNSProvider
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public string UrlString { get; set; }
        public bool Custom { get; set; }

        /*NOTE exemple
         * 
         * Use %IP% %HOST% %DOMAIN%  
         * 
         * to be replaced in urlStrin
         */ 

    }
    
}
