Feature: CarroComprasCorrecto
	Para evitar que haya algún tipo de problema con el carro de compras al haber agregado algún producto
	Como un usuario del sistema
	Quiero revisar y asegurarme que su lista no este vacía

@mytag
Scenario: Búsqueda de productos por medio de su código dentro del carro de compras
	Given el codigo "1" de un producto que está dentro del carro de compras	
	When al cargar la pantalla del carrito
	Then se encontrará dicho producto y devolverá un "0"
