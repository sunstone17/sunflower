using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisExample.Options
{
    public class RedisOption : IOptions<RedisOption>
    {
        public string Server { get; set; }
        public string Password { get; set; }

        public RedisOption Value => this;
    }
}
