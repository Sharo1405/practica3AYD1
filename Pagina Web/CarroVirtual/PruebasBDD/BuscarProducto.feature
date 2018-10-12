Feature: BuscarProducto
	Para evitar problemas al buscar
	Como cliente
	Busco un producto en el sistema

@mytag
Scenario: Buscar Producto
	Given El nombre de un producto "smash"
	When clic en buscar
	Then el numero de productos es igual o mayor a 0
