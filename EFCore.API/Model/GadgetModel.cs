using System.ComponentModel.DataAnnotations;

namespace EFCore.API.Model
{
    public class GadgetModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30), MinLength(4)]
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Cost { get; set; }
        public string Type { get; set; }
    }
}
