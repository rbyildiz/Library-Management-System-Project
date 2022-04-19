using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    [Table("Members")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        [MinLength(1), MaxLength(30)]
        public string MemberFirstName { get; set; }

        [StringLength(30), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        [MinLength(1), MaxLength(30)]
        public string MemberLastName { get; set; }

        [StringLength(13), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [MinLength(10), MaxLength(16)]
        [Display(Name = "Phone Number")]
        public string MemberPhoneNumber { get; set; }

        [StringLength(40), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [MaxLength(40)]
        public string MemberEmail { get; set; }

        [StringLength(300), Column(TypeName = "varchar")]
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(5), MaxLength(300)]
        [Display(Name = "Address")]
        public string MemberAddress { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        // nav. prop.
        [System.ComponentModel.Browsable(false)]
        public ICollection<BookMember> BookMembers { get; set; }
    }
}
