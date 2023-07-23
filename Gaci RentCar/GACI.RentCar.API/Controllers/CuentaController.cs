using GACI.RentCar.Aplicacion.Contractos.Identity;
using GACI.RentCar.Aplicacion.Modelos.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GACI.RentCar.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CuentaController : ControllerBase
    {
        private readonly IServicioDeAutentificacion _servicioDeAutentificacion;

        public CuentaController(IServicioDeAutentificacion servicioDeAutentificacion)
        {
            _servicioDeAutentificacion = servicioDeAutentificacion;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<RepuestaDeAutentificacion>> Login([FromBody] SolicitudDeAutenticacion autenticacion)
        {
            return Ok(await _servicioDeAutentificacion.Login(autenticacion));
        }

        [HttpPost("Registro")]
        public async Task<ActionResult<RepuestaDeRegistro>> Registro([FromBody] SolicitudDeRegistro autenticacion)
        {
            return Ok(await _servicioDeAutentificacion.Registrarse(autenticacion));
        }
    }
}
