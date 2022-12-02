using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string TodoTitle { get; set; }
        [Display(Name = "Description")]
        public string TitleDescription { get; set; }
    }
}
