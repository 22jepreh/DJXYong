using DJXYong.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DJXYong.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void Register_btn_Click(object sender, EventArgs e)
        {
            String email = Email_txt.Text;
            String username = Username_txt.Text;
            String password = Password_txt.Text;
            String confpass = ConfPass_txt.Text;
            
            if(email == "" || username == "" || password == "" || confpass == "")
            {
                Status_lbl.Text = "All fields must be filled";
                return;
            }
            else if (password != confpass)
            {
                Status_lbl.Text = "Password must be identical";
                return;
            }
            else if (!email.Contains("@") || email.IndexOf("@") == 0 || email.IndexOf("@") == email.Length - 1)
            {
                Status_lbl.Text = "Email must contain @ in the right place";
                return;
            }
            else if (!email.Contains(".") || email.IndexOf(".") == 0 || email.IndexOf(".") == email.Length - 1)
            {
                Status_lbl.Text = "Email must contain . in the right place";
                return;
            }

            String role = "User";
            if(email.Contains("Admin") || email.Contains("admin"))
            {
                role = "Admin";
                return;
            }

            Status_lbl.Text = UserRepository.CreateNewUser(email, username, password, role);
        }

        protected void ToLogin_linkbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}