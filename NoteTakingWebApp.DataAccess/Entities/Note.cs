namespace NoteTakingWebApp.DataAccess.Entities
{
    public class Note : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}