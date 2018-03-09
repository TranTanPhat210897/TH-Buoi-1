using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace BTTHBuoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai tap 1
            String strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostName);
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            int IP = 0;
            foreach (IPAddress ipa in iphostentry.AddressList)
            {
                Console.WriteLine("IP " + ++IP + ": " +
                                  ipa.ToString());
            }
            //Bai tap 2
            Console.Write("Hostname/IP: ");
            string host = Console.ReadLine();
            IPHostEntry iphe = Dns.GetHostEntry(host);
            Console.WriteLine("Hostname: {0}", iphe.HostName);
            foreach (string s in iphe.Aliases)
                Console.WriteLine("Alias: {0} \n", s);
            foreach (IPAddress i in iphe.AddressList)
                Console.WriteLine("IP: {0}", i);
        }
    }
}
