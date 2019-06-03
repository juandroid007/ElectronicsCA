create table Empleados (
cedula int primary key,
nombre varchar(80),
apellido varchar(80),
pwd varchar(32)
);
go

create table Proveedores (
id int identity(1, 1) primary key,
nombre varchar(50),
rif varchar(50) unique not null,
dir_fiscal varchar(50) unique not null
);
go

create table TiposProductos (
id int identity(1, 1) primary key,
descripcion varchar(20)
);
go

create table Productos(
id int identity(1, 1) primary key,
nombre varchar(50) not null,
descripcion varchar(50) not null,
precio int not null,
cantidad int not null,
proveedor int foreign key references Proveedores(id) on delete cascade not null,
tipo int foreign key references TiposProductos(id) on delete cascade not null
);
go

create table Clientes (
id int identity(1, 1) primary key,
cedula int unique,
nombre varchar(50) not null,
apellido varchar(50) not null,
telefono varchar(15)
);
go

create table Facturas (
id int identity(1, 1) primary key,
ced_cliente int foreign key references Clientes(cedula) on delete cascade,
fecha date
);
go

create table DetalleFactura (
id int identity(1, 1),
id_factura int foreign key references Facturas(id) on delete cascade not null,
id_producto int foreign key references Productos(id) on delete cascade not null,
cantidad int,
precio int
);
go

create function fnVerProductos()
returns table
as
return (
	select
	P.id, P.nombre, P.descripcion, P.precio, P.cantidad, P.proveedor id_proveedor, Prv.nombre proveedor, P.tipo id_tipo, T.descripcion tipo
	from Productos P
	inner join Proveedores Prv on P.proveedor = Prv.id
	inner join TiposProductos T on P.tipo = T.id
	);
go

create function fnVerFactura(@id_factura int)
returns table
as
return (
	select
	F.id, C.cedula, C.nombre, C.apellido, C.telefono, F.fecha
	from Facturas F
	inner join Clientes C on F.ced_cliente = C.cedula
	where F.id = @id_factura
	);
go

create function fnVerDetalleFactura(@id_factura int)
returns table
as
return (
	select
	P.id, D.cantidad, P.nombre producto, D.precio
	from DetalleFactura D
	inner join Productos P on D.id_producto = P.id
	where D.id_factura = @id_factura
	);
go

create proc sp_ModificarEmpleado
@cedula int,
@nueva_cedula int,
@nombre varchar(80),
@apellido varchar(80),
@pwd varchar(32) = ''
as
begin
	begin tran
	begin try
		if(@pwd != '')
			update Empleados
			set
				cedula = @nueva_cedula,
				nombre = @nombre,
				apellido = @apellido,
				pwd = @pwd
			where
				cedula = @cedula;
		else
			update Empleados
			set
				cedula = @nueva_cedula,
				nombre = @nombre,
				apellido = @apellido
			where
				cedula = @cedula;
		commit tran;
	end try
	begin catch
		rollback tran
	end catch
end
go

create procedure sp_AgregarProveedor
	@nombre varchar(50),
	@rif varchar(50),
	@dir_fiscal varchar(50)
as
begin
	begin tran
	begin try
		insert into Proveedores values (@nombre, @rif, @dir_fiscal);
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end
go


create procedure sp_AgregarTipoProducto
	@descripcion varchar(20)
as
begin
	begin tran
	begin try
		insert into TiposProductos values (@descripcion);
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end
go

create procedure sp_AgregarProducto
	@nombre varchar(50),
	@descripcion varchar(50),
	@precio int,
	@cantidad int,
	@proveedor varchar(50),
	@tipo varchar(20)
as
begin
	begin tran
	begin try
		insert into Productos values (
			@nombre, @descripcion, @precio, @cantidad, @proveedor, @tipo
		);
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_AgregarCliente
	@cedula int,
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(15)
as
begin
	begin tran
	begin try
		insert into Clientes values (
			@cedula, @nombre, @apellido, @telefono
		);
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_AgregarFactura
	@ced_cliente int
as
begin
	set nocount on;
	begin tran
	begin try
		insert into Facturas values (
			@ced_cliente, GETDATE()
		);
		commit tran
		select ident_current('Facturas');
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_AgregarDetalleFactura
	@id_factura int,
	@id_producto int,
	@cantidad int,
	@precio int
as
begin
	begin tran
	begin try
		declare @cantidad_producto int;
		set @cantidad_producto = (select cantidad from Productos where Productos.id = @id_producto);
		declare @restante int;
		set @restante = @cantidad_producto - @cantidad;
		

		if (@restante >= 1)
			begin
				insert into DetalleFactura values (
					@id_factura, @id_producto, @cantidad, @precio);
				update Productos
				set cantidad = @restante
				where id = @id_producto;
			end
		else
			begin
				insert into DetalleFactura values (
					@id_factura, @id_producto, @cantidad_producto, @precio);
				update Productos
				set cantidad = 0
				where id = @id_producto;
			end
			print @restante;
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_ModificarProducto
	@id int,
	@nombre varchar(50),
	@descripcion varchar(50),
	@precio int,
	@cantidad int,
	@proveedor varchar(50),
	@tipo varchar(20)
as
begin
	begin tran
	begin try
		update Productos
		set
			nombre = @nombre,
			descripcion = @descripcion,
			precio = @precio,
			cantidad = @cantidad,
			proveedor = @proveedor,
			tipo = @tipo
		where
			id = @id;
		commit tran;
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_ModificarProveedor
	@id int,
	@nombre varchar(50),
	@rif varchar(50),
	@dir_fiscal varchar(50)
as
begin
	begin tran
	begin try
		update Proveedores
		set
			nombre = @nombre,
			rif = @rif,
			dir_fiscal = @dir_fiscal
		where
			id = @id;
		commit tran;
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_ModificarTipoProducto
	@id int,
	@descripcion varchar(20)
as
begin
	begin tran
	begin try
		update TiposProductos
		set
			descripcion = @descripcion
		where
			id = @id;
		commit tran;
	end try
	begin catch
		rollback tran
	end catch
end
go

create proc sp_ModificarCliente
	@id int,
	@cedula int,
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(15)
as
begin
	begin tran
	begin try
		update Clientes
		set
			cedula = @cedula,
			nombre = @nombre,
			apellido = @apellido,
			telefono = @telefono
		where
			id = @id;
		commit tran;
	end try
	begin catch
		rollback tran
	end catch
end
go

/*
exec sp_AgregarTipoProducto 'Celular';
exec sp_AgregarTipoProducto 'Computadora';
exec sp_AgregarProveedor 'Samsung', 'J-29515503', 'El sol, mancha solar #4837';
exec sp_AgregarProveedor 'Hewlett-Packard', 'J-11855799', 'La luna, cráter #50394';
exec sp_AgregarProducto 'Compaq Presario', 'Laptop Compaq', 0, 10, 'Hewlett-Packard', 'Computadora';
exec sp_AgregarProducto 'Samsung Galaxy S10', 'Smartphone Samsung', 0, 10, 'Samsung', 'Celular';
exec sp_AgregarCliente 11855799, 'Anneline María', 'Campos Camejo', '04166962397'
exec sp_AgregarFactura 11855799
exec sp_AgregarDetalleFactura 1, 8, 4, 2
select IDENT_CURRENT('Facturas')

delete from Facturas

select * from Facturas
select * from DetalleFactura

select * from fnVerFactura(1);
select * from fnVerDetalleFactura(1);

select * from Proveedores;
select * from TiposProductos;
select * from Productos
inner join Proveedores Prv on Productos.proveedor = Prv.id;
select * from Empleados;
select * from Facturas;
*/