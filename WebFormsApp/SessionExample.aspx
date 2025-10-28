<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="SessionExample.aspx.cs" Inherits="WebFormsApp.SessionExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-6">
            <h3>Session Example</h3>
<asp:TextBox runat="server" CssClass="form-control my-2" ID="txt1"></asp:TextBox>
<asp:Button runat="server" CssClass="btn btn-outline-success" Text="Click" ID="btnclick" OnClick="btnclick_Click"  />
        </div>
    </div>
</div>
</asp:Content>
