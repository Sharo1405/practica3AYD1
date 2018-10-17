Feature: Mostrar el pedido por nit
	Para poder ver el estado de mi pedido
	como usuario 
	quiero que al escribir mi nit se me muestre los pedidos que tengo activos.

@ModEstado
Scenario:  MostrarUnPedidoPorNit
	Given el nit del usuario "1312"
	When al momento de presionar el boton de Buscar Compra
	Then Se retorne un pedido con identificador 1002, nombre "Grupo", apellido "7" zona de entrega "Usac" y estado 1