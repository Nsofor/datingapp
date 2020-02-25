using System.ComponentModel.DataAnnotations;

namespace datingapp2.api.Models
{
    public class Value
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}