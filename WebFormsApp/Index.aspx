<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebFormsApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--html, css, js + we can add server controls--%>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
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
                    <label>City:</label>
                    <asp:DropDownList runat="server" ID="ddlCities" CssClass="form-control">
                        <asp:ListItem>Select City</asp:ListItem>
                        <asp:ListItem>Kolhapur</asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                    </asp:DropDownList>
                   
                    
                </div>


               <asp:Button runat="server" ID="btnSubmit" Text="Register Now" CssClass="btn btn-outline-success" />
                
           
        </div>
    </form>
</body>
</html>
