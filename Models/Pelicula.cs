using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula_DH211056.Models
{
    public class Pelicula
    {
        public int ID { get; set; }
        [StringLength(250)]
        [Required]
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        
        [Display(Name = "Género")]
        [Required]
        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [StringLength(250)]
        [Required]
        public string Director {  get; set; }
        
    }
}
