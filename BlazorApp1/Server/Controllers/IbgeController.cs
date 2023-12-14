using BlazorApp1.Server.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IbgeController : ControllerBase
    {
        private readonly ILocalidadeBuscaService _localidadeBuscaService;

        public IbgeController(ILocalidadeBuscaService localidadeBuscaService) {
            _localidadeBuscaService = localidadeBuscaService;
        }
        [HttpGet("estados")]
        public Task<List<string>> BuscarEstados()
        {
            try
            {
                return _localidadeBuscaService.BuscarEstados();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet("cidades")]
        public Task<List<string>> BuscarCidades()
        {
            try
            {
                return _localidadeBuscaService.BuscarCidades();
            }
            catch
            {
                return null;
            }
        }

    }
}
