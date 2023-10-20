using BusLocator.Core;
using BusLocator.Core.Entities;
using BusLocator.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BusLocator.DAL.Repositories
{
    public class LineRepository : ILineRepository
    {
        private readonly BusLocatorContext _db;

        public LineRepository(BusLocatorContext db)
        {
            _db = db;
        }

        public Task<List<Line>> GetAllLinesAsync()
        {
            return _db.Lines.ToListAsync();
        }
    }
}