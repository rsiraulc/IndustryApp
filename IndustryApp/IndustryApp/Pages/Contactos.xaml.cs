using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.Provider;
using IndustryApp.IndustryAppWS;
using IndustryApp.weather;
using Newtonsoft.Json;
using Org.Apache.Http.Client.Params;


namespace IndustryApp.Pages
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Correo { get; set; }
    }

    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            lstContactos.ItemsSource = new List<Contacto>
            {
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"},
                new Contacto {Nombre = "Roberto Arroyo", Correo = "roberto@sdpoint.com", Empresa = "SD Point"},
                new Contacto {Nombre = "Lucero Pelaez", Correo = "lucerito@medtronic.com", Empresa = "Medtronic"},
                new Contacto {Nombre = "Juan Castañeda", Correo = "juan@rsimexico.com", Empresa = "RSI México"}
            };
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var c = (Contacto) e.SelectedItem;
            //DisplayAlert("IndustryApp", c.Nombre, "OK");

            //EjemploWS();
           // EjemploApi();
        }

        private async void EjemploApi()
        {
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://10.0.0.51:666/");
            var response = await client.GetAsync("contacto");

            var result = response.Content.ReadAsStringAsync().Result;
            var rootobject = JsonConvert.DeserializeObject<Contactos>(result);
        }

        private void EjemploWS()
        {
            var x = new WebServiceSoapClient();
            var w = new WeatherSoapClient();

            var wcf = new WCFIndustryApp.Service1Client();
            wcf.GetDataCompleted += Wcf_GetDataCompleted;
            wcf.GetDataAsync(5);
            wcf.CloseAsync();
            x.HelloWorldCompleted += X_HelloWorldCompleted;
            x.HelloWorldAsync();


        }

        private void Wcf_GetDataCompleted(object sender, WCFIndustryApp.GetDataCompletedEventArgs e)
        {
            var x = e.Result;
        }

        private void X_HelloWorldCompleted(object sender, HelloWorldCompletedEventArgs e)
        {
            try
            {
                var x = e.Result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
