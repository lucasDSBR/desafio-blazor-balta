using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Interfaces
{
    public interface ILocalidadeBuscaRepository
    {
        Task<List<Ibge>> Buscar(Ibge ibge);
        Task<List<string>> BuscarEstados();
        Task<List<string>> BuscarCidades();
    }
}
