using Microsoft.AspNetCore.Mvc;

namespace StudentSubmissionPortal.Controllers
{
    public class SupervisorController : Controller
    {
        public IActionResult Supervisor()
        {
            return View();
        }
    }
}
