<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="../css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-wrapper">
             <div class="login-pictures"> 
                 <img src="../pictures/img2.png" />
             </div>
            
             <div class="login-container">
                <h2>Login</h2>
                <div class="form-group">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" onkeypress="focusNextInput(event, this)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password" onkeypress="focusNextInput(event, this)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JlEvB/R63RmGq/sy3wi4xHEURxA6j+e43IkURjknX/mE9tbxl6F2qCXGzH3EfpJM" crossorigin="anonymous"></script>
    <script src="../javascript/JavaScript.js"></script>
</body>
</html>
