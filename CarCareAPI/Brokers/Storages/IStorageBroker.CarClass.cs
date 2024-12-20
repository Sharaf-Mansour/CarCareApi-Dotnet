﻿using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertCarClassAsync(CarClass carClass);
    ValueTask<List<CarClass>> SelectAllCarClassesAsync();
    ValueTask<CarClass> SelectCarClassByIdAsync(string carClassId);
    ValueTask UpdateCarClassAsync(CarClass carClass);
    ValueTask DeleteCarClassAsync(string carClassId);
}
