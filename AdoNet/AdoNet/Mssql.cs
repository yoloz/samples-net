// using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace AdoNet
{
    public class SqlServerDemo
    {
        public void ExecuteQuery()
        {
            // 连接字符串:https://learn.microsoft.com/zh-cn/dotnet/framework/data/adonet/connection-string-syntax?redirectedfrom=MSDN
            string connectionString = "Server=127.0.0.1,10001;Database=mssql;User Id=test;Password=xxx;Encrypt=false;TrustServerCertificate=false;";
            // SQL 查询语句
            string query = "SELECT DISTINCT s.name FROM sys.sysobjects t,sys.schemas s WHERE t.xtype ='U' and t.uid = s.schema_id";
            using SqlConnection connection = new(connectionString);
            try
            {
                // 打开连接
                connection.Open();
                // 创建命令对象
                using SqlCommand command = new(query, connection);
                // 执行查询并读取结果
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Name: {reader["name"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}