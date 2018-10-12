<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="Eliminar_categoria.aspx.cs" Inherits="CarroVirtual.Eliminar_categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Eliminar Categoria</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Nombre de la Categoria</span>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

                    <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" Width="409px">
                    </asp:DropDownList>
                    <br>
                    <br>
                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="btn_eliminar_cat" OnClick="eliminar_categoria" runat="server" class="login100-form-btn" Text="Eliminar Categoria"></asp:Button>
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
