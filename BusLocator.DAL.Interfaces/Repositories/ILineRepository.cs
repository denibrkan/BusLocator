using BusLocator.Core.Entities;

namespace BusLocator.DAL.Interfaces.Repositories
{
    public interface ILineRepository
    {
        Task<List<Line>> GetAllLinesAsync();
        Task<Line> InsertAsync(Line line);
        Task<Line> UpdateAsync(Line line);
        Task<Line> GetByIdAsync(int id);
    }
}