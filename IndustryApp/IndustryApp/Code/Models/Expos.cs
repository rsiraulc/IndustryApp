using System;

namespace IndustryApp.Code.Models
{
    public class Expos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
    }
}