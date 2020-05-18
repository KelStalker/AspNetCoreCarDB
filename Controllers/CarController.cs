using AspNetCoreCarItem.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCarDB.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarItemService _carItemService;
        public CarController(ICarItemService carItemService)
        {
            _carItemService = carItemService;
        }

        //public IActionResult Index()
        //{
        //    return new ActionResult();

        //    // Get Car(s) from the DB
        //    // Put Car(s) into a model
        //    // Render view using the model
        //}
    }
}
