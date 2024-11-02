using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask InsertUserAsync(User user);
    IQueryable<User> SelectAllUsersAsync();
    ValueTask SelectUserByIdAsync(int userId);
    ValueTask UpdateUserAsync(User user);
    ValueTask DeleteUserAsync(int UserId);
}
