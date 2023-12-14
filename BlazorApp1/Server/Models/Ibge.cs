
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Server.Models
{
    public class Ibge
    {
        [Key]
        public string Id { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
    }
}
