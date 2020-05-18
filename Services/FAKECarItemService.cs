using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreCarDB.Models;
using AspNetCoreCarItem.Services;

namespace AspNetCore.Services
{
    public class FakeCarItemService : ICarItemService
    {
        public Task<CarItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new CarItem
            {
                OwnsCar = false,
                CarModel = "Lamborghini",
                CarMake = "Huracan",
                CarYear = 2000,
            };

            var item2 = new CarItem
            {
                OwnsCar = false,
                CarModel = "Lamborghini",
                CarMake = "Aventador",
                CarYear = 1999,
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}