using Data.DataStore.IRepository;
using Data.DataStore.Repository;
using Model.Entities;
using System.ComponentModel;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public Form1(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public Form1()
        {
            InitializeComponent();
        }

        DataTable toDoList = new();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            tittleTextbox.Text = "";
            descriptionTextBox.Text = "";
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string taskDescription = descriptionTextBox.Text.Trim();
                string tittleDescription = tittleTextbox.Text.Trim();
                if (!string.IsNullOrEmpty(taskDescription) && !string.IsNullOrEmpty(tittleDescription))
                {
                    //ToDoItem newItem = new()
                    var newItem = new ToDoItem()
                    {
                        Task = tittleDescription,
                        TaskDescription = taskDescription,
                        IsCompleted = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Deleted = true
                    };
                    //_todoItemRepository.AddToDoItem(newItem);
                    _todoItemRepository.AddToDoItem(newItem);
                    descriptionTextBox.Text = string.Empty;
                    tittleTextbox.Text = string.Empty;
                    RefreshTodoList();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                if (selectedRow is not null)
                {
                    int itemId = (int)selectedRow.Cells["Id"].Value;
                    string newTaskDescription = descriptionTextBox.Text.Trim();
                    string newTittleDescription = tittleTextbox.Text.Trim();

                    // Populate the text boxes with values from the selected row
                    descriptionTextBox.Text = (string)selectedRow.Cells["TaskDescription"].Value;
                    tittleTextbox.Text = (string)selectedRow.Cells["Task"].Value;

                    // Update the DataGridViewRow with edited values
                    selectedRow.Cells["TaskDescription"].Value = newTaskDescription;
                    selectedRow.Cells["Task"].Value = newTittleDescription;

                    ToDoItem updatedItem = new()
                    {
                        Id = itemId,
                        Task = newTittleDescription,
                        TaskDescription = newTaskDescription,
                        IsCompleted = false,
                        UpdatedAt = DateTime.UtcNow,
                        Deleted = false
                    };

                    // Update the database with the edited values
                  //  TodoItemRepository.UpdateTodoItem(updatedItem);
                    _todoItemRepository.UpdateTodoItem(updatedItem);
                    descriptionTextBox.Text = string.Empty;
                    tittleTextbox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }

        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                if (selectedRow is not null)
                {
                    int itemId = (int)selectedRow.Cells["Id"].Value;

                    // Delete the item from the database
                    //TodoItemRepository.DeleteTodoItem(itemId);

                    _todoItemRepository.DeleteTodoItem(itemId);

                    // Remove the selected row from the DataGridView
                    int rowIndex = dataGridView1.CurrentRow.Index;
                    RefreshTodoList();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCriteria = SearchTextBox.Text.Trim();
                List<ToDoItem> searchResults = _todoItemRepository.SearchTodoItems(searchCriteria);
                dataGridView1.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }


        private void RefreshTodoList()
        {
            try
            {
                List<ToDoItem> todoItems = _todoItemRepository.GetAllTodoItems();
                dataGridView1.DataSource = todoItems;


            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }
        private void HandleError(Exception ex)
        {
            
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get a reference to the data source (BindingList<ToDoItem> in this case)
                BindingList<ToDoItem> dataSource = dataGridView1.DataSource as BindingList<ToDoItem>;

                // Check if the data source is valid
                if (dataSource != null)
                {
                    // Create a list to store the IDs of items to be deleted
                    List<int> itemIdsToDelete = new();

                    foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                    {
                        int itemId = (int)selectedRow.Cells["Id"].Value;

                        // Mark the item as deleted in the database
                        _todoItemRepository.DeleteTodoItem(itemId);

                        // Add the item's ID to the list of items to be deleted from the data source
                        itemIdsToDelete.Add(itemId);
                    }

                    // Remove the items from the data source
                    foreach (int itemId in itemIdsToDelete)
                    {
                        ToDoItem itemToRemove = dataSource.FirstOrDefault(item => item.Id == itemId);
                        if (itemToRemove != null)
                        {
                            dataSource.Remove(itemToRemove);
                        }
                    }

                    // Refresh the DataGridView
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }
    }
}