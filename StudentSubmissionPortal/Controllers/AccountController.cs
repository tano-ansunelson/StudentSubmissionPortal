using Microsoft.AspNetCore.Mvc;
using StudentSubmissionPortal.Models;
using System.Diagnostics;

namespace StudentSubmissionPortal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(){
        
        return View();
        }

        
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }   


       
    }
}
