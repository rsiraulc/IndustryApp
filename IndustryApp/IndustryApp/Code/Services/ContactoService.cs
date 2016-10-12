using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;

namespace IndustryApp.Code.Services
{
    class ContactoService
    {
        public List<Models.Contactos> listaContactos = new List<Models.Contactos>();
        public static ObservableCollection<Contactos> ocContactos = new ObservableCollection<Contactos>();

        public List<Models.Contactos> lContactos
        {
            get { return listaContactos; }
            set { lContactos = value; }
        }

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

        public bool AddObservableCollection(Contactos _contacto)
        {

            ocContactos.Add(_contacto);
            return true;
        }

        public List<Models.Contactos> GetListaContactos()
        {
            return listaContactos;
        }

        public ObservableCollection<Models.Contactos> GetOCContactos()
        {
            return ocContactos;
        }

        public int GetListaCount()
        {
            return listaContactos.Count;
        }

        public int GetTotalOCContactos()
        {
            return ocContactos.Count;
        }

    }
}
