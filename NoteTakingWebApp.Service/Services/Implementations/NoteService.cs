using AutoMapper;
using NoteTakingWebApp.DataAccess.Db;
using NoteTakingWebApp.DataAccess.Entities;
using NoteTakingWebApp.DTO.Dtos;
using NoteTakingWebApp.Service.Services.Abstracts;

namespace NoteTakingWebApp.Service.Services.Implementations
{
    public class NoteService : BaseService<NoteDto, Note, NoteDto>, INoteService
    {
        public NoteService(IMapper mapper, AppDbContext appDbContext) 
            : base(mapper, appDbContext)
        {
        }
    }
}