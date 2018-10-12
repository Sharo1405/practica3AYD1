<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizar_diagrama_etapa.aspx.cs" Inherits="diagrama.app.actualizar_diagrama_etapa" %>

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
						Actualizar Datos Etapa
					
					</span>


                   <div class="wrap-input100 text-center">
					
                        <br />
					           <asp:DropDownList ID="DropDownList1" runat="server" >
                        </asp:DropDownList>
					
					    <asp:button id="cargar_etapa" runat="server"   CssClass="btn btn-success"   Text="CargarEtapa" OnClick="cargar_etapa_Click"/>
					     
					    <br />
                        <br />
					     
					</div>

                  <div class="wrap-input100">
						<span class="label-input100">Nombre Etapa</span>
						<asp:textBox  ID="nombre_etapa" runat="server" class="input100" type="text" name="nombre_etapa"  />
							<span class="focus-input100" data-symbol="&#xf206;"></span>

                      </div>
                <div class="wrap-input100">
                      <span class="label-input100">Usuario Encargado</span>
                      <br />
                        <asp:DropDownList ID="DropDownList2" runat="server" >
                        </asp:DropDownList>
											
					</div>




                		<div class="container-login100-form-btn">
		
                           <asp:button id="actualizar" runat="server"   CssClass="btn btn-success"   Text="Actualizar Etapa" OnClick="actualizar_Click"/>
                            
                            <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" Text="siguiente" OnClick="Button2_Click"  >
								
							</asp:Button>
                       
							
					</div>

                     <asp:Button ID="volver" CssClass="btn btn-success" runat="server" Text="volver" OnClick="volver_Click" >
								
							</asp:Button>
               
      

                



					

					
					</div>
				
				</div>
		</div>

    
    </form>
</body>
</html>
