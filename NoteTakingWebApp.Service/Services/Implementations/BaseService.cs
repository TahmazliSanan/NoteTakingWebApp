using NoteTakingWebApp.Service.Services.Abstracts;

namespace NoteTakingWebApp.Service.Services.Implementations
{
    public class BaseService<TRequestDto, TEntity, TResponseDto> 
        : IBaseService<TRequestDto, TEntity, TResponseDto>
    {

        public virtual TResponseDto Create(TRequestDto requestDto)
        {

        }

        public virtual TResponseDto GetById(int id)
        {

        }

        public virtual IEnumerable<TResponseDto> GetAll()
        {

        }

        public virtual TResponseDto Update(TRequestDto requestDto)
        {

        }

        public virtual void Delete(int id)
        {

        }
    }
}