using System;
using System.Linq;
using System.Threading.Tasks;
using Demos.Orlando.ToDo.Models.ToDoItems;

namespace Demos.Orlando.ToDo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<ToDoItem> InsertToDoItemAsync(ToDoItem ToDoItem);
        IQueryable<ToDoItem> SelectAllToDoItems();
        ValueTask<ToDoItem> SelectToDoItemByIdAsync(Guid ToDoItemId);
        ValueTask<ToDoItem> UpdateToDoItemAsync(ToDoItem ToDoItem);
        ValueTask<ToDoItem> DeleteToDoItemAsync(ToDoItem ToDoItem);
    }
}
