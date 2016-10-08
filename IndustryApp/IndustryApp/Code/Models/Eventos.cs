using System;

namespace IndustryApp.Code.Models
{
    public class Eventos
    {
        public int Id { get; set; }
        public int IdExpo { get; set; }
        public string NombreEvento { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreConferencista { get; set; }
}
}