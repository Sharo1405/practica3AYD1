﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="eliminarProducto.aspx.cs" Inherits="CarroVirtual.eliminarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Eliminar Producto</span>

					<div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Busque un producto por nombre o código</span>
						<asp:TextBox class="input100" runat="server" id="txt_buscar"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

                    <div class="wrap-input100 m-b-23">
						<asp:Button class="input100" runat="server" id="btn_buscar" Text="Buscar" OnClick="btn_buscar_Click"></asp:Button>
					</div>

                    <div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Código</span>
						<asp:TextBox class="input100" runat="server" id="txt_codigo" ReadOnly="true"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>
                    
                    <div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Nombre</span>
						<asp:TextBox class="input100" runat="server" id="txt_nombre" ReadOnly="true"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>
                    
                    <div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Categoría</span>
						<asp:DropDownList class="input100" runat="server" id="combo_categoria" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_categoria"></asp:DropDownList>
						<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadenaConexion %>" SelectCommand="SELECT * FROM [categoria]"></asp:SqlDataSource>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

                    <br />
                    <br>
                    <div class="wrap-input100 validate-input">
						<asp:Image runat="server" id="imgProducto" BorderStyle="Solid" Height="400px" Width="300px"></asp:Image>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>
					
                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="btn_eliminar" OnClick="btn_eliminar_Click" runat="server" class="login100-form-btn" Text="Eliminar Producto"></asp:Button>
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
