using System.Collections.Generic;

namespace IndustryApp.Code.Models
{
    public class Sponsors
    {
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        //public int IdExpo { get; set; }
        public string Descripcion { get; set; }
        public string Nivel { get; set; }
        //public string URLWeb { get; set; }
        //public string URLFacebook { get; set; }
        //public string URLTwitter { get; set; }

        public List<Sponsors> GetAllSponsors()
        {
            return new List<Sponsors>
            {
                new Sponsors { Nombre = "Smurfit Kappa", Descripcion = "", Imagen = "spn_smurfitkappa.png"},
                new Sponsors { Nombre = "Macquiare", Descripcion = "", Imagen = "spn_macquarie.png"},
                new Sponsors { Nombre = "MATCO", Descripcion = "", Imagen = "spn_matco.png"},
                new Sponsors { Nombre = "RSI México", Descripcion = "", Imagen = "spn_rsi.png"},
                new Sponsors { Nombre = "Datatechnic", Descripcion = "", Imagen = "spn_datatechnic.png"},
                new Sponsors { Nombre = "Modular", Descripcion = "", Imagen = "spn_modular.png"},
                new Sponsors { Nombre = "Machine Tools Supply", Descripcion = "", Imagen = "spn_mts.png"},
                new Sponsors { Nombre = "Kafco de México", Descripcion = "", Imagen = "spn_kafko.png"},
                new Sponsors { Nombre = "Telnor", Descripcion = "", Imagen = "spn_telnor.png"},
                new Sponsors { Nombre = "Cygo", Descripcion = "", Imagen = "spn_cygo.png"},
                new Sponsors { Nombre = "Siglo 21", Descripcion = "", Imagen = "spn_siglo21.png"},
                new Sponsors { Nombre = "ExpoBaja", Descripcion = "", Imagen = "spn_expobaja.png"},
                new Sponsors { Nombre = "Empleo Nuevo", Descripcion = "", Imagen = "spn_empleonuevo.png"},
                new Sponsors { Nombre = "G5", Descripcion = "", Imagen = "spn_g5.png"},
                new Sponsors { Nombre = "Wens Graphics", Descripcion = "", Imagen = "spn_wens.png"},
            };
        }

        public List<Sponsors> GetSponsorsPlatino()
        {
            return new List<Sponsors>
            {
                new Sponsors {Nombre = "Smurfit Kappa", Descripcion = "", Imagen = "spn_smurfitkappa.png"}
            };
        }

        public List<Sponsors> GetSponsorsOro()
        {
            return new List<Sponsors>
            {
                new Sponsors { Nombre = "MATCO", Descripcion = "", Imagen = "spn_matco.png"},
                new Sponsors { Nombre = "Badger", Descripcion = "", Imagen = "spn_badger.png"},
            };
        }

        public List<Sponsors> GetSponsorsPlata()
        {
            return new List<Sponsors>
            {
                new Sponsors {Nombre = "Datatechnic", Descripcion = "", Imagen = "spn_datatechnic.png"},
                new Sponsors {Nombre = "Modular", Descripcion = "", Imagen = "spn_modular.png"},
            };
        }

        public List<Sponsors> GetSponsorsApoyo()
        {
            return new List<Sponsors>
            {
                new Sponsors { Nombre = "Macquiare", Descripcion = "", Imagen = "spn_macquarie.png"},
                new Sponsors { Nombre = "RSI México", Descripcion = "", Imagen = "spn_rsi.png"},
                new Sponsors { Nombre = "Telnor", Descripcion = "", Imagen = "spn_telnor.png"},
                new Sponsors { Nombre = "Cygo", Descripcion = "", Imagen = "spn_cygo.png"},
                new Sponsors { Nombre = "Siglo 21", Descripcion = "", Imagen = "spn_siglo21.png"},
                new Sponsors { Nombre = "ExpoBaja", Descripcion = "", Imagen = "spn_expobaja.png"},
                new Sponsors { Nombre = "Empleo Nuevo", Descripcion = "", Imagen = "spn_empleonuevo.png"},
                new Sponsors { Nombre = "G5", Descripcion = "", Imagen = "spn_g5.png"},
                new Sponsors { Nombre = "Wens Graphics", Descripcion = "", Imagen = "spn_wens.png"},
            };
        }
    }
}