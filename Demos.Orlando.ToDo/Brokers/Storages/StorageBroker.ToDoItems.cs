using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Demos.Orlando.ToDo.Models.ToDoItems;

namespace Demos.Orlando.ToDo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public async ValueTask<ToDoItem> InsertToDoItemAsync(ToDoItem ToDoItem)
        {
            EntityEntry<ToDoItem> ToDoItemEntityEntry =
                await ToDoItems.AddAsync(ToDoItem);

            await SaveChangesAsync();

            return ToDoItemEntityEntry.Entity;
        }

        public IQueryable<ToDoItem> SelectAllToDoItems() => this.ToDoItems;

        public async ValueTask<ToDoItem> SelectToDoItemByIdAsync(Guid ToDoItemId) =>
            await ToDoItems.FindAsync(ToDoItemId);

        public async ValueTask<ToDoItem> UpdateToDoItemAsync(ToDoItem ToDoItem)
        {
            EntityEntry<ToDoItem> ToDoItemEntityEntry =
                ToDoItems.Update(ToDoItem);

            await SaveChangesAsync();

            return ToDoItemEntityEntry.Entity;
        }

        public async ValueTask<ToDoItem> DeleteToDoItemAsync(ToDoItem ToDoItem)
        {
            EntityEntry<ToDoItem> ToDoItemEntityEntry =
                ToDoItems.Remove(ToDoItem);

            await SaveChangesAsync();

            return ToDoItemEntityEntry.Entity;
        }
    }
}
