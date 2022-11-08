using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Aula
    {
        [Key]    
        public int Id { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        [Column(TypeName ="char")]
        [StringLength(1)]
        public string Codigo { get; set; }
    }
}
