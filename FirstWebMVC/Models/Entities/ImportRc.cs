using System.ComponentModel.DataAnnotations;


namespace Models.Entities
{
    public class ImportRc
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime ImportDate { get; set; }   
        public List<ImportRcDetail> Details { get; set; }
    
        public decimal TotalAmount { get; set; }
    }
}