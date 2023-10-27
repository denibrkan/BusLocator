using BusLocator.Common.SearchObjects;
using BusLocator.Common.Utilities;
using BusLocator.Core.Entities;

namespace BusLocator.DAL.Interfaces.Repositories
{
    public interface ILineRepository
    {
        Task<List<Line>> GetAllAsync();
        Task<PagedList<Line>> GetAsync(LineSearchObject search);
        Task<Line> InsertAsync(Line line);
        Task<Line> UpdateAsync(Line line);
        Task<Line> GetByIdAsync(int id);
    }
}