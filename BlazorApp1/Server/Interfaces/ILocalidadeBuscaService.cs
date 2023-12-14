using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Interfaces
{
    public interface ILocalidadeBuscaService
    {
        Task<List<Ibge>> BuscarLocalidade(Ibge localudade);
        Task<List<string>> BuscarEstados();
        Task<List<string>> BuscarCidades();
    }
}
