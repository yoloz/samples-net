using MySql.Data.MySqlClient;

namespace AdoNet
{
    public class MysqlDemo
    {
        public void ExecuteQuery()
        {
            // 连接字符串
            string connectionString = "server=127.0.0.1;port=10001;database=mysql;uid=mysql;pwd=test;";
            using MySqlConnection connection = new(connectionString);
            try
            {
                // 打开连接
                connection.Open();
                // 创建命令对象
                using MySqlCommand command = new();
                command.Connection = connection;
                command.CommandText = @"SELECT TABLE_NAME FROM information_schema.TABLES t WHERE TABLE_SCHEMA=@schemaName";
                command.Parameters.AddWithValue("@schemaName", "ggbond");
                // 执行查询并读取结果
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("TABLE_NAME");
                    Console.WriteLine($"Name: {name}");
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