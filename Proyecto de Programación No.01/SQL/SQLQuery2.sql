

select IdCategoria,Descripcion,Estado from CATEGORIA

select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado,r.IdRol,r.Descripcion from usuario u
inner join rol r on r.IdRol = u.IdRol

SELECT * FROM  CATEGORIA

select * from PRODUCTO

select * from CLIENTE

insert into PRODUCTO(Codigo,Nombre,Descripcion,IdCategoria) values ('01001','Refrijerador','Refrigeradora Samsumg',3)
insert into PRODUCTO(Codigo,Nombre,Descripcion,IdCategoria) values ('01002','Televisor',' Samsumg',3)

update PRODUCTO set Estado = 1






select IdProducto,Codigo,Nombre,p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioCompra,PrecioVenta,p.Estado from  PRODUCTO p
inner join CATEGORIA c on c.IdCategoria = p.IdCategoria


INSERT INTO CATEGORIA(DESCRIPCION,ESTADO) VALUES('Dispositivos electronicos',1)
INSERT INTO CATEGORIA(DESCRIPCION,ESTADO) VALUES('Electronicaa de consumo y TIC',1)
INSERT INTO CATEGORIA(DESCRIPCION,ESTADO) VALUES('Electrodomesticos',1)
INSERT INTO CATEGORIA(DESCRIPCION,ESTADO) VALUES('Equipos de iluminacion',1)

update CATEGORIA  set Estado = 1




update usuario set estado = 0 where idusuario = 2

select IdCliente,Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE

select IdProveedor,Documento,RazonSocial,Correo,Telefono,Estado from PROVEEDOR

select * from NEGOCIO

insert into NEGOCIO (IdNegocio,Nombre,RUC,Direccion) values (1,'Everything company for my home','101010','av.zona 1,Jalapa.Guatemala')

/*Por una compra se realiza el registro de dos productos en el formato de compras frmCompas*/
select * from COMPRA where NumeroDocumento = '00001'
select * from DETALLE_COMPRA where IdCompra =1

/*Consulta para mi formulario de Detalle de ventas*/
/*Informacion de la compra*/
select c.IdCompra,
u.NombreCompleto,
pr.Documento,pr.RazonSocial,
c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,convert(char(10),c.FechaRegistro,103)[FechaRegistro]
from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento = '00001'


/*Informacion de DetalleCompra*/
select p.Nombre,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal
from DETALLE_COMPRA dc
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
where dc.IdCompra = 1

/*Informacion de DetalleVenta*/
/*Pare ver el detalle de venta*/
select * from VENTA where NumeroDocumento = '00001'
select * from DETALLE_VENTA where IdVenta = 1


/*Resumen de la tabla ventas*/
select v.IdVenta,u.NombreCompleto,
v.DocumentoCliente,v.NombreCliente,
v.TipoDocumento,v.NumeroDocumento,
v.MontoPago,v.MontoCambio,v.MontoTotal,
convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NumeroDocumento = '00001'

select 
p.Nombre,dv.PrecioVenta,dv.Cantidad,dv.SubTotal
from DETALLE_VENTA dv
inner join PRODUCTO p on p.IdProducto = dv.IdProducto
where dv.IdVenta = 1

/*Resumen de la tabla de reporte de compra y de ventas*/

select 
CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro],c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,
u.NombreCompleto[UsuarioRegistro],
pr.Documento[DocumentoProveedor],pr.RazonSocial,
p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]

from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
where CONVERT(date,c.FechaRegistro) between '05/28/2024' and '05/30/2024'
and pr.IdProveedor = 1

select * from COMPRA

/*
insert into rol (Descripcion)
values('ADMINISTRADOR')

insert into rol (Descripcion)
values('EMPLEADO')



 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('20','EMPLEADO','@GMAIL.COM','456',2,1)
 
 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('101010','ADMIN','@GMAIL.COM','123',1,1)*/

select * from rol

select * from PERMISO

select p.IdRol,p.NombreMenu from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO u on u.IdRol = r.IdRol
where u.IdUsuario = 1

/*
insert into PERMISO(IdRol,NombreMenu) values

(1,'menuusuarios'),
(1,'menumantenedor'),
(1,'menuventas'),
(1,'menucompras'),
(1,'menuclientes'),
(1,'menuproveedores'),
(1,'menureportes'),
(1,'menuacercade')


insert into PERMISO(IdRol,NombreMenu) values

(2,'menuventas'),
(2,'menucompras'),
(2,'menuclientes'),
(2,'menuproveedores'),
(2,'menuacercade')
*/
