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
DROP TABLE Producto;
DROP TABLE Proveedor;
DROP TABLE CompraDetalle;
DROP TABLE Compra;
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
CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(20) NOT NULL,
  nombre VARCHAR(150) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  categoria VARCHAR(150) NOT NULL,
  precioVenta DECIMAL NOT NULL CHECK(precioVenta > 0),
  --CONSTRAINT fk_Producto_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
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
  fechaContratacion DATE NOT NULL DEFAULT GETDATE()
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
CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
GO
CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK(cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY(idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
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
GO
ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO
ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO
ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO
ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO
-- ver
--ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
--ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
--ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
go
ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO
--ALTER PROC paProductoListar 
--    @parametro VARCHAR(50)
--AS
--BEGIN
--  SELECT * FROM Producto
--  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro,' ','%')+'%'; 
--  END
----EXEC paProductoListar 'Tang';

CREATE PROCEDURE paProductoListar
    @parametro VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Producto
    WHERE estado <> -1 AND descripcion LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;

GO
--DROP PROCEDURE IF EXISTS paProductoListar;

-- dml
INSERT INTO Producto (codigo, nombre, descripcion, categoria, precioVenta) 
VALUES 
('P001', 'Tang', 'Jugo en polvo', 'Bebidas', 10.99);
GO
INSERT INTO Producto (codigo, nombre, descripcion, categoria, precioVenta) 
VALUES 
('P002', 'Ace', 'jabon liquido', 'Productos de limpieza', 20.50);
GO
INSERT INTO Producto (codigo, nombre, descripcion, categoria, precioVenta) 
VALUES 
('P003', 'Leche Pil', 'descremada', 'Lácteos', 20.50);
GO
select *from Producto
-- Insertar datos para el segundo empleado
INSERT INTO Empleado (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, cargo, celular, correoElectronico, salario, fechaContratacion) 
VALUES 
('1234567890', 'Juan', 'Pérez','Paraná', 'Calle Principal 123', 'Gerente', 1234567890, 'juan@example.com', '5000 USD', '2024-01-15');
GO
INSERT INTO Empleado (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, cargo, celular, correoElectronico, salario, fechaContratacion) 
VALUES 
('5678901234', 'Carlos', 'Rodríguez', 'Mar', 'Calle Secundaria 789', 'Cajero', 5678901234, 'carlos@example.com', '2500 USD', '2024-03-10');
GO
INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('nadia', 'i0hcoO/nssY6WOs9pOp5Xw==', 1);
GO
INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('jimenez', 'i0hcoO/nssY6WOs9pOp5Xw==', 2);
