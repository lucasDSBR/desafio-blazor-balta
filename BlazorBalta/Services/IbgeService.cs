using BlazorBalta.Data;
using BlazorBalta.Models;
using Microsoft.EntityFrameworkCore;

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
            var IbgeList = await _context.Ibge.OrderBy(i => i.Id).ToListAsync();
            return IbgeList;
        }
    }
}
