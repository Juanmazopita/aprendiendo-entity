using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entidades;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Api/Generos")]
    public class MascotasController : ControllerBase
    {
        private readonly Conexion context;
        public MascotasController(Conexion context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult> Post(Mascotas Mascota)
            {
            context.Add(Mascota);
            await context.SaveChangesAsync();
            return Ok();
            }
    }
}
