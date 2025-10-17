<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebFormsApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3">
    <h2>Registration form</h2>
  
        <div class="mb-3 mt-3">
            <label>Student Name:</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
            
        </div>
        <div class="mb-3 mt-3">
            <label>Contact:</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtContact"></asp:TextBox>
            
        </div>
        <div class="mb-3 mt-3">
            <label>Email:</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"></asp:TextBox>
            
        </div>

        <div class="mb-3 mt-3">
            <label>City:</label>
            
            <asp:DropDownList runat="server" ID="ddlCities" CssClass="form-control">
                <asp:ListItem Value="select">Select City</asp:ListItem>
                <asp:ListItem>Kolhapur</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
            </asp:DropDownList>
           
            
        </div>

   
       <asp:Button runat="server"  OnClick="btnSubmit_Click"   ID="btnSubmit" Text="Register Now" CssClass="btn btn-outline-success" />
        
   
</div>
        <script>
        function valid() {
var name = document.getElementById('<%= this.txtName.ClientID %>').value;
var email = document.getElementById('<%= this.txtEmail.ClientID %>').value;
var phone = document.getElementById('<%= this.txtContact.ClientID %>').value;
var city = document.getElementById('<%= this.ddlCities.ClientID %>').value;
mobilecon = /^\d{10}$/;
emailcon = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/;
            if (name == "" || email == "" || phone == "" || city == "select") {
    swal("Please fill all details to proceed..!","contact your provider","error");
    return false;
}
if (phone != '') {
    if (!phone.match(mobilecon)) {
        swal("Please Enter Valid Contact Number", "", "info");
        return false;

    }
}
if (email != '') {
    if (!email.match(emailcon)) {
        swal("Please Enter Valid Email-Id", "", "info");
        return false;
    }
}
                        
        return true;
}
        </script>
</asp:Content>
