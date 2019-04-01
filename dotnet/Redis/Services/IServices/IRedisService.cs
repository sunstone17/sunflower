using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IRedisService
    {
        void Set(string key, string value);

        string Get(string key);
    }
}
