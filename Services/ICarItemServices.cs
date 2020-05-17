using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreCarDB.Models;
using AspNetCoreCarItem.Models;

/* From page 32-33 */

namespace AspNetCoreCarItem.Services
{
    public interface ICarItemService
    {
        Task<CarItem[]> GetIncompleteItemsAsync();
    }
}