using System;
using System.Diagnostics;
using System.Net.Http;

namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando comando....");
            Console.WriteLine("UserName: {0}", Environment.UserName);
            var os = new SystemInformationService().GetOperationSystemInformationService();
            Console.WriteLine(os.memory);
            Console.WriteLine(os.oSName);
            Console.WriteLine(os.ipAddress);
        }
    }
}
