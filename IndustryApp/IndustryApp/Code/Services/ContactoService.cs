using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;

namespace IndustryApp.Code.Services
{
    class ContactoService
    {
        public static List<Models.Contactos> listaContactos = new List<Models.Contactos>();

        public bool AddContacto(Contactos _contacto)
        {
            var existe = listaContactos.Find(x => x.Correo == _contacto.Correo);
            if (existe == null)
            {
                listaContactos.Add(_contacto);
                return true;
            }
            else
                return false;
        }

        public List<Models.Contactos> GetListaContactos()
        {
            return listaContactos;
        }

        public int GetListaCount()
        {
            return listaContactos.Count;
        }

    }
}
