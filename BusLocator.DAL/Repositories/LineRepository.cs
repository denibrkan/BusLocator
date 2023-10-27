using BusLocator.Common.Resources.Strings;
using BusLocator.Common.SearchObjects;
using BusLocator.Common.Utilities;
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

        public Task<List<Line>> GetAllAsync()
        {
            return _db.Lines.OrderBy(l => l.Id).ToListAsync();
        }

        public async Task<PagedList<Line>> GetAsync(LineSearchObject searchObject)
        {
            var lines = _db.Lines.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchObject.SearchText))
                lines = lines.Where(l => l.Name.ToLower().Contains(searchObject.SearchText.ToLower()));

            if (!string.IsNullOrWhiteSpace(searchObject.OrderBy))
            {
                if (searchObject.OrderBy == nameof(Line.Number))
                    lines = searchObject.OrderAsc ? lines.OrderBy(l => l.Number) : lines.OrderByDescending(l => l.Number);

                if (searchObject.OrderBy == nameof(Line.Name))
                    lines = searchObject.OrderAsc ? lines.OrderBy(l => l.Name) : lines.OrderByDescending(l => l.Name);

                if (searchObject.OrderBy == nameof(Line.Price))
                    lines = searchObject.OrderAsc ? lines.OrderBy(l => l.Price) : lines.OrderByDescending(l => l.Price);
            }
            else
            {
                lines = lines.OrderBy(l => l.Id);
            }

            return await PagedList<Line>.CreateAsync(lines, searchObject.Page, searchObject.PageSize);
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