using Gaci.RentCar.Identity.Models;
using GACI.RentCar.Aplicacion.Contractos.Identity;
using GACI.RentCar.Aplicacion.Modelos.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Gaci.RentCar.Identity.Servicios
{
    public class ServicioDeAutentificacion : IServicioDeAutentificacion
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _configuracionJwt;

        public ServicioDeAutentificacion(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtSettings> configuracionJwt)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuracionJwt = configuracionJwt.Value;
        }

        public async Task<RepuestaDeAutentificacion> Login(SolicitudDeAutenticacion solicitudDeAutenticacion)
        {
            var user = await _userManager.FindByEmailAsync(solicitudDeAutenticacion.Correo);

            if (user != null)
            {
                var resultado = await _signInManager.PasswordSignInAsync(user.UserName, solicitudDeAutenticacion.Contraseña, false, lockoutOnFailure: false);

                if (!resultado.Succeeded)
                {
                    //poner validaciones
                }
            }
            var token = await GenerarToken(user);
            var respuesta = new RepuestaDeAutentificacion
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Correo = user.Email,
                NombreUsuario = user.UserName
            };

            return respuesta;
        }

        public async Task<RepuestaDeRegistro> Registrarse(SolicitudDeRegistro solicitudDeRegistro)
        {
            //var existeUsuario = _userManager.FindByNameAsync(solicitudDeRegistro.NombreUsuario);

            var user = new ApplicationUser
            {
                Email = solicitudDeRegistro.Correo,
                Nombre = solicitudDeRegistro.Nombre,
                Apellidos = solicitudDeRegistro.Apellidos,
                UserName = solicitudDeRegistro.NombreUsuario,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, solicitudDeRegistro.Contraseña);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Cliente");
                var token = await GenerarToken(user);
                return new RepuestaDeRegistro
                {
                    Correo = user.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    UserId = user.Id,
                    NombreUsuario = user.UserName
                };
            }

            return new RepuestaDeRegistro();
        }

        private async Task<JwtSecurityToken> GenerarToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
        
            var rolesClaims = new List<Claim>();

            foreach (var role in roles)
            {
                rolesClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var claims = new[] 
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("UserId", user.Id)
            }.Union(userClaims).Union(rolesClaims);

            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("7dbe87cb-6291-41c0-bb1e-b4b53f15a54a"));
            var signigCredentials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken
                (
                    issuer: _configuracionJwt.Issuer,
                    audience: _configuracionJwt.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(_configuracionJwt.DurationInMinutes),
                    signingCredentials: signigCredentials
                );

            return jwtSecurityToken;
        }
    }
}
