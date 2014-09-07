using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Data
{
    public class RedisObject : IBusinessObject
    {
        public String Key { get; set; }
        public String Value { get; set; }
    }
}
