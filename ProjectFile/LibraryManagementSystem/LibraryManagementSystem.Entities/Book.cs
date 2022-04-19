using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        [MinLength(1), MaxLength(30)]
        public string BookName { get; set; }

        [Display(Name = "Author")]
        public int AuthorID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        [Display(Name = "PublicationYear")]
        public int BookPublicationYear { get; set; }

        [StringLength(300), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Summary")]
        [MinLength(1), MaxLength(500)]
        public string BookSummary { get; set; }

        [StringLength(100), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ImagePath")]
        [MinLength(1), MaxLength(100)]
        public string BookImagePath { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Language")]
        [MinLength(1), MaxLength(30)]
        public string BookLanguage { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        // Nav. prop.
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<BookMember> BookMembers { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Category Category { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Author Author { get; set; }
    }
}
