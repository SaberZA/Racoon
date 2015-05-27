using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Racoon.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing with TeamCity Build
            var conn = ConnectionMultiplexer.Connect("localhost");
            Console.WriteLine(conn.IsConnected);
            Console.ReadLine();
        }
    }
}
