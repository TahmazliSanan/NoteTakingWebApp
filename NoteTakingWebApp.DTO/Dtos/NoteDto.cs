using System.ComponentModel.DataAnnotations;

namespace NoteTakingWebApp.DTO.Dtos
{
    public class NoteDto : BaseDto
    {
        [Required(ErrorMessage = "Title cannot be empty!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content cannot be empty!")]
        public string Content { get; set; }
    }
}