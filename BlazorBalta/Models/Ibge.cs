using System.ComponentModel.DataAnnotations;

namespace BlazorBalta.Models
{
    public class Ibge
    {
        [Key]
        public string Id { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
    }
}
