USE master;

DROP DATABASE IF EXISTS p2;

CREATE DATABASE p2;

USE p2;

CREATE TABLE producto(
	cod_producto INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(200),
	cantidad INT,
	detalles VARCHAR(200),
	precio_venta INT,
	imagen VARBINARY(MAX),
	categoria_cod_categoria INT NOT NULL,
);

CREATE TABLE categoria(
	cod_categoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(200),
	descripcion VARCHAR(200)
);

create table Factura(
	cod_factura int not null identity(1000,1) primary key,
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	DPI int not null,
	zona_entrega varchar(200) not null,
	fecha date not null,
);
create table detalle_factura(
	detalle_cod_factura int not null,
	producto_cod_producto int not null
	primary key(detalle_cod_factura,producto_cod_producto),
	CONSTRAINT  fk_detalle_cod_factura FOREIGN KEY (detalle_cod_factura) REFERENCES Factura (cod_factura),
	CONSTRAINT  fk_producto_cod_producto FOREIGN KEY (producto_cod_producto) REFERENCES producto (cod_producto)
)

ALTER TABLE producto
    ADD CONSTRAINT producto_categoria_fk FOREIGN KEY ( categoria_cod_categoria )
        REFERENCES categoria ( cod_categoria ) ON DELETE CASCADE;

--Correr 22/09/18
create table carro(
	cod_carro INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	producto_cod_producto INT NOT NULL
);

ALTER TABLE carro
    ADD CONSTRAINT carro_producto_fk FOREIGN KEY ( producto_cod_producto )
    REFERENCES producto ( cod_producto ) ON DELETE CASCADE;


-- Estado Pedido

create table EstadoPedido(
	cod_estado INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(200),
);

insert into EstadoPedido (nombre )values('Iniciado'),('Completado'),('Cancelado');

alter table Factura
	Add Estado INT, CONSTRAINT factura_estado__fk FOREIGN KEY ( Estado)
    REFERENCES EstadoPedido ( cod_estado ) ON DELETE CASCADE;


	select * from carro;
	truncate table carro;
	SELECT * from producto;
	select * from categoria;

	insert into carro(producto_cod_producto) values (1),(2),(3);