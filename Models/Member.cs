using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MemberStorage.Models
{
    [Table("Members")]
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [MaxLength(256)]
        public string MemberName { get; set; }
    }
}
