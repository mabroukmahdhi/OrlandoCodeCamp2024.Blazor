using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Demos.Orlando.ToDo.Models.Users;

namespace Demos.Orlando.ToDo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

        public async ValueTask<User> InsertUserAsync(User User)
        {
            EntityEntry<User> UserEntityEntry =
                await Users.AddAsync(User);

            await SaveChangesAsync();

            return UserEntityEntry.Entity;
        }

        public IQueryable<User> SelectAllUsers() => this.Users;

        public async ValueTask<User> SelectUserByIdAsync(Guid UserId) =>
            await Users.FindAsync(UserId);

        public async ValueTask<User> UpdateUserAsync(User User)
        {
            EntityEntry<User> UserEntityEntry =
                Users.Update(User);

            await SaveChangesAsync();

            return UserEntityEntry.Entity;
        }

        public async ValueTask<User> DeleteUserAsync(User User)
        {
            EntityEntry<User> UserEntityEntry =
                Users.Remove(User);

            await SaveChangesAsync();

            return UserEntityEntry.Entity;
        }
    }
}
