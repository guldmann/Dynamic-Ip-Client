using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Net;
using System.IO;

namespace Dynamic_Ip_Client
{
    class ProviderConnect
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public string Open(string connecitonString,string user,  string password )
        {
            logger.Trace("Using string: " + connecitonString);
            try
            {
                HttpWebRequest HWR = (HttpWebRequest)HttpWebRequest.Create(connecitonString);
                HWR.Method = "GET";
                HWR.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(user + ":" + password));
                StreamReader SR = new StreamReader(HWR.GetResponse().GetResponseStream());
                var result = SR.ReadToEnd();
                SR.Close();
                logger.Trace("Responce: " + result); 
                return result; 
            }
            catch (Exception e)
            {
                logger.Error(e.Message, "connction error ");  
                return "Error: " + e.Message ;  
            }
        }
        
    }
}
