using System;
using System.Threading.Tasks;
using FEDAC.business.Abstract;
using FEDAC.webui.EmailServices;
using FEDAC.webui.Extensions;
using FEDAC.webui.Identity;
using FEDAC.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FEDAC.webui.Controllers
{
    [AutoValidateAntiforgeryToken]
//  [Authorize]login olan kullanıcılar ekranı görebilme yetkisi verdik.
//  [AllowAnonymous]herkese görebilme(login olmayan kullanıcılar bile) yetkisi verdik.

    public class AccountController : Controller
    {
        //admin kullanıcı gibi olayları yonetecek.
        private UserManager<User> _userManager;
        //cookie olaylarını yönetecek.
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;

        public AccountController(ICartService cartService,UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _cartService = cartService;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // login sayfasına user name ile giriş yapmak istersen aktifleştirmen gereken kısım -> var user = await _userManager.FindByNameAsync(model.UserName);
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Bu kullanıcı adı ile dahaönce hesap oluşturulmamıştır.");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen mail hesabınıza gelen link ile üyeliğinizi onaylayınız. ");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            //kullanıcı sayfaya başarılı girişyaptığında
            if (result.Succeeded)
            {
                //yönlendirilme sayfası
                return Redirect(model.ReturnUrl ?? "~/");//~/ anasayfayagit demek
            }

            ModelState.AddModelError("", "Girilen kullnıcı adı veya parola yanlış.");
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });

                //email
                await _emailSender.SendEmailAsync(model.Email, "Hesabinizi onaylayiniz.", $"Lütfen email hesabinizi onaylamak için linke <a href='https://localhost:5001{url}'>tiklayiniz.</a>");
                return RedirectToAction("Login", "Account");
            }

            ModelState.AddModelError("", "Bilinmeyen bir hata oldu lütfen tekrar deneyiniz.");

            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            //cookie tarayıcıdan siler.
            await _signInManager.SignOutAsync();
            TempData.Put("message", new AlertMessage()
            {
                Title = "Oturum kapatıldı.",
                Message = "Hesabınız güvenli bir şekilde kapatıldı.",
                AlertType = "warning"
            });
            return Redirect("~/");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Geçersiz token.",
                    Message = "Geçersiz Token.",
                    AlertType = "danger"
                });
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    //hesabın onaylanması durumunda sepet(cart islemi gerceklesmesi gerekir:kod gelicek: -Fatih)
                    _cartService.InitializeCart(user.Id);

                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Hesabınız onaylandı.",
                        Message = "Hesabınız Onaylandı.",
                        AlertType = "success"
                    });

                    return View();
                }
            }
            TempData.Put("message", new AlertMessage()
            {
                Title = "Hesabınız onaylanmadı.",
                Message = "Hesabınız Onaylanmadı.",
                AlertType = "warning"
            });

            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                return View();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            //generate token
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            //email
            await _emailSender.SendEmailAsync(Email, "Reset Password", $"Parolanızı yenilemek için linke <a href='https://localhost:5001{url}'>tıklayınız.</a>");

            return View();
        }
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new ResetPasswordModel { Token = token };

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        //yetkimiz olmadığını accessdenied ile belirttik.
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}