<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    <link href="Bootstrap file and folders/Content/bootstrap.css" rel="stylesheet" />
    <link href="Bootstrap file and folders/Content/signin.css" rel="stylesheet" />

    <script src="Bootstrap file and folders/Scripts/modernizr-2.6.2.js" ></script>
    
    <script src="Bootstrap file and folders/Scripts/bootstrap.js" ></script>
    <script src="Bootstrap file and folders/Scripts/jquery-1.10.2.js" ></script>

</head>
<body>
    
    <div class="container">
    <form id="Form1" class="form-signin" runat="server">
        <h1 class="alert alert-success">Client Management</h1>
        <label for="inputEmail" class="sr-only">User Name</label>
        <input type="text" id="inputEmail" class="form-control" placeholder="User Name" runat="server" required="required" autofocus="autofocus" />

        <label for="inputPassword" class="sr-only">Password</label>
        <input type="password" id="inputPassword" class="form-control" placeholder="Password" runat="server" required="required" autofocus="autofocus" />
        <asp:Button runat="server" CssClass="btn btn-lg btn-success btn-block" Text="Sign In" ID="btnLogin" OnClick="btnLogin_Click" />
    </form>
    </div>
 
</body>
</html>
