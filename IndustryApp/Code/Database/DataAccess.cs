﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Android.Provider;
using IndustryApp.Code.Models;
using IndustryApp.Code.Services.Messages;
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
            connection.CreateTable<Usuario>();
        }

        #region Contactos
        public ContactoResponse InsertContacto(Contactos contacto)
        {
            var response = new ContactoResponse();
            if (GetContactoByCorreo(contacto.Correo) == null)
            {
                connection.Insert(contacto);
                response.Contacto = contacto;
                response.Message = contacto.Nombre + " ha sido agregado a tu lista de contactos";
                response.Success = true;
            }
            else
            {
                response.Message = contacto.Nombre + " ya existe en tu lista de contactos";
            }

            return response;
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
            return connection.Table<Contactos>().OrderBy(c => c.Apellido).ToList();
        } 

        public Contactos GetContactoById(int id)
        {
            return connection.Table<Contactos>().FirstOrDefault(c => c.Id == id);
        }

        public Contactos GetContactoByCorreo(string correo)
        {
            return connection.Table<Contactos>().FirstOrDefault(c => c.Correo == correo);
        }

        public int GetTotalContactos()
        {
            return GetContactos().Count;
        }

        public string GetListaContactosString()
        {
            var contactos = GetContactos();

            return contactos.Aggregate("", (current, c) => current + $"{c.Nombre}, \t{c.Empresa}, \t{c.Correo}, \t{c.Telefono}\r\n");
            //return contactos.Select(c => $"{c.Nombre}\t{c.Empresa}\t{c.Correo}\t{c.Telefono}").ToList();

            //return contactos.Select(c => $"<tr><td>Nombre: {c.Nombre}, Empresa: {c.Empresa}, Email: {c.Correo}, Tel: {c.Telefono}").ToList();
        }

        #endregion

        #region Registro Usuarios
        public bool InsertUsuario(Usuario usuario)
        {
            if (GetContactoByCorreo(usuario.Correo) == null)
            {
                connection.Insert(usuario);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            connection.Update(usuario);
        }

        public void DeleteAllUsuarios()
        {
            connection.DeleteAll<Usuario>();
        }

        public void DeleteContacto(Usuario usuario)
        {
            connection.Delete(usuario);
        }

        public List<Usuario> GetUsuarios()
        {
            return connection.Table<Usuario>().ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            return connection.Table<Usuario>().FirstOrDefault(c => c.Id == id);
        }

        public Usuario GetUsuarioByCorreo(string correo)
        {
            var usrs = GetUsuarios();
            return connection.Table<Usuario>().FirstOrDefault(c => c.Correo == correo);
        }

        public int GetUsuarioId()
        {
            return connection.Table<Usuario>().FirstOrDefault().Id;
        }

        public string GetUsuarioCorreo()
        {
            return connection.Table<Usuario>().FirstOrDefault().Correo;
        }
        #endregion
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
