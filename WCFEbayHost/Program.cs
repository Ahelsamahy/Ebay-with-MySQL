using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFEbayServer;

namespace WCFEbayHost
{
   class Program
   {
      static void Main(string[] args)
      {
         using (ServiceHost host = new ServiceHost(typeof(WCFEbayServer.Service1)))
         {
            host.Open();
            Console.WriteLine("Host has started @" + DateTime.Now.ToString());
            Console.ReadLine();

         }
      }
   }
}
