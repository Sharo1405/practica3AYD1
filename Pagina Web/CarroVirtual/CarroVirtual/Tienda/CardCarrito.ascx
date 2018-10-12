<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CardCarrito.ascx.cs" Inherits="CarroVirtual.Tienda.CardProducto" %>

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
            <a class="grey-text">
                <h5>
                    <%= ProductoCarrito.nombre %>
                </h5>
            </a>
            <h5>
                <strong>
                    <a class="dark-grey-text">                        
                          <!--span class="badge badge-pill danger-color">NEW</!--span-->
                        <%= ProductoCarrito.categoria %>
                    </a>
                </strong>
            </h5>
            <h5>
            <h4 class="font-weight-bold blue-grey-text">
                <strong>
                    $
                    <%= ProductoCarrito.precio %>                    
                </strong>
            </h4>  
            </h5>
            <h5>
                <h6 class="dark-grey-text">
                        Unds disp: 
                        <%= ProductoCarrito.cantidadDisponible %>                                        
                </h6>  
            </h5>
            <h5>
                <h6>
                        Requerido: 1                                                               
                </h6>  
            </h5>

        </div>
        <!--Card content-->
    </div>
    <!--Card-->
</div>
<!--Grid column-->