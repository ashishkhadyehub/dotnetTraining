<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ShowDataFromDB.aspx.cs" Inherits="WebFormsApp.ShowDataFromDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-4">
        <div class="row">
            <div class="col-md-6">
                <label>Name:</label>
                <asp:TextBox ID="txtName" CssClass="form-control my-2" Enabled="false" runat="server" />
                <label>Contact:</label>
                <asp:TextBox ID="txtContact" CssClass="form-control my-2" Enabled="false" runat="server" />
                <label>Email:</label>
                <asp:TextBox ID="txtEmail" CssClass="form-control my-2" Enabled="false" runat="server" />
                <label>City:</label>
                <asp:TextBox ID="txtCity" CssClass="form-control my-2" Enabled="false" runat="server" />


            </div>
        </div>
    </div>
</asp:Content>
