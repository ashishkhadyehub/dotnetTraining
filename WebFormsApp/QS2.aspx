<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="QS2.aspx.cs" Inherits="WebFormsApp.QS2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
    <div class="row">
        <div class="col-md-6">
            <label>Name:</label>
            <asp:TextBox runat="server" CssClass="form-control my-2" ID="txtName" />
            <label>Contact:</label>
            <asp:TextBox runat="server" CssClass="form-control my-2" ID="txtContact" />
            
        </div>
    </div>
</div>
</asp:Content>
