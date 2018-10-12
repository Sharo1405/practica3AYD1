<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="EditarPedido.aspx.cs" Inherits="CarroVirtual.EditarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Editar Compra</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						Seleccione el pedido</div>

                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="Codigo" Height="16px" Width="250px" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="Codigo" />
                            <asp:BoundField DataField="DPI" HeaderText="DPI" SortExpression="DPI" />
                            <asp:BoundField DataField="Entrega" HeaderText="Entrega" SortExpression="Entrega" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                        </Columns>
                    </asp:GridView>
             
                   
             
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadenaConexion %>" SelectCommand="SELECT f.cod_factura as 'Codigo', f.DPI, f.zona_entrega as 'Entrega', f.fecha as 'Fecha',e.nombre as 'Estado'
	FROM Factura as f, EstadoPedido as e
	where f.estado = cod_estado;"></asp:SqlDataSource>
             
                   
             
                    <div>
                        <br />
                        <br />
                        <div>
                            <span class="label-input250">Editar Estado</span>
                        </div>
                    </div>
                    <div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Id Factura</span>
						<asp:TextBox class="input100" runat="server" id="txtIdFactura" Height="31px" Width="449px" EnableTheming="True" ReadOnly="True" ></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Se requiere una descripcion">
						<span class="label-input100">Estado</span>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
						<span class="focus-input100"></span>
					</div>            

                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbt"></div>
							<asp:Button id="btnGuardarCat" OnClick="editarPedido" runat="server" class="login100-form-btn" Text="Editar Pedido"></asp:Button>
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
