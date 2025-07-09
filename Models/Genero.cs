using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MVCPelicula_DH211056.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Nombre { get; set; }

        [ValidateNever]
        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();

    }
}
