using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



using System.Data; // con base de datos
using System.Data.SqlClient; // sql server
using System.Configuration; // web config

namespace ServicioReniec


{
    /// <summary>
    /// Descripción breve de WSReniec
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]


    public class WSReniec : System.Web.Services.WebService
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        
        

        [WebMethod(Description = "Buscar en la tabla region")]

        public DataSet Buscar(string Ingrese_dni )
        {

            string consulta = String.Empty;
           
            consulta = "select * from persona where dni = '" + int.Parse(Ingrese_dni) + "'";
            
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}
