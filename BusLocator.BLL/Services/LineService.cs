using AutoMapper;
using BusLocator.BLL.Interfaces.Services;
using BusLocator.Common.DataTransferObjects;
using BusLocator.DAL.Interfaces.Repositories;

namespace BusLocator.BLL.Services
{
    public class LineService : ILineService
    {
        private readonly ILineRepository _lineRepository;
        private readonly IMapper _mapper;

        public LineService(ILineRepository lineRepository, IMapper mapper)
        {
            _lineRepository = lineRepository;
            _mapper = mapper;
        }

        public async Task<List<LineDto>> GetAllLinesAsync()
        {
            var lines = await _lineRepository.GetAllLinesAsync();

            return _mapper.Map<List<LineDto>>(lines);
        }
    }
}
