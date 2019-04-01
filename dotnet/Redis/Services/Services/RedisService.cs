using Microsoft.Extensions.Options;
using RedisExample.Options;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class RedisService : IRedisService
    {
        private RedisOption _redisOption = null;
        private IDatabase _database = null;

        #region Redis DB
        public RedisService(IOptions<RedisOption> options)
        {
            _redisOption = options.Value;
            InitDatabse();
        }

        private void InitDatabse()
        {
            var config = ConfigurationOptions.Parse(_redisOption.Server);
            config.Password = _redisOption.Password;
            var connection = ConnectionMultiplexer.Connect(config);
            _database = connection.GetDatabase();
        }

        #endregion

        public void Set(string key, string value)
        {
            var result = _database.StringSet(key, value);
        }

        public string Get(string key)
        {
            return _database.StringGet(key);
        }

    }
}
