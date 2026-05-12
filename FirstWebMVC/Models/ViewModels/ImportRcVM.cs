namespace Models.ViewModels
{
    public class ImportRcVM
    {
        public int SupplierId { get; set; }

        public DateTime ImportDate { get; set; } = DateTime.Now;

        public List<ImportDetailVM> Details { get; set; } = new();
    }
}
