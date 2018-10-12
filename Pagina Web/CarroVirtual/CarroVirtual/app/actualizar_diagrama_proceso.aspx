<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizar_diagrama_proceso.aspx.cs" Inherits="diagrama.app.actualizar_diagrama_proceso" %>

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
						Actualizar Datos Proceso
					
					
					
					</span>


                  <div class="wrap-input100">
						<span class="label-input100">Nombre proceso</span>
						<asp:textBox  ID="nombre_etapa" runat="server" class="input100" type="text" name="nombre_etapa"  />
							<span class="focus-input100" data-symbol="&#xf206;"></span>

                      </div>
                    <div class="wrap-input100">
						<span class="label-input100">Descripcion Proceso</span>
						<asp:textBox  ID="descripcion" runat="server" class="input100" type="text" name="descripcion"  TextMode="multiline" Columns="50" Rows="5"/>
							<span class="focus-input100" data-symbol="&#xf206;"></span>

                      </div>

                        <div class="wrap-input100">
                         <span class="label-input100">Fecha vencimiento</span>
                  	<asp:textBox  ID="fechan"  runat="server" class="input100" type="date" name="username" />
                
                        
											
					</div>

                     <div class="wrap-input100">
						<span class="label-input100">Tipo de proceso</span>
                         <br />
						
                         <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                      </div>




                		<div class="container-login100-form-btn text-center">
		
                           <asp:button id="actualizar" runat="server"   CssClass="btn btn-success"   Text="Actualizar Datos" OnClick="actualizar_Click"/>
                            
							
					</div>
      

                



					

					
					</div>
				
				</div>
		</div>

    
    </form>
</body>
</html>

