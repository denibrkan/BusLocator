using BusLocator.Common.DataTransferObjects;
using BusLocator.Common.SearchObjects;
using BusLocator.Common.Utilities;

namespace BusLocator.BLL.Interfaces.Services
{
    public interface ILineService
    {
        Task<List<LineDto>> GetAllAsync();
        Task<PagedList<LineDto>> GetAsync(LineSearchObject searchObject);
        Task<LineDto> InsertAsync(LineInsertDto line);
        Task<LineDto> UpdateAsync(int id, LineUpdateDto line);
    }
}