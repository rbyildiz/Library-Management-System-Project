using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "CategoryName")]
        [MinLength(1), MaxLength(30)]
        public string CategoryName { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        // nav. prop.
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Book> Books { get; set; }
    }
}
