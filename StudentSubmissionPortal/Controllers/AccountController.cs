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


/* @{ 
public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly ApplicationDbContext _context;

    public AccountController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        ApplicationDbContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
    }

    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.Classes = _context.Classes.ToList();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Classes = _context.Classes.ToList();
            return View(model);
        }

        var user = new IdentityUser
        {
            Email = model.Email,
            UserName = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);

            ViewBag.Classes = _context.Classes.ToList();
            return View(model);
        }

        // Assign role
        await _userManager.AddToRoleAsync(user, model.Role);

        // Save Student or Supervisor Profile
        if (model.Role == "Student")
        {
            _context.Students.Add(new StudentProfile
            {
                UserId = user.Id,
                FullName = model.FullName,
                ClassId = model.ClassId.Value
            });
        }
        else
        {
            _context.Supervisors.Add(new SupervisorProfile
            {
                UserId = user.Id,
                FullName = model.FullName
            });
        }

        await _context.SaveChangesAsync();
        await _signInManager.SignInAsync(user, isPersistent: false);

        // Redirect based on Role
        if (model.Role == "Student")
            return RedirectToAction("Index", "Student");

        if (model.Role == "Supervisor")
            return RedirectToAction("Index", "Supervisor");

        return RedirectToAction("Index", "Home");
    }
}



}*/