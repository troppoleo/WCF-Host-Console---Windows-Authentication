using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HostConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost (typeof (ServiceLibrary.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started " + DateTime.Now.ToShortTimeString());
                Console.ReadLine();
            }
        }
    }
}
