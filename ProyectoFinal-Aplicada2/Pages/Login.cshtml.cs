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
using ProyectoFinal_Aplicada2.Data;
using Blazored.Toast.Services;


namespace ProyectoFinal_Aplicada2.Pages
{
    public class LoginModel : PageModel
    {
        ToastService ToastService = new ToastService();
        public string ReturnUrl { get; set; }
        Usuarios Usuarios = new Usuarios();
        UsuariosControllers UsuariosControllers = new UsuariosControllers();
        Contexto contexto = new Contexto();
        List<Usuarios> ListaUsuarios = new List<Usuarios>();


        public async Task<ActionResult> OnGetAsync(string paramUsername, string paramPassword)
        {
            string ReturnUrl = Url.Content("~/");
            bool paso = false;
            try
            {
                if (paramUsername == null ||paramPassword == null)
                {
                    return LocalRedirect(ReturnUrl);
                }

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

            string User = paramUsername;
            string Pass = paramPassword;

            paso = UsuariosControllers.VerificarExistenciaYClaveDelUsuario(User, Pass);

            //if (!paso)
            //{
            //    return LocalRedirect(ReturnUrl);
            //}


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
