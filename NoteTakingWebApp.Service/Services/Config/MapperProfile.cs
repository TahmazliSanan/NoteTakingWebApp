using AutoMapper;
using NoteTakingWebApp.DataAccess.Entities;
using NoteTakingWebApp.DTO.Dtos;

namespace NoteTakingWebApp.Service.Services.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Note, NoteDto>().ReverseMap();
        }
    }
}