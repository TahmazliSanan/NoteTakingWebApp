namespace NoteTakingWebApp.Service.Services.Abstracts
{
    public interface IBaseService<TRequestDto, TEntity, TResponseDto>
    {
        TResponseDto Create(TRequestDto requestDto);
        TResponseDto GetById(int id);
        IEnumerable<TResponseDto> GetAll();
        TResponseDto Update(TRequestDto requestDto);
        void Delete(int id);
    }
}