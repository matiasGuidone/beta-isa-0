using Microsoft.EntityFrameworkCore;
using beta_isa_0.Models;
using System.Xml;
namespace beta_isa_0.Context
{
    public class AlumnoContext : DbContext
    {
          public DbSet<Alumno> Alumnos { get; set; }
          public DbSet<Usuario> Usuarios { get;set;}
           public DbSet<Docente> Docentes { get;set;}
          public AlumnoContext(DbContextOptions<AlumnoContext> options) : base(options){

                        }

        //   private static string cadena()
        // {
        //     XmlTextReader reader = new XmlTextReader("./conexion.xml");
        //     while (reader.Read())
        //     {
        //         if (reader.NodeType == XmlNodeType.Element && reader.Name == "cadena")
        //         {
        //             reader.Read();
        //             return reader.Value;
        //         }

        //     }
        //     return "";
        // }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseMySql(cadena());
        //     base.OnConfiguring(optionsBuilder);
        // }
    }
}