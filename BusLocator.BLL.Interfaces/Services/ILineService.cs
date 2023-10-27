using BusLocator.Common.DataTransferObjects;

namespace BusLocator.BLL.Interfaces.Services
{
    public interface ILineService
    {
        Task<List<LineDto>> GetAllLinesAsync();
        Task<LineDto> InsertAsync(LineInsertDto line);
        Task<LineDto> UpdateAsync(int id, LineUpdateDto line);
    }
}