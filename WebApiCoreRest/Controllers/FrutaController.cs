using Microsoft.AspNetCore.Mvc;

using WebApiCoreRest.Model;


namespace WebApiCoreRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrutaController : ControllerBase
    {
        private readonly DataContext _context;

        public FrutaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Fruta>>> Get()
        {
            return Ok(await _context.Frutas.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fruta>> Get(int id)
        {
            var fruta = await _context.Frutas.FindAsync(id);
            if (fruta == null)
            {
                return BadRequest("Hero not found.");
            }
            else
            {
                return Ok(fruta);
            }                            
        }

        [HttpPost]
        public async Task<ActionResult<List<Fruta>>> AddHero(Fruta fruta)
        {
            _context.Frutas.Add(fruta);
            await _context.SaveChangesAsync();
            return Ok(await _context.Frutas.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Fruta>>> UpdateHero(Fruta request)
        {
            var updateFruta = await _context.Frutas.FindAsync(request.IdFruta);
            if (updateFruta == null)
            {
                return BadRequest("Hero not found.");
            }
            else
            {
                updateFruta.NombreFruta = request.NombreFruta;
                updateFruta.PesoFruta = request.PesoFruta;
                updateFruta.FechaExpiracion = request.FechaExpiracion;
                await _context.SaveChangesAsync();
                return Ok(await _context.Frutas.ToListAsync());
            }
                


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Fruta>>> Delete(int id)
        {
            var deleteFruta = await _context.Frutas.FindAsync(id);
            if (deleteFruta == null)
            {
                return BadRequest("Hero not found.");
            }
            else
            {
                _context.Frutas.Remove(deleteFruta);
                await _context.SaveChangesAsync();

                return Ok(await _context.Frutas.ToListAsync());
            }
                


        }


    }
}
