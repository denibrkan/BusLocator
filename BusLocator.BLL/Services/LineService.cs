using AutoMapper;
using BusLocator.BLL.Interfaces.Services;
using BusLocator.Common.DataTransferObjects;
using BusLocator.Common.SearchObjects;
using BusLocator.Common.Utilities;
using BusLocator.Core.Entities;
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

        public async Task<List<LineDto>> GetAllAsync()
        {
            var lines = await _lineRepository.GetAllAsync();

            return _mapper.Map<List<LineDto>>(lines);
        }

        public async Task<PagedList<LineDto>> GetAsync(LineSearchObject searchObject)
        {
            PagedList<Line> lines = await _lineRepository.GetAsync(searchObject);

            return _mapper.Map<PagedList<LineDto>>(lines);
        }

        public async Task<LineDto> InsertAsync(LineInsertDto lineInsert)
        {
            var line = _mapper.Map<Line>(lineInsert);

            await _lineRepository.InsertAsync(line);

            return _mapper.Map<LineDto>(line);
        }

        public async Task<LineDto> UpdateAsync(int id, LineUpdateDto lineUpdate)
        {
            var line = await _lineRepository.GetByIdAsync(id);

            _mapper.Map(lineUpdate, line);

            await _lineRepository.UpdateAsync(line);

            return _mapper.Map<LineDto>(line);
        }
    }
}
