using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcCompany.Models.DBEntities
{
    public class Reseller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string ResellerName { get; set; }
        [Required]
        public  string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; }
        [Required]
        public int FaxNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ContactPersonName { get; set; }
        [Required]

        public int ContactPersonPhoneNumber { get; set; }
        
    }
}
