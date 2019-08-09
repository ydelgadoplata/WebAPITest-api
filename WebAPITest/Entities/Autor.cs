using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAPITest.Helpers;

namespace WebAPITest.Entities
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        [PrimeraMayusc]
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
