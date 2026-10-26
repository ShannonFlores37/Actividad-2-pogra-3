using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Actividad_2_pogra_3
{
    public static class ConexionBD
    {
        public static OleDbConnection ObtenerConexion()
        {

            //dar la direccion de la base de datos 
            string rutaBS = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, //directorio base de datos           
                "Datos",
                "Escuela.accdb"
                );
            string cadenaConexion = $"Provider=Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source={rutaBS};"; 
         return new OleDbConnection(cadenaConexion);


        }
    }
}
