using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class TESTController : ApiController
    {
        // GET: api/TEST
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TEST/5
        //可以改变路由的名称
        [ActionNameAttribute("RightNotIndex")]
        public string Get(int id)
        {
            return "This is "+id;
        }

       /// <summary>
       /// Post请求;
       /// 直接使用Post方法请求
       /// </summary>
       /// <param name="p"></param>
       /// <returns></returns>
        [HttpPost ]
        public string  Post([FromBody] Persion p)
        {

            if(p==null)
            {
                return "Name null";
            }
            if (p.Name == "zhangsan")
            {
                return "Hellow"+p.Name ;
            }
            else
            {
                return "409";
            }
        }
        // PUT: api/TEST/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TEST/5
        public void Delete(int id)
        {
        }
    }
}
