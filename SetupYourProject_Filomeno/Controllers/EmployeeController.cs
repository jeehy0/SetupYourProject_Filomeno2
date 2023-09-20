using Microsoft.AspNetCore.Mvc;

namespace SetupYourProject_Filomeno.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
