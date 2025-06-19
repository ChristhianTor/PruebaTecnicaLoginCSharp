using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportesMVC.Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int IIDPERSONA { get; set; }
        public string? NUMEROIDENTIFICACION { get; set; }
        public string? NOMBRE { get; set; }
        public string? APPATERNO { get; set; }
        public string? APMATERNO { get; set; }
        public int IIDSEXO { get; set; }
        public string? CORREO { get; set; }
        public string? TELEFONOOCELULAR1 { get; set; }
        public string? TELEFONOOCELULAR2 { get; set; }
        public string? CALLE { get; set; }
        public string? NEXTERIOR { get; set; }
        public string? NINTERIOR { get; set; }
        public string? COLONIA { get; set; }
        public string? CP { get; set; }
        public string? MUNICIPIOPAIS { get; set; }
        public string? ESTADOPAIS { get; set; }
        public int IIDTIPODOCUMENTO { get; set; }
        public string? NUMEROREGISTROUNICOCONTRIBUYENTE { get; set; }
        public string? NOMBREFOTO { get; set; }
        public int BHABILITADO { get; set; }

    }
}
