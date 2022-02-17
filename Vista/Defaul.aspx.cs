using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;

namespace Vista
{
    public partial class Defaul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {
            var cliente = new RestClient();
            var peticion = new RestRequest("https://catfact.ninja/fact", Method.Get);
            var respuesta = cliente.ExecuteAsync<datos>(peticion);
            txtDatoCurioso.Text = respuesta.Result.Data.Fact;
            txtLongitud.Text = "Este dato curioso tiene " + respuesta.Result.Data.Length.ToString() + " caracteres";
        }
    }
}