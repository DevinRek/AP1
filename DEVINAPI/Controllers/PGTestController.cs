using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PGTestController : ApiController
    {
        // GET: api/PGTest
        //get 数据返回list <string>集合
        public IEnumerable<string> Get()
        {
            string sql = @"
SELECT 
tenant_code,code,name,* 
FROM 
auth_user_infobase;";
            DataTable db = SQLHelper.ExecuteDataTable(sql);
            int a = SQLHelper.ExecuteSQL(sql);
            string s = db.Rows[0].Table.ToString();
            List<string> list = new List<string>();
            foreach (DataRow item in db.Rows)
            {
                list.Add(item["name"].ToString());
            }
            s = db.Rows[1]["createdon"].ToString();
            return list;
        }
        //修改name的SQL语句
        // GET: api/PGTest/5
        //返回string类型
        public string Get(int id)
        {
            string sql = @"
update
auth_user_infobase 
set 
name=test 
where 
id=@id";
            int resout = SQLHelper.ExecuteNonQuery(sql,
                new Npgsql.NpgsqlParameter("@id", id));
            return resout.ToString();
        }

        // POST: api/PGTest
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/PGTest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PGTest/5
        //删除指定ID的数据，请求方法为DELETE
        public void Delete(int id)
        {
            string sql = @"
delete  
from 
auth_user_infobase 
where 
age=@id
";
            SQLHelper.ExecuteNonQuery(sql,
              new Npgsql.NpgsqlParameter("@id", id));
        }
    }
}
