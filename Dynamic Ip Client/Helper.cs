using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Ip_Client
{
    public static class Helper
    {

        public static string ProviderConvert(this string s, string domain, string ip)
        {
            return s.Replace("%DOMAIN%", domain).Replace("%IP%", ip); 
        }        
    }
}
