using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Models;
using IndustryApp.Code.Services.Messages;

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

        public ContactoResponse AddContacto(Contactos _contacto)
        {
            var response = new ContactoResponse();
            var existe = listaContactos.Find(x => x.Correo == _contacto.Correo);
            if (existe == null)
            {
                listaContactos.Add(_contacto);
                response.Contacto = _contacto;
                response.Success = true;
                response.Message = _contacto.Nombre + " ha sido agregado a tu lista de contactos";
            }
            return response;
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
