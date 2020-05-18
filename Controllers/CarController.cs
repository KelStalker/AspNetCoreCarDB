using AspNetCoreCarItem.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AspNetCoreCarDB.Models;


namespace AspNetCoreCarDB.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarItemService _carItemService;
        public CarController(ICarItemService carItemService)
        {
            _carItemService = carItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _carItemService.GetIncompleteItemsAsync(); // Page 37 - Get Car(s) from the DB
         
            var model = new CarViewModel()
            {
                Items = items
            };
            return View(model);
        }

        // Put Car(s) into a model
        // Render view using the model
    }
}

