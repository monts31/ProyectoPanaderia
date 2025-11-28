create database ventas;
use ventas;
create table empleados(
	id_empleado int auto_increment primary key,
	nombre varchar(50) not null,
	usuario varchar(50) not null,
	contraseña varchar(40) not null,
	telefono varchar(10),
	correo varchar(30), 
	rol enum('Administrador', 'Empleado'),
	horas int,
	sueldo decimal(10, 4) not null,
	estado enum('Activo', 'Baja')
);

create table productos(
	id_producto int auto_increment primary key,
	nombre varchar(50) not null,
	descripcion varchar(60),
	precio decimal(10,4) not null,
	stock int not null,
    estado enum('Activo', 'Descontinuado'),
	foto longblob
);

create table auditorias(
	id_auditoria int auto_increment primary key,
	usuario varchar(50) not null,
	fecha datetime default current_timestamp,
	tipo_movimiento enum('Insertar','Eliminar','Modificar'),
	valor_anterior varchar(1000),
	valor_nuevo varchar(1000)
);

create table Ordenes(
	id_Orden int primary key auto_increment not null,
	id_Empleado int not null,
	fecha datetime default current_timestamp,
	foreign key (id_Empleado) references Empleados(id_Empleado)
	on delete cascade
);

create table detalles(
	id_Orden int not null,
	id_Producto int not null,
	precio decimal(10,4) not null,
	cantidad int not null,
	primary key (id_Orden, id_Producto), -- MEJORA
	foreign key (id_Producto) references Productos(id_Producto),
	foreign key (id_Orden) references Ordenes(id_Orden)
	on delete cascade
);

-- TRIGGERS --
delimiter $$
create trigger trgProductoInsertado after insert on productos
for each row
begin 
	declare tUsuario varchar(50);
    declare nuevo varchar(1000);
    
    set tUsuario =  IFNULL(@usuarioActual, 'Admin');
    
    set nuevo = concat('Nombre: ', NEW.nombre, ' ',
        'Descripcion: ', NEW.descripcion, ' ',
        'Precio: ', NEW.precio, ' ',
        'Stock: ', NEW.stock, ' ', 
        'Estado', NEW.estado);
    
    insert into auditorias(usuario, tipo_movimiento, valor_nuevo) 
    values (tUsuario, 'Insertar', nuevo);
end $$

create trigger trgProductoModificado after update on productos
for each row
begin
	declare anterior varchar(1000) default '';
    declare nuevo varchar (1000) default '';
    declare tUsuario varchar(50);
     
	set tUsuario = IFNULL(@usuarioActual, 'Admin');
    
    if old.nombre <> new.nombre then
		set anterior = concat(anterior, 'Nombre: ', old.nombre, ' ');
        set nuevo = concat(nuevo, 'Nombre: ', new.nombre, ' ');
	end if;
    
    if old.descripcion <> new.descripcion then
		set anterior = concat(anterior, 'Descripcion: ', old.descripcion, ' ');
        set nuevo = concat(nuevo, 'Descripcion: ', new.descripcion, ' ');
	end if;
    
    if old.precio <> new.precio then
		set anterior = concat(anterior, 'Precio: ', old.precio, ' ');
        set nuevo = concat(nuevo, 'Precio: ', new.precio, ' ');
	end if;
    
    if old.stock <> new.stock then
		set anterior = concat(anterior, 'Stock: ', old.stock, ' ');
        set nuevo = concat(nuevo, 'Stock: ', new.stock, ' ');
	end if;
    
    if old.estado <> new.estado then
		set anterior = concat(anterior, 'Estado: ', old.stock, ' ');
        set nuevo = concat(nuevo, 'Estado: ', new.stock, ' ');
	end if;
    
		insert into auditorias(usuario, tipo_movimiento, valor_anterior, valor_nuevo) values 
		(tUsuario,
		'Modificar',
		anterior,
		nuevo);
end $$

-- PROCEDIMIENTOS --
Delimiter $$
create procedure pInsertarEmpleado(
	in pNombre varchar(50), in pUsuario varchar(50), in pContraseña varchar(40), in pTelefono varchar(10), in pCorreo varchar(30), 
    in pRol enum('Administrador','Empleado'), in pHoras int, in pSueldo decimal(10,4), in pEstado enum('Activo', 'Baja')
)
begin 
	insert into empleados (nombre, usuario, contraseña, telefono, correo, rol, horas, sueldo, estado)
    values (pNombre, pUsuario, sha1(pContraseña), pTelefono, pCorreo, pRol, pHoras, pSueldo, pEstado);
end $$

create procedure pModificarEmpleado(
	in pId_empleado int, in pNombre varchar(50), in pUsuario varchar(50), in pContraseña varchar(40), in pTelefono varchar(10), in pCorreo varchar(30), 
    in pRol enum('Administrador','Empleado'), in pHoras int, in pSueldo decimal(10,4), in pEstado enum('Activo', 'Baja')
)
begin 
	if not exists (select 1 from empleados where id_empleado = pId_empleado) THEN
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Error: El empleado no existe.';
    end if;

    update empleados
    set nombre = pNombre, usuario = pUsuario, contraseña = sha1(pContraseña), telefono = pTelefono, correo = pCorreo,
    rol = pRol, horas = pHoras, sueldo = pSueldo, estado = pEstado
    where id_empleado = pId_empleado;
end $$

create procedure pEliminarEmpleado(
	in pId_empleado int
)
begin 
	if not exists (select 1 from empleados where id_empleado = pId_empleado) THEN
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Error: El empleado no existe.';
    end if;
    
	update empleados set estado = 'Baja' where id_empleado = pId_Empleado;
end $$
    
delimiter ;


-- PRUEBAS --
call pInsertarEmpleado ('Jonathan Alejandro', 'admin', '123', '4451234568', 'ja@gmail.com', 'Administrador', 8, 1241.41, 'Activo');
call pModificarEmpleado (1,'Jonathan Alejandro', 'admin', '123', '4451214114', 'ja@gmail.com', 'Administrador', 6, 1241.41, 'Activo');

select * from empleados;
SET @usuarioActual = 'Admin1';

use ventas;
insert into productos(nombre, descripcion, precio, stock, estado) values 
('Conchita', 'Pan tipo concha', 12.50, 35, 1), -- id_producto = 1
('Cuernito', 'Pan tipo croissant', 10.0, 30, 1),
('Campechana', 'Pan tipo campechana', 13.4, 20, 1),
('Orejita', 'Pan tipo oreja', 9.98, 25, 1),
('Dona', 'Dona de fresa', 8.70, 40, 1),
('Bolillo', 'Bolillo para torta', 5.00, 50, 1),
('Rebanada', 'Rebanada de mantequilla', 12.00, 31, 1),
('Empanada', 'Empanada de piña', 14.21, 12, 1);

select * from productos;
select * from auditorias;

update productos set stock = 30 where id_producto = 17;


