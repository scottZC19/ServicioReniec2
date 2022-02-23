using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAReniec
{
    public partial class buscarreniec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WSReniecSoapClient WS = new ServiceReference1.WSReniecSoapClient();
            DataSet ds = WS.Buscar(txtbuscar.Text);
            gvdatos.DataSource = ds.Tables[0];
            gvdatos.DataBind();
        }
    }
}