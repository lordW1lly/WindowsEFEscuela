using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        [Required]//campo obligatorio - DB: NOT NULL
        public int AlumnoId { get; set; }

        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")]//tipo de datos de sql server
        [StringLength(50)]//longitud máxima de la cadena
        public string Nombre { get; set; }
        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")]//tipo de datos de sql server
        [StringLength(50)]//longitud máxima de la cadena
        public string Apellido { get; set; }
        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "smalldatetime")] //tipo de dato en sql server
       

        public DateTime FechaNacimiento { get; set; }
       
    }
}
