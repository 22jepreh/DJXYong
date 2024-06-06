using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DJXYong.Master
{
    public partial class Header : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Register_btn.Visible = true;
                Login_btn.Visible = true;
                Insert_btn.Visible = false;
                Logout_btn.Visible = false;
            }
            else
            {
                Register_btn.Visible = false;
                Login_btn.Visible = false;
                Insert_btn.Visible = true;
                Logout_btn.Visible = true;
            }
        }

        protected void Register_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void Login_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void Insert_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Insert.aspx");
        }

        protected void Logout_btn_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}