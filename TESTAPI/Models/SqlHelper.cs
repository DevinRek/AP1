using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace WebAPI.Models
{
   
    public class SQLHelper
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["postgre"].ToString();


        /// <summary>  
        /// 执行SQL语句  
        /// </summary>  
        /// <param name="sql">SQL</param>  
        /// <returns>成功返回大于0的数字</returns>  
        public static int ExecuteSQL(string sql)
        {
            int num2 = -1;
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        num2 = command.ExecuteNonQuery();
                    }
                    catch (NpgsqlException exception)
                    {
                        throw new Exception(exception.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return num2;
        }

        //带参数的执行查询，不返回结果，返回影响行数
        //执行SQL语句并返回受影响的行数
        public static int ExecuteNonQuery(string sql, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    //foreach (SqlParameter param in parameters)
                    //{
                    //    cmd.Parameters.Add(param);
                    //}
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //执行查询，并返回查询所返回的结果集中第一行的第一列。忽略额外的列或行。
        public static object ExecuteScalar(string sql, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();

                }
            }
        }




        //查询并返回结果集DataTable,一般只用来执行查询结果比较少的sql。
        public static DataTable ExecuteDataTable(string sql, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }

            //查询较大的数据用 DateRead()，但应尽可能用分页数据，仍然用datatable更好。
        }
    }
}