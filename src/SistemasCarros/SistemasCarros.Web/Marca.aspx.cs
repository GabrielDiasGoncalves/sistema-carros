using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasCarros.Web
{
    public partial class MarcaPage : Page
    {
        private DAO.MarcaDAO _dao = new DAO.MarcaDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            Grd_Marcas.DataSource = _dao.SelectAll();
            Grd_Marcas.DataBind();
        }

        protected void Deletar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }
    }
}