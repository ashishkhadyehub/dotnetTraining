<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="QS1.aspx.cs" Inherits="WebFormsApp.QS1" %>
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
             <asp:Button runat="server" OnClick="btnConfirm_Click" ID="btnConfirm" CssClass="btn btn-success my-2" Text="Confirm" />
         </div>
     </div>
 </div>
</asp:Content>
