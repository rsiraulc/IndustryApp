using System;

namespace IndustryApp.Code.Models
{
    public class Contactos
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}