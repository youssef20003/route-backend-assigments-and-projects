using IKEA.DAL.Models;
using IKEA.DAL.Models.Auth;
using IKEA.PL_S3_demo_.Helpers;
using IKEA.PL_S3_demo_.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.PL_S3_demo_.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var User = new ApplicationUser()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName
            };
            var res = _userManager.CreateAsync(User , model.Password).Result;
            if (res.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                foreach (var Error in res.Errors)
                {
                    ModelState.AddModelError(string.Empty , Error.Description);
                    
                }
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }

            var user = _userManager.FindByEmailAsync(model.Email).Result;
            if (user is not null)
            {
                bool flag = _userManager.CheckPasswordAsync(user, model.Password).Result;

                if (flag)
                {
                    var res = _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;

                    if (res.IsNotAllowed)
                    {
                        ModelState.AddModelError(String.Empty, "not allowed");

                    }

                    if (res.IsLockedOut)
                    {

                        ModelState.AddModelError(String.Empty, "IsLockedOut");
                    }
                    if (res.Succeeded)
                    {

                        return RedirectToAction("Index", "Home"); 
                    }
                }
            }
            ModelState.AddModelError(String.Empty, "Invalid Login");

            return View(model);
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync().GetAwaiter().GetResult();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

 [HttpPost]
public async Task<IActionResult> SendResetPasswordLink(ForgetPasswordViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user != null)
        {
            var Token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var PasswordResetLink = Url.Action("ResetPassword", "Account", new { email = model.Email , token = Token} , Request.Scheme);
            var email = new Email()
            {
                Subject = "Reset Password",
                To = model.Email,
                Body = PasswordResetLink
            };

            EmailSettings.SendEmail(email);

            
            return RedirectToAction(nameof(CheckYourInbox));
        }

        
        ModelState.AddModelError(string.Empty, "Email not valid");
    }
     
    return View(model);
}

        public IActionResult CheckYourInbox()
        {
            return View();
        }

        public IActionResult ResetPassword(string email , string token)
        {
            TempData["email"] = email;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Retrieve email and token from TempData
                string email = TempData["email"] as string;
                string token = TempData["token"] as string;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(token))
                {
                    ModelState.AddModelError(string.Empty, "Invalid password reset request.");
                    return View(model);
                }

                var user = await _userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "User not found.");
                    return View(model);
                }

                var res = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);

                if (res.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }

              
                foreach (var error in res.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

       
            return View(model);
        }

    }
}
