using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CADsisVenta
{
    public class IpFinder
    {
        public static IPAddress GetExternalIp()
        {
            //"http://www.cual-es-mi-ip.net//";
            string whatIsMyIp = "http://checkip.dyndns.org/";
            string getIpRegex = @"(?<=<body>.*)\d*\.\d*\.\d*\.\d*(?=</body>)";
            WebClient wc = new WebClient();
            UTF8Encoding utf8 = new UTF8Encoding();
            string requestHtml = "";
            try
            {
                requestHtml = utf8.GetString(wc.DownloadData(whatIsMyIp));
            }
            catch (WebException we)
            {
                // do something with exception
                Console.Write(we.ToString());
            }
            Regex r = new Regex(getIpRegex);
            Match m = r.Match(requestHtml);
            IPAddress externalIp = null;
            if (m.Success)
            {
                externalIp = IPAddress.Parse(m.Value);
            }
            return externalIp;
        }
    }

}
