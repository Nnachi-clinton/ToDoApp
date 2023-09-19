using Model.Entities;


namespace Data.DataStore.IRepository
{
    public interface ITodoItemRepository
    {
         List<ToDoItem> GetAllTodoItems();

         void AddToDoItem(ToDoItem item);

        void UpdateTodoItem(ToDoItem toDoItem);

        void DeleteTodoItem(int id);

        List<ToDoItem> SearchTodoItems(string searchCriteria);

    }
}
