<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="sign-up.aspx.cs" Inherits="Orphanage.sign_up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sign up</h1>

    <div class="signup-form">
        <div class="form-group">
            <asp:TextBox ID="txtfname" runat="server" CssClass="form-control" placeholder="First Name"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtlname" runat="server" CssClass="form-control" placeholder="Last Name"></asp:TextBox>
        </div>    
        <div class="form-group">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtmobile" runat="server" CssClass="form-control" placeholder="Mobile"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtAdress" runat="server" CssClass="form-control" placeholder="Address" Height="113px" Width="189px"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtPassword1" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtPassword2" runat="server"  CssClass="form-control" placeholder="Re-enter Password" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnSignup" runat="server" CssClass="btn-signup" Text="Sign Up" OnClick="Button1_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

    </div>
</asp:Content>
