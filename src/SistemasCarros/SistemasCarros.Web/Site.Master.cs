using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasCarros.Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Teste");
            var dao = new DAO.MarcaDAO();

            var l = dao.SelectAll();

            Console.WriteLine(l);
        }
    }
}