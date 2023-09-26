using NoteTakingWebApp.DataAccess.Entities;
using NoteTakingWebApp.DTO.Dtos;

namespace NoteTakingWebApp.Service.Services.Abstracts
{
    public interface INoteService : IBaseService<NoteDto, Note, NoteDto>
    {
    }
}