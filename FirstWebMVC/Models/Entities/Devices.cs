using System.ComponentModel.DataAnnotations;


namespace Models.Entities
{
    public class Devices
    {
        [Key]
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string SupplierId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufactureDate { get; set; }
    }
}