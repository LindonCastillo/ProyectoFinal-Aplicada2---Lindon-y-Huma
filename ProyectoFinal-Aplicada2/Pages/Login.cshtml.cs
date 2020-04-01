using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoFinal_Aplicada2.Models;
using ProyectoFinal_Aplicada2.Controllers;

namespace ProyectoFinal_Aplicada2.Pages
{
    public class LoginModel : PageModel
    {

        public string ReturnUrl { get; set; }
        Usuarios Usuarios = new Usuarios();
        UsuariosControllers UsuariosControllers = new UsuariosControllers();


        public async Task<ActionResult> OnGetAsync(string paramUsername, string paramPawoord)
        {
            string ReturnUrl = Url.Content("~/");                                     
            try
            {
               
                
                    await HttpContext
                        .SignOutAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme);             
            }
            catch
            {   }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, paramUsername),
                new Claim(ClaimTypes.Role, "Administrator"),
            };
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
                RedirectUri = this.Request.Host.Value
            };
            try
            {
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return LocalRedirect(ReturnUrl);
        }
    }
}
