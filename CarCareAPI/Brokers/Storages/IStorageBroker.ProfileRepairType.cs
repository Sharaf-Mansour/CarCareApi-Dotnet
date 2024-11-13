using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask<List<ProfileRepairType>> SelectAllProfileRepairTypesAsync();
    ValueTask<ProfileRepairType> SelectProfileRepairTypeByIdAsync(string profileRepairTypeId);
    ValueTask UpdateProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask DeleteProfileRepairTypeAsync(string profileRepairTypeId);
}