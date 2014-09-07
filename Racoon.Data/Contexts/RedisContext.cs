using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Racoon.Data
{
    public class RedisContext : IContext
    {
        private readonly String ConnectionString = "localhost";
        private ConnectionMultiplexer Connection = null;
        public IDatabase Db { get; private set; }

        public RedisContext(string connectionString = "localhost")
        {
            ConnectionString = connectionString;
            Open();
        }

        public void Open()
        {
            Connection = ConnectionMultiplexer.Connect(ConnectionString);
            Db = Connection.GetDatabase();
            Debug.WriteLine(Connection.IsConnected);
        }

        public void Close(bool allowOperationsToFinish)
        {
            Connection.Close(allowOperationsToFinish);
        }
    }
}
