using BlazorApp1.Server.Interfaces;
using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;

namespace BlazorApp1.Server.Services
{
    public class LocalidadeBuscaServices : ILocalidadeBuscaService
    {
        private readonly ILocalidadeBuscaRepository _localidadeSearchRepository;

        public LocalidadeBuscaServices(ILocalidadeBuscaRepository localidadeSearchRepository)
        {
            _localidadeSearchRepository = localidadeSearchRepository;
        }

        public async Task<List<Ibge>> BuscarLocalidade(Ibge localudade) 
        {
            return await _localidadeSearchRepository.Buscar(localudade);
        }
        public async Task<List<string>> BuscarEstados()
        {
            return await _localidadeSearchRepository.BuscarEstados();
        }

        public async Task<List<string>> BuscarCidades()
        {
            return await _localidadeSearchRepository.BuscarCidades();
        }
    }
}
