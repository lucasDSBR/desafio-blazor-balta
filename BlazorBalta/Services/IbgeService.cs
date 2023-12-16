using BlazorBalta.Data;
using BlazorBalta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace BlazorBalta.Services
{
    public class IbgeService : IIbgeService
    {
        private readonly ApplicationDbContext _context;

        public IbgeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Ibge ibge)
        {
            await _context.AddAsync(ibge);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Ibge ibge)
        {
            _context.Update(ibge);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Ibge ibge)
        {
            _context.Remove(ibge);
            await _context.SaveChangesAsync();
        }

        public async Task<Ibge> GetBy(string id)
        {
            var ibge = await _context.Ibge.FirstOrDefaultAsync(c => c.Id == id);
            return ibge;
        }

        public async Task<List<Ibge>> FindAll()
        {
            var IbgeList = await _context.Ibge.OrderByDescending(i => i.Id).ToListAsync();
            return IbgeList;
        }
        public List<Ibge> BuscarFiltro(Ibge ibge)
        {
            var result = _context.Ibge.AsQueryable();
            if (!ibge.Id.IsNullOrEmpty())
                result = result.Where(p => p.Id.Contains(ibge.Id));
            if (!ibge.City.IsNullOrEmpty())
                result = result.Where(p => p.City.Contains(ibge.City));
            if (!ibge.State.IsNullOrEmpty())
                result = result.Where(p => p.State.Contains(ibge.State));

            return result.ToList();
        }
        public async Task<List<string>> FindEstados()
        {
            List<string> EstadosList = null;
            EstadosList = await _context.Ibge
                .Select(e => e.State)
                .Distinct()
                .ToListAsync();
            return EstadosList;

        }
        public async Task<List<string>> FindCidades()
        {
            List<string> CidadesList = new();
            CidadesList = await _context.Ibge
                .Select(c => c.City)
                .Distinct()
                .ToListAsync();
            return CidadesList;
        }
    }
}
