using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Racoon.Data
{
    public class RedisRepository
    {
        private RedisContext RedisContext { get; set; }

        public RedisRepository(IContext context)
        {
            this.RedisContext = context as RedisContext;
        }

        public void Insert(RedisObject entity)
        {
            Debug.WriteLine("Inserting");
        }

        public void Delete(RedisObject entity)
        {
            Debug.WriteLine("Deleting");
        }

        public IQueryable<RedisObject> SearchFor(Expression<Func<RedisObject, bool>> predicate)
        {
            Debug.WriteLine("Searching");
            return null;
        }

        public IQueryable<RedisObject> GetAll()
        {
            Debug.WriteLine("Getting all");
            return null;
        }

        public RedisObject GetById(string id)
        {
            Debug.WriteLine("Getting : "+id);
            var redisValue = RedisContext.Db.StringGet(id);
            var redisObject = new RedisObject {Key = id, Value = redisValue.ToString()};

            return redisObject;
        }
    }
}
