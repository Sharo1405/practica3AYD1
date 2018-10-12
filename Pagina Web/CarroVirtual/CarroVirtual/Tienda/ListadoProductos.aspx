<%@ Page Title="" Language="C#" MasterPageFile="~/Tienda/TiendaTemplate.Master" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" EnableEventValidation="false" Inherits="CarroVirtual.Tienda.Productos" %>

<%@ Register Src="~/Tienda/CardProducto.ascx" TagPrefix="uc1" TagName="CardProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Main layout-->
    <main>
        <div class="container">

            <!--Navbar-->
            <nav class="navbar navbar-expand-lg navbar-dark mdb-color  special-color-dark mt-3 mb-5">

                <!-- Navbar brand -->
                <span class="navbar-brand">Categories:</span>

                <!-- Collapse button -->
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#basicExampleNav" aria-controls="basicExampleNav"
                    aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <!-- Collapsible content -->
                <div class="collapse navbar-collapse" id="basicExampleNav">

                    <!-- Links -->
                    <ul class="navbar-nav mr-auto" id="lista_cat" runat="server">
                        <li class="nav-item active" runat="server" id="li_todos">
                            <asp:LinkButton ID="LinkButtonAll" runat="server" class="nav-link" OnClick="LinkButtonAll_Click">ALL</asp:LinkButton>
                            <span class="sr-only">(current)</span>
                        </li>
                    </ul>
                    <!-- Links -->

                    <form class="form-inline">
                        <div class="md-form my-2">
                            <!--input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search"-->
                            <asp:TextBox class="form-control mr-sm-2" ID="searchText" runat="server"></asp:TextBox>
                        </div>
                        <div class="md-form my-2">
                            <asp:Button ID="Button1" runat="server" Text="Buscar" class="btn btn-primary btn-deep-orange" Style="padding: 0px; border: 0px;" OnClick="Button1_Click" />
                        </div>

                    </form>
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

                            <uc1:CardProducto runat="server" ID="CardProducto" ProductoCarrito="<%# Container.DataItem %>" />                            

                        </ItemTemplate>

                    </asp:ListView>
                
                </div>
                <!--Grid row-->                

            </section>
            <!--Section: Products v.3-->                        
                     
            <div class="btn-group dropright">
                <asp:DropDownList id="combo_carro" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_producto" class="btn btn-primary dropdown-toggle px-3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" runat="server"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadenaConexion %>" SelectCommand="SELECT * FROM [producto]"></asp:SqlDataSource>                
                <asp:Button ID="Button3" runat="server" Text="Agregar al carro" class="btn btn-primary btn-deep-orange" OnClick="Button3_Click" />
            </div>			

            <!--Pagination-->
            <nav class="d-flex justify-content-center wow fadeIn">
                <ul class="pagination pg-amber">

                    <!--Arrow left-->


                    <li class="page-item">
                        <a class="page-link mt-0" href="#">
                            <asp:Button ID="PREVIOUS" runat="server" Text="Atrás" class="btn-sm" Style="padding: 0px; border: 0px;" CommandName="filtro" CommandArgument="<%#pagina%>" OnCommand="PREVIOUS_Command" />
                        </a>
                    </li>
                    <li class="page-item mx-auto">
                        <a class="page-link align-self-center" href="#">
                            <%=pagina%>
                        </a>
                    </li>

                    <li class="page-item">
                        <a class="page-link " href="#">
                            <asp:Button ID="NEXT" runat="server" Text="Sig." class="btn-sm" Style="padding: 0px; border: 0px;" OnCommand="NEXT_Command" />
                        </a>
                    </li>

                </ul>
            </nav>
            <!--Pagination-->                        

        </div>
    </main>
</asp:Content>
