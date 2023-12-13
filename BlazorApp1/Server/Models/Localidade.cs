
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Server.Models
{
    public class Localidade
    {

        [Key]
        int Id { get; set; }
        string? Cidade { get; set; }
        string? Estado { get; set; }
        string? CodigoIbge { get; set; }
    }
}
