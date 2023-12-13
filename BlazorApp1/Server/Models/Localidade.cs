
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Server.Models
{
    public class Localidade
    {

        [Key]
        public int Id { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CodigoIbge { get; set; }
    }
}
