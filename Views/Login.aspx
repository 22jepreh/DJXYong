<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DJXYong.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Login</h2>
        <div>
            <asp:Label ID="Username_lbl" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="Username_txt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Password_lbl" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="Password_txt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberMe_cb" runat="server" /> Remember Me
        </div>
        <div>
            <asp:Label ID="Status_lbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Login_btn" runat="server" Text="Login" OnClick="Button1_Click"/>
        </div>
        <asp:LinkButton ID="ToRegister_linkbtn" runat="server" OnClick="ToRegister_linkbtn_Click">Don't have an account? Register here</asp:LinkButton>
    </form>
</body>
</html>
