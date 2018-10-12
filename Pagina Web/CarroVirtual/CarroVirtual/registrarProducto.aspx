<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="registrarProducto.aspx.cs" Inherits="CarroVirtual.registrarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Registrar Producto</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Nombre del Producto</span>
						<asp:TextBox class="input100" runat="server" id="txt_nombre"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Se requiere una descripcion">
						<span class="label-input100">Descripcion</span>
						<asp:TextBox class="input100" runat="server" id="txt_descripcion" ></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Se requiere un precio">
						<span class="label-input100">Precio de venta</span>
						<asp:TextBox class="input100" runat="server" id="txt_precio"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Se requiere una cantidad">
						<span class="label-input100">Cantidad a ingresar</span>
						<asp:TextBox class="input100" runat="server" id="txt_cantidad"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Se requiere una categoria">
						<span class="label-input100">Categoria</span>
						<asp:DropDownList class="input100" runat="server" id="combo_categorias" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_categoria" ></asp:DropDownList>
						<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadenaConexion %>" SelectCommand="SELECT * FROM [categoria]"></asp:SqlDataSource>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>
                    
                    <br>
                    <div class="wrap-input100 validate-input">
						<span class="label-input100">Seleccionar Imagen del Producto</span>
						<asp:FileUpload runat="server" id="fuimagen" class="form-control"></asp:FileUpload>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

                    <br>
                    <div class="wrap-input100 validate-input" data-validate="Se requiere una Imagen">
						<asp:Image runat="server" id="imgProducto" BorderStyle="Solid" Height="400px" Width="300px"></asp:Image>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>
					
                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="btn_registrar" OnClick="btn_registrar_Click" runat="server" class="login100-form-btn" Text="Registrar Producto"></asp:Button>
						</div>
					</div>
                    
                    <br>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<a runat="server" href="indexAdmin.aspx" class="login100-form-btn">Regresar/Cancelar</a>
						</div>
					</div>
        </div>
</asp:Content>
