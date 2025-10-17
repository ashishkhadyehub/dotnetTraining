<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebFormsApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--html, css, js + we can add server controls--%>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.0/sweetalert.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.0/sweetalert.min.css" rel="stylesheet" type="text/css" />

      
</head>
<body>
    <form id="form1" runat="server">
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

           
               <asp:Button runat="server" OnClientClick="return valid()"  ID="btnSubmit" Text="Register Now" CssClass="btn btn-outline-success" />
                
           
        </div>
    </form>

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
</body>
</html>
