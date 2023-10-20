﻿using BusLocator.BLL.Interfaces.Services;
using BusLocator.Common.DataTransferObjects;
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
            var lines = await _lineService.GetAllLinesAsync();

            return Ok(lines);
        }
    }
}
