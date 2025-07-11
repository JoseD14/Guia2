using Microsoft.Extensions.Primitives;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula_DH211056.Models
{
    public class Pelicula
    {
        public int ID { get; set; }
        [StringLength(250)]
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name ="Fecha de Lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }
        
        [Display(Name = "Género")]
        [Required]
        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Precio { get; set; }
        [StringLength(250)]
        [Required]
        public string Director {  get; set; }
        
    }
}
