using System.ComponentModel.DataAnnotations;


namespace Models.Entities
{
    public class ImportRcDetail
    {
        [Key]
        public int Id { get; set; }
        public int ImportRcId { get; set; }
        public ImportRc ImportRc { get; set; }
        public int DeviceId { get; set; }
        public Devices Device { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}