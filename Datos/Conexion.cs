using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Entidades;

namespace Datos
{
    public class Conexion
    {
        public static string sConnection = @"server = DESKTOP-NKEFFVT\SQLEXPRESS; database = INTEGRADORNET; integrated security = true";
    }
}