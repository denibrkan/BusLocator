using BusLocator.Common.DataTransferObjects;

namespace BusLocator.BLL.Interfaces.Services
{
    public interface ILineService
    {
        Task<List<LineDto>> GetAllLinesAsync();
    }
}