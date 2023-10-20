using BusLocator.Core.Entities;

namespace BusLocator.DAL.Interfaces.Repositories
{
    public interface ILineRepository
    {
        Task<List<Line>> GetAllLinesAsync();
    }
}