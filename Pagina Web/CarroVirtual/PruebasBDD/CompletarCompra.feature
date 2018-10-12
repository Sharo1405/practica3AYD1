Feature: CompletarCompra
	Como cliente quiero validar que se esta realizando correctamente una compra, para evitar
	errores en los pedidos

@mytag
Scenario: Ingreso de una factura con los atributos correctos
	Given tengo un encabezado de factura con los siguientes datos "Nombre","Apellido","Fecha","DPI","Direccion"
	And una lista de productos con codigo 1, nombre "cod2"
	And un segundo producto con codigo 2, nombre "cod3"
	And un tercer producto con codigo 3, nombre "cod5"
	When yo presiono el boton de completar compra
	Then se debe ingresar los datos y validarlo retornando un valor mayor que 0