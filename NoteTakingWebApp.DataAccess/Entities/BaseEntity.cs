namespace NoteTakingWebApp.DataAccess.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int CreateId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdateId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}