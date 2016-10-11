using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using EmployeeServer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure(Environment.CurrentDirectory + @"\EmployeeServer.config",false);
            Console.WriteLine("Employee Server Published Successfully!");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
