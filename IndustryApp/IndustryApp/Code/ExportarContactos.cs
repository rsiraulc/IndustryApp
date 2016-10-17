using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustryApp.Code.Database;
using System.IO;
using Xamarin.Forms;
using PCLStorage;


namespace IndustryApp.Code
{
    class ExportarContactos
    {
        public async Task WriteFile()

        {
            // GET DATA
            var data = new DataAccess();
            var contactos = data.GetListaContactosString();
            var csv = String.Join("\r\n ", contactos.Select(x => x.ToString()).ToArray());

            var file = await FileSystem.Current.LocalStorage.CreateFileAsync("Contactos.txt", CreationCollisionOption.ReplaceExisting);
            using (var stream = await file.OpenAsync(FileAccess.ReadAndWrite))
            using (var writer = new StreamWriter(stream))
            {
                await writer.WriteAsync(csv);
            }
        }

        public async Task LeerArchivo()
        {
            var file = await FileSystem.Current.LocalStorage.GetFileAsync("Contactos.txt");
            using (var stream = await file.OpenAsync(FileAccess.Read))
            using (var reader = new StreamReader(stream))
            {
                var x = await reader.ReadToEndAsync();
            }
        }

        public async Task EnviarArchivo()
        {
            var data = new DataAccess();
            var correo = data.GetUsuarioCorreo();
            await WriteFile();
            var file = await FileSystem.Current.LocalStorage.GetFileAsync("Contactos.txt");
            using (var stream = await file.OpenAsync(FileAccess.Read))
            using (var reader = new StreamReader(stream))
            {
                var x = await reader.ReadToEndAsync();
                x += "\r\n\r\n Total de contactos: " + data.GetTotalContactos();
                var s = $"mailto:{correo}?subject=IndustryApp - Lista de Contactos&body={x}&attachment={file.Path}";
                Device.OpenUri(new Uri(s));
            }


        }

    }
}
