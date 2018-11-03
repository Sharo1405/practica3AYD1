<%@ Page Title="" Language="C#" MasterPageFile="~/Tienda/TiendaTemplate.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="CarroVirtual.Tienda.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="container">

            <asp:Panel runat="server" ID="panelComentarios">

            </asp:Panel>          
            <asp:Panel runat ="server" ID="panelNuevoComentario">
                
                 <br />
                  <div style="border: black 1px solid;"> 
                      <div id="div_Comentarios" runat="server">
                          <asp:Panel ID="pnl_comentarios" runat="Server" Height="300px" Width="400px" BackColor="Aqua" ScrollBars="Auto">

                        </asp:Panel>
                      </div>
                      <div>
                        <div>
                            <span class="label-input250">Ingresar Comentario</span>

                            
                        </div>
                    </div>
                       <br />
                    <div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Nombre:      </span>
						<asp:TextBox class="input100" runat="server" id="txtnombre" Height="31px" Width="800px" EnableTheming="True" ReadOnly="False" ></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
                      <br />
                      
                   <div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Comentario: </span>
						<asp:TextBox class="input100" runat="server" id="txtContenido" Height="31px" Width="449px" EnableTheming="True" ReadOnly="False" ></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
                       <br />

                      <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbt"></div>
							<asp:Button id="btnGuardarCat" OnClick="btn_registrar_Click" runat="server" class="login100-form-btn" Text="Publicar "></asp:Button>                            
						</div>
					</div>
                </div>
            </asp:Panel>
        </div>
    </main>
</asp:Content>
