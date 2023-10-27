using AutoMapper;
using BusLocator.Common.DataTransferObjects;
using BusLocator.Common.Utilities;
using BusLocator.Core.Entities;

namespace BusLocator.BLL.Utilities.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Line, LineDto>();
            CreateMap<LineInsertDto, Line>();
            CreateMap<LineUpdateDto, Line>();

            CreateMap(typeof(PagedList<>), typeof(PagedList<>));
        }
    }
}