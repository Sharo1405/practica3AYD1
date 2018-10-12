<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="Editar_categoria.aspx.cs" Inherits="CarroVirtual.Editar_categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Editar Categoria</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Nombre de la Categoria a editar</span>
						<span class="focus-input100"></span>
					</div>

                    <asp:DropDownList ID="DropDownList1" runat="server" Width="388px">
                    </asp:DropDownList>
                    <div>
                        <br />
                        <br />
                        <div>
                            <span class="label-input250">Nuevos datos para la categoria</span>
                        </div>
                    </div>
                    <div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Nuevo Nombre de la Categoria</span>
						<asp:TextBox class="input100" runat="server" id="txt_nombre" Height="31px" Width="449px" ></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Se requiere una descripcion">
						<span class="label-input100">Nueva Descripcion</span>
						<asp:TextBox class="input100" runat="server" id="txt_descripcion" Height="31px" Width="447px"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>            

                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="btn_editar_cat" OnClick="editar_categoria" runat="server" class="login100-form-btn" Text="Editar Categoria"></asp:Button>
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
