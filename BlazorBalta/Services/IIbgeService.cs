using BlazorBalta.Models;

namespace BlazorBalta.Services
{
    public interface IIbgeService
    {
        Task Add(Ibge ibge);
        Task Delete(Ibge ibge);
        Task<List<Ibge>> FindAll();
        Task<List<string>> FindEstados();
        List<Ibge> BuscarFiltro(Ibge ibge);
        Task<Ibge> GetBy(string id);
        Task Update(Ibge ibge);
    }
}