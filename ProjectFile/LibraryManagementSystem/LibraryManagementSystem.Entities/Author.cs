using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        [MinLength(1), MaxLength(30)]
        public string AuthorFirstName { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        [MinLength(1), MaxLength(30)]
        public string AuthorLastName { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        // nav. prop.
        [System.ComponentModel.Browsable(false)]
        public ICollection<Book> Books { get; set; }
    }
}
