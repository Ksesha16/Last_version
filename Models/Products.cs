using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class Products
    {
        [Key]
        public int ID_Product { get; set; }

        [Required]
        public string Name_of_product { get; set; }

        public string Photo_product { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }
    }
}
