Feature: Modificar el estado de un pedido
	Para poder modificar el estado de un pedido y evitar errores en su cambio
	como usuario administrador
	quiero que al seleccionar un pedido especifico se pueda cambiar el estado 
	y muestre si el cambio fue correcto.

@ModEstado
Scenario: CambiarEstadoDeIniciadoACompletado
	Given el codigo de la factura 1000
	And el estado de la factura "Iniciado" con su identificador 1
	And el nuevo estado de la factura "Completado" con su identificador 2
	When al momento de presionar el boton de Editar Pedido
	Then se debe realizar la modificacion del pedido y validar con un valor distinto de 0
