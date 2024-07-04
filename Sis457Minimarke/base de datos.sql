CREATE DATABASE LabMinimarke;

USE [master]
GO
CREATE LOGIN [usrminim] WITH PASSWORD=N'123456',
DEFAULT_DATABASE=[LabMinimarke],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=ON
GO
USE [LabMinimarke]
GO
CREATE USER [usrminim] FOR LOGIN [usrminim]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrminim]
GO

-- DROP TABLE CompraDetalle;
DROP TABLE Venta;
DROP TABLE Inventario;
DROP TABLE Cliente;
DROP TABLE Usuario;
DROP TABLE Empleado;
DROP TABLE Proveedor;
DROP TABLE Producto;

GO
CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(20) NOT NULL,
  nombre VARCHAR(150) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  categoria VARCHAR(150) NOT NULL,
  precioVenta DECIMAL NOT NULL CHECK(precioVenta > 0),
    CONSTRAINT fk_Producto_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
GO
CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(150) NOT NULL,
  nombreEmpresa VARCHAR(50) NOT NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  correoElectronico VARCHAR(250) NOT NULL
);
GO
CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  cargo VARCHAR(30) NOT NULL,
  celular BIGINT NOT NULL,
  correoElectronico VARCHAR(250) NOT NULL,
  salario VARCHAR(30) NOT NULL,
  fechaContratacion DATE NOT NULL DEFAULT GETDATE(),
);
GO
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(100) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
GO
CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  fechaRegistro DATE NOT NULL DEFAULT GETDATE()
);
GO
CREATE TABLE Inventario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProducto INT NOT NULL,
   idProveedor INT NOT NULL,
  idEmpleado INT NOT NULL,
  cantidadStock INT NOT NULL,
  fechaUltimaRepocision DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_Inventario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id),
    CONSTRAINT fk_Inventario_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);
GO
CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProducto INT NOT NULL,
  idCliente INT NOT NULL,
  idEmpleado INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
   CONSTRAINT fk_Venta_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id),
   CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
   CONSTRAINT fk_Venta_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

-- ver
ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

--ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
--ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
--ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER PROC paProductoListar @parametro VARCHAR(50)
AS
  SELECT * FROM Producto
  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro,' ','%')+'%'; 

EXEC paProductoListar 'Tang';

-- dml

-- PRODUCTO
INSERT INTO Producto (codigo, nombre, descripcion, categoria, precioVenta, idProveedor) 
VALUES 
('P001', 'Tang', 'Jugo en polvo', 'Bebidas', 10.99, 1);

INSERT INTO Producto (codigo, nombre, descripcion, categoria, precioVenta, idProveedor) 
VALUES 
('P002', 'Ace', 'jabon liquido', 'Productos de limpieza', 20.50, 2);

INSERT INTO Producto (codigo, nombre, descripcion, categoria, precioVenta, idProveedor) 
VALUES 
('P003', 'Leche Pil', 'descremada', 'Lácteos', 20.50, 2);

-- EMPLEADO
INSERT INTO Empleado (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, cargo, celular, correoElectronico, salario, fechaContratacion) 
VALUES 
('1234567890', 'Juan', 'Pérez','Paraná', 'Calle Principal 123', 'Gerente', 1234567890, 'juan@example.com', '5000 USD', '2024-01-15');

INSERT INTO Empleado (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, cargo, celular, correoElectronico, salario, fechaContratacion) 
VALUES 
('5678901234', 'Carlos', 'Rodríguez', 'Mar', 'Calle Secundaria 789', 'Cajero', 5678901234, 'carlos@example.com', '2500 USD', '2024-03-10');

-- USUARIO
INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('noel', 'i0hcoO/nssY6WOs9pOp5Xw==', 1);

INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('jperez', 'i0hcoO/nssY6WOs9pOp5Xw==', 2);

-- PROVEEDOR
INSERT INTO Proveedor (nombre, nombreEmpresa, direccion, celular, correoElectronico) 
VALUES ('Juan Pérez', 'Empresa ABC', '123 Calle Falsa, Ciudad', 9876543210, 'juan.perez@empresaabc.com');

INSERT INTO Proveedor (nombre, nombreEmpresa, direccion, celular, correoElectronico) 
VALUES ('María Gómez', 'Tech Solutions', '456 Avenida Principal, Ciudad', 9123456789, 'maria.gomez@techsolutions.com');

INSERT INTO Proveedor (nombre, nombreEmpresa, direccion, celular, correoElectronico) 
VALUES ('Carlos Ruiz', 'Servicios XYZ', '789 Plaza Central, Ciudad', 9345678901, 'carlos.ruiz@serviciosxyz.com');

-- INVENTARIO
INSERT INTO Inventario (idProducto, idProveedor, idEmpleado, cantidadStock)
VALUES (1, 1, 1, 50);
