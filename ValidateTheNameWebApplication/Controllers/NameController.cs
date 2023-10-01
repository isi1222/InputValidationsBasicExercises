using Microsoft.AspNetCore.Mvc;

namespace ValidateTheNameWebApplication.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View("Index",false);
        }

        [HttpPost]
        public IActionResult ValidateName(string name) { 
            bool nameIsValid = NameIsValid(name);
            return View("Index",nameIsValid);
        }

        private Boolean NameIsValid(string name){
            //Insert logic here
            if(name.Length < 4)
                return false;
            return true;
        }
    }
}
