GO
CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(20) NOT NULL,
  nombre VARCHAR(150) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  categoria VARCHAR(150) NOT NULL,
  precioVenta DECIMAL NOT NULL CHECK(precioVenta > 0),
  --  CONSTRAINT fk_Producto_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
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
  -- idProveedor INT NOT NULL,
  idEmpleado INT NOT NULL,
  cantidadStock INT NOT NULL,
  fechaUltimaRepocision DATE NOT NULL DEFAULT GETDATE(),
  --  CONSTRAINT fk_Inventario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
  --  CONSTRAINT fk_Inventario_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);
GO
CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProducto INT NOT NULL,
  idCliente INT NOT NULL,
  idEmpleado INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  -- CONSTRAINT fk_Venta_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
  -- CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id)
  -- CONSTRAINT fk_Venta_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
  
);
