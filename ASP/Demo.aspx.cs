using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // 3. Se envia el valor del textbox al cliente
            Response.Write("El nombre introducido es: " + txtName.Text + "</br>");
            // 4. Se envia el valor seleccionado del listbox al cliente
            Response.Write(lstLocation.SelectedItem.Text + "</br>");

            // 5. Se marcan todos los controles como invisibles
            lblName.Visible = false;
            txtName.Visible = false;
            lstLocation.Visible = false;
            chkASP.Visible = false;
            chkC.Visible = false;
            rdMale.Visible = false;
            rdFemale.Visible = false;
            btnSubmit.Visible = false;
        }
    }
}