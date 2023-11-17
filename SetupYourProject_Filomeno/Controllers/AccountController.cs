using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SetupYourProject_Filomeno.Data;
using SetupYourProject_Filomeno.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SetupYourProject_Filomeno.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signinManager;
        private readonly UserManager<User> _userManager;
        public AccountController(SignInManager<User> signinManager, UserManager<User> userManager)
        {
            _signinManager = signinManager;
            _userManager = userManager;
        }
        
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginInfo)
        {
            var result = await _signinManager.PasswordSignInAsync(loginInfo.UserName, loginInfo.Password, loginInfo.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Instructor");
            }
            else
            {
                ModelState.AddModelError("", "Failed to Login");
            }
            return View(loginInfo);
        }

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Instructor");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel userEnteredData)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User();
                newUser.UserName = userEnteredData.UserName;
                newUser.FirstName = userEnteredData.FirstName;
                newUser.LastName = userEnteredData.LastName;
                newUser.Email = userEnteredData.Email;
                newUser.PhoneNumber = userEnteredData.Phone;

                var result = await _userManager.CreateAsync(newUser, userEnteredData.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Instructor");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(userEnteredData);
        }
    }
}
