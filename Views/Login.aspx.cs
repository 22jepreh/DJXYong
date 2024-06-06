using DJXYong.Models;
using DJXYong.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DJXYong.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = Username_txt.Text;
            String password = Password_txt.Text;
            Boolean rememberMe = RememberMe_cb.Checked;

            if(username == "" || password == "")
            {
                Status_lbl.Text = "All fields must be filled";
                return;
            }

            User loginUser = UserRepository.LoginUser(username, password);
            if(loginUser == null)
            {
                Status_lbl.Text = "Invalid Credentials";
                return;
            }
            else
            {
                Session["user"] = loginUser;
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void ToRegister_linkbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }
    }
}