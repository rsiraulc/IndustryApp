using System;

namespace IndustryApp.Code.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Empresa { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}