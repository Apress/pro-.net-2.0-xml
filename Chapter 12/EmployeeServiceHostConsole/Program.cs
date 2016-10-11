using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using EmployeeLibrary;

namespace ServiceHostConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Type t = typeof(EmployeeService);
            Uri tcp = new Uri("net.tcp://localhost:8010/EmployeeService");
            Uri http = new Uri("http://localhost:8000/EmployeeService");
            ServiceHost host = new ServiceHost(t, tcp, http);
            host.Open();
            Console.WriteLine("Published");
            Console.ReadLine();
            host.Close();
        }
    }
}
