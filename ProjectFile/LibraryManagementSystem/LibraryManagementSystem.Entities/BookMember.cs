using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    [Table("BookMembers")]
    public class BookMember
    {
        [Key]
        public int Id { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "RentalDate")]
        public DateTime BookMemberRentalDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "LeaseEndDate")]
        public DateTime BookMemberLeaseEndDate { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        // nav. prop.
        [System.ComponentModel.Browsable(false)]
        public Member Members { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Book Books { get; set; }
    }
}
