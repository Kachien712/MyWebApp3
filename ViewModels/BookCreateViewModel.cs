using System.ComponentModel.DataAnnotations;

namespace MyWebApp3.ViewModels
{
    public class BookCreateViewModel
    {
        [Required(ErrorMessage = "Tiêu đề sách là bắt buộc.")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Tên tác giả là bắt buộc.")]
        [StringLength(35)]
        public string Author { get; set; }

        [Range (1800, 2025, ErrorMessage = "Năm xuất bản không hợp lệ.")]
        public int YearPublished { get; set; }
    }
}