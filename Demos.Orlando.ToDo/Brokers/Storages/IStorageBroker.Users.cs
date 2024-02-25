using System;
using System.Linq;
using System.Threading.Tasks;
using Demos.Orlando.ToDo.Models.Users;

namespace Demos.Orlando.ToDo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User User);
        IQueryable<User> SelectAllUsers();
        ValueTask<User> SelectUserByIdAsync(Guid UserId);
        ValueTask<User> UpdateUserAsync(User User);
        ValueTask<User> DeleteUserAsync(User User);
    }
}
