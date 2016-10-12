using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using IndustryApp.Code.Models;
using SQLite.Net;

namespace IndustryApp.Code.Database
{
    class DataAccess:IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioBD, "IndustryAppBD.db3"));

            //TABLAS
            connection.CreateTable<Contactos>();
        }


        public void InsertContacto(Contactos contacto)
        {
            connection.Insert(contacto);
        }

        public void UpdateContacto(Contactos contacto)
        {
            connection.Update(contacto);
        }

        public void DeleteContacto(Contactos contacto)
        {
            connection.Delete(contacto);
        }

        public List<Contactos> GetContactos()
        {
            return connection.Table<Contactos>().ToList();
        } 

        public Contactos GetContactoById(int id)
        {
            return connection.Table<Contactos>().FirstOrDefault(c => c.Id == id);
        }
                
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
