using Data.DataStore.IRepository;
using Model.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.DataStore.Repository
{
    public class TodoItemRepository : ITodoItemRepository
    {
        //private readonly string _connectionString;
        
        //public TodoItemRepository(string connectionString)
        //{
        //  _connectionString = connectionString;
        //}
      
        public  List<ToDoItem> GetAllTodoItems()
        {
            List<ToDoItem> todoItems = new();
            using (SqlConnection connection = new("Data Source=DESKTOP-TG1QO8U\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                string sql = "SELECT * FROM ToDoItem";
                using (SqlCommand cmd = new(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            todoItems.Add(new ToDoItem
                            {
                                Id = (int)reader["Id"],
                                TaskDescription = (string)reader["TaskDescription"],
                                IsCompleted = (bool)reader["IsCompleted"],
                                CreatedAt = (DateTime)reader["CreatedAt"],
                                UpdatedAt = (DateTime)reader["UpdatedAt"],
                                Deleted = (bool)reader["Deleted"],
                                Task = (string)reader["Task"]

                            });
                        }
                    }
                }
            }
            return todoItems;
        }


        //public  void AddToDoItem(ToDoItem todoItem)
        //{
        //    todoItem.CreatedAt = DateTime.UtcNow;
        //    todoItem.UpdatedAt = DateTime.UtcNow;
        //    using (SqlConnection connection = new("Data Source=DESKTOP-TG1QO8U\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False"))
        //    {
        //        connection.Open();
        //        string sql = "INSERT INTO ToDoItem (TaskDescription, IsCompleted, CreatedAt, UpdatedAt, Deleted, Task) " +
        //                     "VALUES (@TaskDescription, @IsCompleted, @CreatedAt, @UpdatedAt, @Deleted, @Task)";
        //        using (SqlCommand cmd = new(sql, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@TaskDescription", todoItem.TaskDescription);
        //            cmd.Parameters.AddWithValue("@IsCompleted", todoItem.IsCompleted);
        //            cmd.Parameters.AddWithValue("@CreatedAt", todoItem.CreatedAt);
        //            cmd.Parameters.AddWithValue("@UpdatedAt", todoItem.UpdatedAt);
        //            cmd.Parameters.AddWithValue("@Deleted", todoItem.Deleted);
        //            cmd.Parameters.AddWithValue("@Task", todoItem.Task);

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}


        public void AddToDoItem(ToDoItem item)
        {
            try
            {
                using (SqlConnection connection = new("Data Source=DESKTOP-TG1QO8U\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False"))
                {
                    connection.Open();

                    SqlCommand _sqlCommand = new SqlCommand("AddToDOItem", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    _sqlCommand.Parameters.AddWithValue("@Id", item.Id);
                    _sqlCommand.Parameters.AddWithValue("@TaskDescription", item.TaskDescription);
                    _sqlCommand.Parameters.AddWithValue("@IsCompleted", item.IsCompleted);
                    _sqlCommand.Parameters.AddWithValue("@CreatedAt", item.CreatedAt);
                    _sqlCommand.Parameters.AddWithValue("@UpdatedAt", item.UpdatedAt);
                    _sqlCommand.Parameters.AddWithValue("@Deleted", item.Deleted);
                    _sqlCommand.Parameters.AddWithValue("@Task", item.Task);

                    _sqlCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occured:" + ex.Message);
            }
        }



        public  void UpdateTodoItem(ToDoItem todoItem)
        {
            todoItem.UpdatedAt = DateTime.UtcNow;
            using (SqlConnection connection = new("Data Source=DESKTOP-TG1QO8U\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                string sql = "UPDATE ToDoItem SET TaskDescription = @TaskDescription, IsCompleted = @IsCompleted, UpdatedAt = @UpdatedAt, Task = @Task WHERE Id = @Id";
                using (SqlCommand cmd = new(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", todoItem.Id);
                    cmd.Parameters.AddWithValue("@TaskDescription", todoItem.TaskDescription);
                    cmd.Parameters.AddWithValue("@IsCompleted", todoItem.IsCompleted);
                    cmd.Parameters.AddWithValue("@UpdatedAt", todoItem.UpdatedAt);
                    cmd.Parameters.AddWithValue("@Task", todoItem.Task);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public  void DeleteTodoItem(int id)
        {
            using (SqlConnection connection = new("Data Source=DESKTOP-TG1QO8U\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                //string sql = "UPDATE ToDoItem SET Deleted = 1 WHERE Id = @Id";
                string sql = "DELETE FROM ToDoItem WHERE Id = @Id";
                using (SqlCommand cmd = new(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }


        }

        public  List<ToDoItem> SearchTodoItems(string searchCriteria)
        {
            List<ToDoItem> searchResults = new();
            using (SqlConnection connection = new("Data Source=DESKTOP-TG1QO8U\\SQLEXPRESS;Initial Catalog=ToDo;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                string sql;


                if (string.IsNullOrWhiteSpace(searchCriteria))
                {

                    sql = "SELECT * FROM ToDoItem";
                }
                else
                {

                    sql = "SELECT * FROM ToDoItem WHERE TaskDescription LIKE @SearchCriteria " +
                  "OR Task LIKE @SearchCriteria " +
                  "OR CreatedAt LIKE @SearchCriteria " +
                  "OR UpdatedAt LIKE @SearchCriteria";
                }

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {

                    if (!string.IsNullOrWhiteSpace(searchCriteria))
                    {
                        cmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            searchResults.Add(new ToDoItem
                            {
                                Id = (int)reader["Id"],
                                TaskDescription = (string)reader["TaskDescription"],
                                IsCompleted = (bool)reader["IsCompleted"],
                                CreatedAt = (DateTime)reader["CreatedAt"],
                                UpdatedAt = (DateTime)reader["UpdatedAt"],
                                Deleted = (bool)reader["Deleted"],
                                Task = (string)reader["Task"]
                            });
                        }
                    }
                }
            }
            return searchResults;
        }
    }
}
