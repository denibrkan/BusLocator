using BusLocator.BLL.Interfaces.Services;
using BusLocator.Common.DataTransferObjects;
using BusLocator.Common.SearchObjects;
using BusLocator.Common.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BusLocator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesController : ControllerBase
    {
        private readonly ILineService _lineService;

        public LinesController(ILineService lineService)
        {
            _lineService = lineService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<LineDto>>> GetAll()
        {
            var lines = await _lineService.GetAllAsync();

            return Ok(lines);
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<LineDto>>> Get([FromQuery] LineSearchObject searchObject)
        {
            var lines = await _lineService.GetAsync(searchObject);

            return Ok(lines);
        }

        [HttpPost]
        public async Task<ActionResult<LineDto>> Post(LineInsertDto lineInsert)
        {
            var line = await _lineService.InsertAsync(lineInsert);

            return Ok(line);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LineDto>> Put(int id, LineUpdateDto lineUpdate)
        {
            var line = await _lineService.UpdateAsync(id, lineUpdate);

            return Ok(line);
        }
    }
}
