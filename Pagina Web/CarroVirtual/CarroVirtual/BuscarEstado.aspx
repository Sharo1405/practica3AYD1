<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="BuscarEstado.aspx.cs" Inherits="CarroVirtual.Tienda.BuscarEstado" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Buscar Compra</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						Ingrese su DPI<br />
						<asp:TextBox class="input100" runat="server" id="txtbusqueda" Height="31px" Width="449px" EnableTheming="True"></asp:TextBox>
						
                    <asp:Button id="btnGuardarCat1" OnClick="buscarPedido" runat="server" class="login100-form-btn" Text="Buscar Compra"></asp:Button>
                    </div>

                   
             
                    <div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Id Factura</span>
						<span class="focus-input100">
                        <br />
                        <br />
                        </span>
                        <br />
						<span class="focus-input100">
                     
                        </span>

                           <asp:GridView ID="GridView1" runat="server" Width="419px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Codigo" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="Gridview1IndexChanged">
                               <Columns>
                                   <asp:CommandField ShowSelectButton="True" />
                                   <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="Codigo" />
                                   <asp:BoundField DataField="Lugar" HeaderText="Lugar" SortExpression="Lugar" />
                                   <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                                   <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                               </Columns>
                        </asp:GridView>
					    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadenaConexion %>" SelectCommand="SELECT f.cod_factura as 'Codigo', f.zona_entrega as 'Lugar', f.fecha as 'Fecha',e.nombre as 'Estado'
	FROM Factura as f, EstadoPedido as e
	where f.estado = cod_estado and ([DPI] = @DPI) ;
">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="txtbusqueda" Name="DPI" PropertyName="Text" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Se requiere una descripcion">
						<span class="label-input100">Detalle</span>
						<span class="focus-input100"></span>
                            <asp:GridView ID="GridView2" runat="server" Width="340px">
                                </asp:GridView>
					</div>            

                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbt">
                            
                            </div>
							
						</div>
					</div>
                    
                    <br>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<a runat="server" href="/Tienda/ListadoProductos.aspx" class="login100-form-btn">Regresar/Cancelar</a>
						</div>
					</div>
        </div>
</asp:Content>
