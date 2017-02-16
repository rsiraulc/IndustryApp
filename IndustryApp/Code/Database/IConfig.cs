using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace IndustryApp.Code.Database
{
    public interface IConfig
    {
        string DirectorioBD { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
