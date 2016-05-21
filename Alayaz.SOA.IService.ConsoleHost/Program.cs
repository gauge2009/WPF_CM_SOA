using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Alayaz.SOA.IService.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FileReaderService));

            host.Open();

            Console.WriteLine("Service Host Satrt...!");
            Console.ReadLine();
        }
    }
}
