using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

    }
}