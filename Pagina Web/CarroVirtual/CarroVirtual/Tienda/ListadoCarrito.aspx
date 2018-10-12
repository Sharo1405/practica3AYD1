<%@ Page Title="" Language="C#" MasterPageFile="~/Tienda/TiendaTemplate.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="ListadoCarrito.aspx.cs" Inherits="CarroVirtual.Tienda.ListadoCarrito" %>

<%@ Register Src="~/Tienda/CardCarrito.ascx" TagPrefix="uc1" TagName="CardCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!--Main layout-->
  <main>
    <div class="container">

      <!--Navbar-->        
      <nav class="navbar-dark mdb-color  special-color-dark mt-3 mb-5">
        <!-- Collapsible content -->
          <div class="mask rgba-black-strong d-flex justify-content-center align-items-center">
        <div class="text-center white-text mx-5 wow fadeIn">  
            <h1 class="mb-4">
                <br />
                <strong>Carro</strong>                
            </h1>
            </div>
        </div>              
        <!-- Collapsible content -->
      </nav>
      <!--/.Navbar-->

      <!--Section: Products v.3-->
      <section class="text-center mb-4">        
            <!--Grid row-->
            <div class="row wow fadeIn">               
              <asp:ListView ID="ListViewCardProducts" runat="server">
                  <ItemTemplate>
                      <uc1:CardCarrito runat="server" id="CardCarrito" ProductoCarrito="<%# Container.DataItem %>"/>
                  </ItemTemplate>
              </asp:ListView>              
            </div>
            <!--Grid row-->        
      </section>        
      <!--Section: Products v.3-->                
        <div class="btn-group dropright">
                <asp:DropDownList id="combo_carro" DataSourceID="SqlDataSource1" DataValueField="producto_cod_producto" class="btn btn-primary dropdown-toggle px-3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" runat="server"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadenaConexion %>" SelectCommand="SELECT * FROM [carro]"></asp:SqlDataSource>                
                <asp:Button ID="Button2" runat="server" Text="Confirmar Compra" class="btn btn-primary btn-deep-orange " OnClick="Button2_Click"/>               
            </div>	
    </div>
  </main>
  <!--Main layout-->

</asp:Content>