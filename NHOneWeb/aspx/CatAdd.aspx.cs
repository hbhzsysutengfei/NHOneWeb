using System;
using NHOneWeb.Dao;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHOneWeb.Model;

namespace NHOneWeb.aspx
{
    public partial class CatAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonAddCat_Click(object sender, EventArgs e)
        {
            CatDao dao = new CatDao();
            CatEntity cat = new CatEntity("cat1", 'F', 10.0f);
            dao.save(cat);
        }
    }
}