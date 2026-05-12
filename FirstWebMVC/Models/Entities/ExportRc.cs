using System.ComponentModel.DataAnnotations;


namespace Models.Entities
{
    public class ExportRc
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime ExportDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}