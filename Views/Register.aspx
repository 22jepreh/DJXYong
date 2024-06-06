<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DJXYong.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Register</h2>
        <div>
            <asp:Label ID="Email_lbl" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="Email_txt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Username_lbl" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="Username_txt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Password_lbl" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="Password_txt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="ConfPass_lbl" runat="server" Text="Confirm Password : "></asp:Label>
            <asp:TextBox ID="ConfPass_txt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Status_lbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Register_btn" runat="server" Text="Register" OnClick="Register_btn_Click"/>
        </div>
        <asp:LinkButton ID="ToLogin_linkbtn" runat="server" OnClick="ToLogin_linkbtn_Click">Already have an account? Login here</asp:LinkButton>
    </form>
</body>
</html>
