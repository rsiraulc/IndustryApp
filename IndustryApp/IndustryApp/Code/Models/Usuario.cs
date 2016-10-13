using System;
using SQLite.Net.Attributes;

namespace IndustryApp.Code.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string Plataforma { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}