using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedisExample.Controllers
{
    [Route("api/redis")]
    public class RexisController : Controller
    {
        private readonly IRedisService _redisService = null;
        public RexisController(IRedisService redisService)
        {
            _redisService = redisService;
        }


        [Route("{key}/{value}")]
        [HttpPost]
        public void SetValueByKey(string key, string value)
        {
            _redisService.Set(key, value);
        }

        [Route("{key}")]
        [HttpGet]
        public string GetValueByKey(string key)
        {
            var result =  _redisService.Get(key);
            return result;
        }
    }
}
