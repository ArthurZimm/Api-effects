using AutoMapper;
using api_effects.Data;
using api_effects.Data.Dtos;
using api_effects.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace api_effects.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistroController : ControllerBase
    {
        private RegistroContext _context;
        private IMapper _mapper;

        public RegistroController(RegistroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateRegistroDto registrodto)
        {
            Registro registro = _mapper.Map<Registro>(registrodto);
            _context.Registros.Add(registro);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = registro.Id },
                registro);
        }

        [HttpGet]

        public IEnumerable<ReadRegistroDto> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadRegistroDto>>(_context.Registros.Skip(skip).Take(take));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            var registro = _context.Registros.FirstOrDefault(registro => registro.Id == id);
            if (registro == null) return NotFound();
            var registroDto = _mapper.Map<ReadRegistroDto>(registro);
            return Ok(registro);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateRegistroDto registroDto)
        {
            var registro = _context.Registros.FirstOrDefault(
                registro => registro.Id == id);
            if (registro == null) return NotFound();
            _mapper.Map(registroDto, registro);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult DeletaFilme(int id)
        {
            var registro = _context.Registros.FirstOrDefault(
            registro => registro.Id == id);
            if (registro == null) return NotFound();
            _context.Remove(registro);
            _context.SaveChanges();
            return NoContent();
        }
        
    }
}
