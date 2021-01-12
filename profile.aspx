<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Orphanage.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Profile Page</p>

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
            <asp:Button ID="btnProfileUpdate" runat="server" CssClass="btn-signup" Text="Update" OnClick="btnProfileUpdate_Click"  />
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

    </div>
</asp:Content>
