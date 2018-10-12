<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Admin.aspx.cs" Inherits="CarroVirtual.Login_Admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="cssLogin/reset.css"/>

    <link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900|RobotoDraft:400,100,300,500,700,900'/>
<link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'/>

        <link rel="stylesheet" href="cssLogin/style.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="pen-title">
  <h1>Login</h1>
</div>
<div class="rerun"><a href="">Bienvenido</a></div>
<div class="container">
  <div class="card"></div>
  <div class="card">
    <h1 class="title">Login</h1>
    <form>
      <div class="input-container">
        
          <asp:TextBox runat="server" id="Username" name="Username" ></asp:TextBox>
        <label for="Username">Username</label>
        <div class="bar"></div>
      </div>
      <div class="input-container">
        
          <asp:TextBox runat="server" id="Password" name="Password" type="Password"></asp:TextBox>
        <label for="Password">Password</label>
        <div class="bar"></div>
      </div>
      <div class="button-container">
          <asp:Button runat="server" OnClick="botoningresar" Text="GO"/>
      </div>  
    </form>
  </div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    </form>
</body>
</html>
