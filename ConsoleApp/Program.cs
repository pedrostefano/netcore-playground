using System;
using System.Linq;
using DAL;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ConnectorContext())
            {
                var x = context.Connectors.Count();
                Console.WriteLine($"I have {x} connectors");
            }
        }
    }
}
