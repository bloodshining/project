using System.ComponentModel.DataAnnotations;

namespace CoffeeTraining.Models
{
    public class Documents
    {
        [Key]
        public int DocId { get; set; }
        public string DocName { get; set; }
        public int UserId { get; set; }
        public int IdDocumentResourse { get; set; }

        public int DocumentNumber { get; set; }
    }
}
