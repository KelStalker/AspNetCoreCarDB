using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCarDB.Controllers
{
    public class CarController : Controller       
    {
        public IActionResult Index()
        {
            // Get Car(s) from the DB
            // Put Car(s) into a model
            // Render view using the model
        } 
    }
}
