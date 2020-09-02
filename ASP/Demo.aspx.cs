using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            // 10. Se establece conexión a la base de datos //test
            string connectionString;  // Declaración de variables
            SqlConnection cnn; // Declaración de variables

            // "Server=(LocalDB)\\MSSQLLocalDB;Database=CoreBB;User=sa;Pwd=Unemamad249"
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ASPDemoDB ;User ID=sa;Password=Unemamad249"; // Establecimiento de string de conexión

            cnn = new SqlConnection(connectionString); // Se asigna conexión

            cnn.Open(); // Apertura conexión
            Response.Write("Conexión hecha</br>");
            cnn.Close(); // Cierre conexión

           
            //// 11. Insersión de información
            //Response.Write("\n Insersión de 3 - VB.Net");

            //SqlCommand command2;  // Defino variables
            //SqlDataAdapter adapter = new SqlDataAdapter(); // defino variables, el objeto dataadapter se usa para insert, delete y update
            //string sql2 = ""; // defino variables

            //sql2 = "INSERT INTO demotb (TutorialID, TutorialName) VALUES (3, '" + "VB.Net" + "')"; // defino la declaración de insersión

            //command2 = new SqlCommand(sql2, cnn); // defino el comando sqlcommand

            //cnn.Open();
            //adapter.InsertCommand = new SqlCommand(sql2, cnn); // Asocio el comando de insert
            //adapter.InsertCommand.ExecuteNonQuery();

            //command2.Dispose(); // cierro objetos
            //cnn.Close();

            //// 12 Update de registro
            //Response.Write("<h2>Actualización  de 3 - VB.Net a VB.Net Complete</h2></br>");

            //SqlCommand command2;  // Defino variables
            //SqlDataAdapter adapter = new SqlDataAdapter(); // defino variables, el objeto dataadapter se usa para insert, delete y update
            //string sql2 = ""; // defino variables

            //sql2 = "UPDATE demotb SET TutorialName ='" + "VB.Net Complete'" + " WHERE TutorialID = 3"; // defino la declaración de insersión

            //command2 = new SqlCommand(sql2, cnn); // defino el comando sqlcommand

            //cnn.Open();
            //adapter.UpdateCommand = new SqlCommand(sql2, cnn); // Asocio el comando de insert
            //adapter.UpdateCommand.ExecuteNonQuery();

            //command2.Dispose(); // cierro objetos
            //cnn.Close();

            //// 13 Delete de registro
            //Response.Write("<h2>Eliminación  de 3 - VB.Net Complete</h2></br>");

            //SqlCommand command2;  // Defino variables
            //SqlDataAdapter adapter = new SqlDataAdapter(); // defino variables, el objeto dataadapter se usa para insert, delete y update
            //string sql2 = ""; // defino variables

            //sql2 = "DELETE FROM demotb WHERE TutorialID = 3"; // defino la declaración de eliminación

            //command2 = new SqlCommand(sql2, cnn); // defino el comando sqlcommand

            //cnn.Open();
            //adapter.DeleteCommand = new SqlCommand(sql2, cnn); // Asocio el comando de insert
            //adapter.DeleteCommand.ExecuteNonQuery();

            //command2.Dispose(); // cierro objetos
            //cnn.Close();

            // 14. Envío de comando select a la tabla demotb
            SqlCommand command; // Defino variables
            SqlDataReader dataReader; // Defino variables
            string sql, Output = ""; // Defino variables

            sql = "SELECT TutorialID, TutorialName FROM demotb"; // declara Sentencia sql

            command = new SqlCommand(sql, cnn); // se declara comando

            cnn.Open(); // Se abre conexión para poder leer

            dataReader = command.ExecuteReader(); // Se defina la lectura de información

            while (dataReader.Read()) // se obtiene la información de la tabla
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "</br>";
            }

            Response.Write(Output);
            dataReader.Close(); // Es buena práctica cerrar la conexión
            command.Dispose();
            cnn.Close();

            // Para dividir información perteneciente al formulario web
            Response.Write("</br><h2>Información del formulario</h2>");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //// 3. Se envia el valor del textbox al cliente
            //Response.Write("El nombre introducido es: " + txtName.Text + "</br>");
            //// 4. Se envia el valor seleccionado del listbox al cliente
            //Response.Write(lstLocation.SelectedItem.Text + "</br>");

            // 6. session management
            Session["Name"] = txtName.Text; // Se guarda el nombre introducido en el textbox en el objeto de Session
            Response.Write(Session["Name"]); // Se devuelve / muestra al usuario la informacion de la variable de sesion

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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}