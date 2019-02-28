using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedisExample.Controllers
{
    [Route("api/todo")]
    public class TodoController : Controller
    {
        public class TodoItem
        {
            public string To { get; set; }
            public string Do { get; set; }
        }

        private static List<TodoItem> items = new List<TodoItem>
        {
            new TodoItem
            {
                Do = "Happy",
                To = "Beijing",
            },
            new TodoItem
            {
                Do = "Happy2",
                To = "Shanghai",
            },
            new TodoItem
            {
                Do = "Happy3",
                To = "Shenzhen",
            },
        };

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all")]
        public List<TodoItem> GetAll()
        {
            return items;
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="item"></param>
        [HttpPost]
        [Route("")]
        public void Add([FromBody] TodoItem item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("")]
        public bool Delete (string to)
        {
            var i = items.Find(p => p.To == to);
            return items.Remove(i);
        }
    }

}
