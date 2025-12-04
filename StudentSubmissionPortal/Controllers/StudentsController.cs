using Microsoft.AspNetCore.Mvc;

namespace StudentSubmissionPortal.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Students()
        {
            return View();
        }
    }
}
