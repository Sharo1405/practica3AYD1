Feature: RegistroDeProducto
	Como usuario quiero realizar pruebas que demuestren que el registro de productos se lleva a cabo de la forma correcta

@tagPruebas
Scenario: Registrar Producto con campos vacios
	Given tengo nombre "producto1" detalle "detalles" precio 100
	When presione el boton ingresar producto
	Then deberia retornarme una variable con valor distinto de false