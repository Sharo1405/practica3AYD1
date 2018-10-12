<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta4.aspx.cs" Inherits="diagrama.app.diagrama.consulta4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Actualizar Datos</title>


<!-- estido div -------------------------------------------------------------------------------------------------->
     	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css/">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
</head>
<body>
    <form id="form1" runat="server">
   
           <div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100 p-l-25 p-r-25 p-t-25 p-b-24">
			
					<span class="login100-form-title p-b-49">
						Consulta 4<br />
                    Notificaciones</span><div class="wrap-input100 text-center">
					
                    <div class="wrap-input100">
                         <span class="login100-form-title">Por fecha</span>

                         <span class="label-input100 text-left">Rango de Fechas</span>
                  	<asp:textBox  ID="fecha_inicial"  runat="server" class="input100" type="date" name="dias" />
                       <asp:textBox  ID="fecha_fin"  runat="server" class="input100" type="date" name="dias" />
                
                         <asp:button id="por_fecha" runat="server"   CssClass="btn btn-success"   Text="Relizar Consulta" OnClick="por_fecha_Click" />
                            
											
					</div>

                          <div class="wrap-input100">
                         <span class="login100-form-title">Notificaciones no contestadas</span>

   
                         <asp:button id="por_no" runat="server"   CssClass="btn btn-success"   Text="Relizar Consulta" OnClick="por_no_Click" />
                            
											
					</div>
                         <br />
                         <br />

                 <div class="wrap-input100 text-center">
                         <asp:GridView ID="GridView1"   runat ="server" BackColor="#CCFFCC" CssClass ="text-center">
                        </asp:GridView>
                        
											
					</div>
                      

					    
					
					    <br />
                            
                        <asp:button id="volver" runat="server"   CssClass="btn btn-success"   Text="Regresar" OnClick="volver_Click" />
                            
                        <br />
					     
					</div>






              

      

                



					

					
					</div>
				
				</div>
		</div>

    
    </form>
</body>
</html>
