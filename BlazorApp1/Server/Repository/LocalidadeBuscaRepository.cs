using BlazorApp1.Server.Data;
using BlazorApp1.Server.Data.Migrations;
using BlazorApp1.Server.Interfaces;
using BlazorApp1.Server.Models;
using Duende.IdentityServer.Extensions;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Server.Repository
{
    public class LocalidadeBuscaRepository : ILocalidadeBuscaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LocalidadeBuscaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Models.Ibge>> Buscar(Models.Ibge localidade)
        {
            var result = new List<Models.Ibge>();
            if (!localidade.City.IsNullOrEmpty())
                result = await _dbContext.Ibge.Where(loc => loc.City!.Equals(localidade.City)).ToListAsync();
            if (localidade.State.IsNullOrEmpty())
                result = await _dbContext.Ibge.Where(loc => loc.State!.Equals(localidade.State)).ToListAsync();
            return result;
        }

        public async Task<List<string>> BuscarEstados()
        {
            var result = new List<string>();
            result = await _dbContext.Ibge.Select(c => c.State).Distinct().ToListAsync();
            return result;
        }
        public async Task<List<string>> BuscarCidades()
        {
            var result = new List<string>();
            result = await _dbContext.Ibge.Select(c => c.City).Distinct().ToListAsync();
            return result;
        }
    }
}
