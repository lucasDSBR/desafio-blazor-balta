using System.ComponentModel.DataAnnotations;

namespace BlazorBalta.Models
{
    public class Ibge
    {
        [Key]
        public string Id { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
