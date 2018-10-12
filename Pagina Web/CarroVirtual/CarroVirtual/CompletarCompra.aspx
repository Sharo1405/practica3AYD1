<%@ Page Language="C#" MasterPageFile="~/BaseCompra.Master" AutoEventWireup="true" CodeBehind="CompletarCompra.aspx.cs" Inherits="CarroVirtual.CompletarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Confirmar Compra</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Nombre:</span>
						<asp:TextBox class="input100" runat="server" id="txt_nombre"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Se requiere un apellido">
						<span class="label-input100">Apellido: </span>
						<asp:TextBox class="input100" runat="server" id="txt_apellido" ></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Se requiere DPI">
						<span class="label-input100">DPI: </span>
						<asp:TextBox class="input100" runat="server" id="txt_dpi"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Se requiere una direccion de entrega">
						<span class="label-input100">Direccion de entrega: </span>
						<asp:TextBox class="input100" runat="server" id="txt_direccion"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>
                 
                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="btn_registrar" OnClick="btn_registrar_Click" runat="server" class="login100-form-btn" Text="COMPRAR"></asp:Button>
						</div>
					</div>
                   
                    <br>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="Button2" OnClick="btn2_regresar_Click" runat="server" class="login100-form-btn" Text="Regresar/Canselar"></asp:Button>
						</div>
					</div>
        </div>
</asp:Content>
