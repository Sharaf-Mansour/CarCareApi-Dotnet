using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    IQueryable<ProfileRepairType> SelectAllProfileRepairTypesAsync();
    ValueTask<ProfileRepairType> SelectProfileRepairTypeByIdAsync(string profileRepairTypeId);
    ValueTask UpdateProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask DeleteProfileRepairTypeAsync(string profileRepairTypeId);
}
