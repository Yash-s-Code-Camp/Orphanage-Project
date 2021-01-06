<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Orphanage.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>

    <div class="login-form">
        <div class="form-group">
            <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" placeholder="******"></asp:TextBox>
        </div>    
        <div class="form-group">
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-login" OnClick="btnLogin_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblstatus" runat="server"></asp:Label>
        </div>

    </div>
</asp:Content>
