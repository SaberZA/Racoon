using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Data
{
    public class User : BusinessObject
    {
        public String Name { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
    }
}
