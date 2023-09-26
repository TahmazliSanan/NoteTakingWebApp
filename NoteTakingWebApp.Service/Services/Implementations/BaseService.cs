using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NoteTakingWebApp.DataAccess.Db;
using NoteTakingWebApp.DataAccess.Entities;
using NoteTakingWebApp.Service.Services.Abstracts;

namespace NoteTakingWebApp.Service.Services.Implementations
{
    public class BaseService<TRequestDto, TEntity, TResponseDto> 
        : IBaseService<TRequestDto, TEntity, TResponseDto> 
        where TEntity : BaseEntity
    {
        protected readonly IMapper _mapper;
        protected readonly AppDbContext _appDbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseService(IMapper mapper, AppDbContext appDbContext)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public virtual TResponseDto Create(TRequestDto requestDto)
        {
            var entity = _mapper.Map<TEntity>(requestDto);
            entity.CreateId = 1;
            entity.CreatedAt = DateTime.Now;
            _dbSet.Add(entity);
            _appDbContext.SaveChanges();
            var responseDto = _mapper.Map<TResponseDto>(entity);
            return responseDto;
        }

        public virtual TResponseDto GetById(int id)
        {
            var entity = _dbSet.Find(id);
            var responseDto = _mapper.Map<TResponseDto>(entity);
            return responseDto;
        }

        public virtual IEnumerable<TResponseDto> GetAll()
        {
            var allEntities = _dbSet.ToList();
            var responseDto = _mapper.Map<IEnumerable<TResponseDto>>(allEntities);
            return responseDto;
        }

        public virtual TResponseDto Update(TRequestDto requestDto)
        {
            var entity = _mapper.Map<TEntity>(requestDto);
            entity.UpdateId = 1;
            entity.UpdatedAt = DateTime.Now;
            _dbSet.Update(entity);
            _appDbContext.SaveChanges();
            var responseDto = _mapper.Map<TResponseDto>(entity);
            return responseDto;
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity is not null)
            {
                _dbSet.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}