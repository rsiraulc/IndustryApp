using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Support.V4.App;
using Xamarin.Forms;


namespace IndustryApp.Code
{
    class Notificaciones
    {
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public TargetPlatform OS { get; set; }

        public Notificaciones(string _titulo, string _mensaje, TargetPlatform _os)
        {
            Titulo = _titulo;
            Mensaje = _mensaje;
            OS = _os;
        }

        //public void NuevaNotificacion(Context cont)
        //{
        //    NotificationCompat.Builder builder = new NotificationCompat.Builder(cont)
        //        .SetAutoCancel(true)
        //        .SetNumber(1)
        //        .SetContentText(Titulo)
        //        .SetSubText(Mensaje);

        //    NotificationManager nm = (NotificationManager)GetSystemService

        //}
    }
}
