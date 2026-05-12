using System.ComponentModel.DataAnnotations;


namespace Models.Entities
{
    public class ExportRcDetail
    {
        [Key]
        public int Id { get; set; }
        public int ExportRcId { get; set; }
        public int DeviceId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation property
        public Devices Device { get; set; }
        public ExportRc ExportRc { get; set; }
    }
}