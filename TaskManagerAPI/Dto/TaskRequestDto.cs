using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Dto
{

    public class TaskRequestDto
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }

}
