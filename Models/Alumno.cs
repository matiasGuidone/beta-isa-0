using System.ComponentModel.DataAnnotations;
namespace beta_isa_0.Models
{
     public class Alumno
    {
         
        public int Id { get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string Correo { get; set; }
    }
}