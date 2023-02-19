using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignPatternDemo
{
    public class Program
    {
        static TableServers Host1List = TableServers.GetTableServers();
        static TableServers Host2List = TableServers.GetTableServers();

        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
        }
        private static void Host1GetNextServer()
        {
            Console.WriteLine("The Next Server Is " + Host1List.GetTheNextServer());
        }
        private static void Host2GetNextServer()
        {
            Console.WriteLine("The Next Server Is " + Host2List.GetTheNextServer());
        }
    }
}
