using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Models
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
