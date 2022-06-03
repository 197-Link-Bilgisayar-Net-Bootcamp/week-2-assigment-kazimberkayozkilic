using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.API.DataAccess.Entities
{
    [Table("Gadgets")]
    public class Gadget
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30),MinLength(4)]
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Cost { get; set; }
        public string Type { get; set; }
    }
}
