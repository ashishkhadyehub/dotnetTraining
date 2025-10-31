<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UploadImages.aspx.cs" Inherits="WebFormsApp.UploadImages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-4">
        <div class="row">
            <div class="col-md-6">
                <label>Select Image to Upload:</label>
               
                <asp:FileUpload AllowMultiple="true" runat="server" ID="fileUploadImage" CssClass="form-control my-2" />
                <asp:Button Text="Upload" ID="btnUpload" OnClick="btnUpload_Click" CssClass="btn btn-danger" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
