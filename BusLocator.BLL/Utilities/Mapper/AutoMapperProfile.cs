using AutoMapper;
using BusLocator.Common.DataTransferObjects;
using BusLocator.Core.Entities;

namespace BusLocator.BLL.Utilities.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Line, LineDto>();
            CreateMap<LineInsertDto, Line>();
        }
    }
}
