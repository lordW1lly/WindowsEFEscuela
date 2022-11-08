using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Required]//campo obligatorio - DB: NOT NULL
        public int ProfesorId { get; set; }
       
        
        [StringLength(50)]//longitud máxima de la cadena
        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")]//tipo de datos de sql server
        public string Apellido { get; set; }
        [StringLength(50)]//longitud máxima de la cadena
        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")]//tipo de datos de sql server
        public string Nombre { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [Required]
        public string Titulo { get; set; }
    }
}

