using System.ComponentModel.DataAnnotations;

namespace MyWebApp3.ViewModels
{
    public class BookDeleteViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished{ get; set; }

    }
}