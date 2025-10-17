<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container mt-3">
    <h2>Login form</h2>
  
       
        <div class="mb-3 mt-3">
            <label>Email:</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"></asp:TextBox>
            
        </div>

        
        <div class="mb-3 mt-3">
            <label>Password:</label>
            <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="txtPassword"></asp:TextBox>
            
        </div>

        
   
       <asp:Button runat="server" OnClientClick="return valid()"  ID="btnSubmit" Text="Login Now" CssClass="btn btn-outline-success" />
        
   
</div>
</asp:Content>
