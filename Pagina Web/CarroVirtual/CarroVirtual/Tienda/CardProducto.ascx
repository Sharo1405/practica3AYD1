<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CardProducto.ascx.cs" Inherits="CarroVirtual.Tienda.CardProducto" %>

<!--Grid column-->
<div class="col-lg-3 col-md-6 mb-4">
    <!--Card-->
    <div class="card">

        <!--Card image-->
        <div class="view overlay">
            <img src="<%= ProductoCarrito.imagenURL %>" class="card-img-top" height="300">
            <a>
                <div class="mask rgba-white-slight"></div>
            </a>
        </div>
        <!--Card image-->

        <!--Card content-->
        <div class="card-body text-center">
            <!--Category & Title-->
            <a href="" class="grey-text">
                <h5>
                    <%= ProductoCarrito.nombre %>
                </h5>
            </a>
            <h5>
                <strong>
                    <a href="" class="dark-grey-text">                        
                          <!--span class="badge badge-pill danger-color">NEW</!--span-->
                        <%= ProductoCarrito.categoria %>
                    </a>
                </strong>
            </h5>
            <h4 class="font-weight-bold blue-grey-text">
                <strong>
                    $
                    <%= ProductoCarrito.precio %>
                    <!-- <button class="btn btn-default" OnClick="Button1_Click">Agregar</button> -->
                </strong>
            </h4>    
            <!--
            <asp:Button ID="Button1" runat="server" Text="Agregar" class="btn btn-primary btn-deep-orange" 
                CommandName="producto" CommandArgument="<%# ProductoCarrito.nombre %>" />-->

        </div>
        <!--Card content-->
    </div>
    <!--Card-->
</div>
<!--Grid column-->
