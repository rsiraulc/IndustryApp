using System.Collections.Generic;

namespace IndustryApp.Code.Models
{
    public class Stands
    {
        public int NumeroStand { get; set; }
        public string Nombre { get; set; }
        public string NumeroNombre { get; set; }

        public List<Stands> GetStands()
        {
            return new List<Stands>
            {
                new Stands {NumeroStand = 001, Nombre = "Testequity de México S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 002, Nombre = "Corrugados y Empaques de Norteamérica S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 003, Nombre = "Corrugados y Empaques de Norteamérica S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 005, Nombre = "Empresas Matco, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 006, Nombre = "Empresas Matco, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 007, Nombre = "Empresas Matco, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 008, Nombre = "Empresas Matco, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 009, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 010, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 011, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 012, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 013, Nombre = "Datatechnic Automatización y Servicio", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 014, Nombre = "Soluciones de Aire S. de R.L. C.V ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 016, Nombre = "Datatechnic Automatización y Servicio", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 017, Nombre = "Badger Automation", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 018, Nombre = "Badger Automation", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 019, Nombre = "Badger Automation", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 020, Nombre = "Badger Automation", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 101, Nombre = "BC Industrial Supply, S. de R.L.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 102, Nombre = "BC Industrial Supply, S. de R.L.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 103, Nombre = "One Source Industries Group", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 104, Nombre = "Faro", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 105, Nombre = "www.empleonuevo.com", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 106, Nombre = "Kafco de México S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 107, Nombre = "Kafco de México S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 108, Nombre = "ShortCompany", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 108, Nombre = "ShortCompany", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 110, Nombre = "Motrix", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 111, Nombre = "Cold Jet Latinoamérica, S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 112, Nombre = "PROINDEMEX", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 114, Nombre = "Jack Engle de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 202, Nombre = "Grupo Promos", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 217, Nombre = "CROWN XPRESS TRANSPORT", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 302, Nombre = "Oxigeno y Acetileno, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 317, Nombre = "Magid de México LLC.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 702, Nombre = "Sonora S. Plan, S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 717, Nombre = "Placas y Etiquetas Insdustriales", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 802, Nombre = "Tac Global Solutions ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 205, Nombre = "BSI Group", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 214, Nombre = "Integraciones Inovadoras J&J S.A. de C.V. ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 404, Nombre = "Thyssenkrupp Materials North America - Ken Mac Metals Division", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 413, Nombre = "Ensenada International Terminal SA de CV", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 502, Nombre = "Viakon", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 511, Nombre = "BANCO BASE, S.A. Institución de Banca Multiple, Grupo Financiero BASE", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 604, Nombre = "Instrumentos Industriales del Pacifico, S.A.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 613, Nombre = "Mission Plastics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 805, Nombre = "SIAT", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 409, Nombre = "Midexacto", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 410, Nombre = "Thermopac", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 906, Nombre = "INTERMAQ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 907, Nombre = "Cadenas de Ayuda A.C.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 910, Nombre = "Mecalux México, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 911, Nombre = "Servicios de Ingenieria Baja, S.C.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 206, Nombre = "Lubricantes de América, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 215, Nombre = "DIMBC", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 216, Nombre = "Comisión de Desarrollo Industrial ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 301, Nombre = "Masterwork Electronics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 306, Nombre = "Newell Brands", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 316, Nombre = "Arquitectos Especializados del Noroeste", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 313, Nombre = "Allied Tool & Die", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 401, Nombre = "Wens Graphic", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 403, Nombre = "Círculo Llantero SA de CV", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 405, Nombre = "Pinturas Sayer", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 406, Nombre = "Machine Tools Supply de México, S. de R.L.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 415, Nombre = "Toyota Lift", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 414, Nombre = "Pegamentos y Productos Industriales S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 412, Nombre = "Arrega Tecnología SAPI, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 411, Nombre = "Machine Tools Supply de México, S. de R.L.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 501, Nombre = "RSI México, S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 503, Nombre = "Modular Aluminio Estructural", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 510, Nombre = "Modular Aluminio Estructural", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 512, Nombre = "RSI México, S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 601, Nombre = "Dynamic Communications", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 602, Nombre = "Masterwork Electronics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 603, Nombre = "Lee Spring de México S. de R.L. de C.V. ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 605, Nombre = "Techmaster de México, S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 606, Nombre = "Skit Industrial", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 611, Nombre = "Skit Industrial", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},

                new Stands {NumeroStand = 612, Nombre = "HTP de México S.A. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 614, Nombre = "One Source Distributors", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 701, Nombre = "SEI Automation S. de R.L. de C.V.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
            };

        }
    }
}
