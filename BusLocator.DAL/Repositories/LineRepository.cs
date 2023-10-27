using BusLocator.Common.Resources.Strings;
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
            return _db.Lines.OrderBy(l => l.Number).ToListAsync();
        }

        public async Task<Line> InsertAsync(Line line)
        {
            _db.Lines.Add(line);

            await _db.SaveChangesAsync();

            return line;
        }

        public async Task<Line> UpdateAsync(Line line)
        {
            await _db.SaveChangesAsync();

            return line;
        }


        public async Task<Line> GetByIdAsync(int id)
        {
            var line = await _db.Lines.FirstOrDefaultAsync(x => x.Id == id);

            if (line == null)
                throw new Exception(string.Format(Strings.LineNotFoundException, id));

            return line;
        }
    }
}