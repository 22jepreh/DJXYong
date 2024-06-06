<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DJXYong.Views.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home</h1>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    <asp:Label ID="SongName_lbl" runat="server" Text="Song Name : "></asp:Label>
    <asp:TextBox ID="SongName_txt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="SongArtist_lbl" runat="server" Text="Song Artist : "></asp:Label>
    <asp:TextBox ID="SongArtist_txt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="SongGenre_lbl" runat="server" Text="Song Genre : "></asp:Label>
    <asp:TextBox ID="SongGenre_txt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="SongId_lbl" runat="server" Text="Song Id : "></asp:Label>
    <asp:TextBox ID="SongId_txt" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="Update_btn" runat="server" Text="Update" />
    <asp:Button ID="Delete_btn" runat="server" Text="Delete" />

</asp:Content>
