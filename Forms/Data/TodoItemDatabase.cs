using Forms.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Data
{
    public class TodoItemDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public TodoItemDatabase(string dbFile)
        {
            _database = new SQLiteAsyncConnection(dbFile);
            _database.CreateTableAsync<TodoItem>().Wait();
        }
        public Task<List<TodoItem>> GetItemsAsync()
        {
            return _database.Table<TodoItem>().ToListAsync();
        }
        public Task<List<TodoItem>> GetItemsNotDoneAsync()
        {
            return _database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }
        public Task<TodoItem> GetItemAsync(int id)
        {
            return _database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return _database.UpdateAsync(item);
            }
            else
            {
                return _database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItem(TodoItem item)
        {
            return _database.DeleteAsync(item);
        }
    }
}
