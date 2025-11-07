CREATE TABLE Usuarios(
id_usuario INT PRIMARY KEY,
usuario NVARCHAR(15),
psw INT
)

CREATE TABLE Clientes(
id_cliente INT PRIMARY KEY,
razon_social NVARCHAR(60)
)

CREATE TABLE Productos(
codigo INT PRIMARY KEY,
descripcion NVARCHAR(60),
stock INT,
precio DECIMAL(18,2)
)

CREATE TABLE Ventas(
id_venta INT PRIMARY KEY,
fecha DATETIME,
id_cliente INT FOREIGN KEY REFERENCES Clientes(id_cliente),
importe DECIMAL(18,2),
id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
)

CREATE TABLE Detalle_Venta(
id_venta INT FOREIGN KEY REFERENCES Ventas(id_venta),
codigo INT FOREIGN KEY REFERENCES Productos(codigo),
precio DECIMAL(18,2),
cantidad INT,
precio_r decimal(18,2),
PRIMARY KEY(id_venta, codigo)
)

CREATE TABLE Detalle_Venta(
id_detalle_venta INT PRIMARY KEY,
id_venta INT FOREIGN KEY REFERENCES Ventas(id_venta),
codigo INT FOREIGN KEY REFERENCES Productos(codigo),
precio DECIMAL(18,2),
cantidad INT,
precio_r DECIMAL(18,2)
)

--STORE PROCEDURES

--USUARIOS
CREATE PROCEDURE spu_login
@usuario NVARCHAR(60),
@psw INT
AS
SELECT * FROM Usuarios WHERE usuario = @usuario AND psw = @psw

--CLIENTES
CREATE PROCEDURE spu_mostrar_clientes
@id_cliente INT = NULL,
@razon_social NVARCHAR(60) = NULL
AS
IF @id_cliente IS NULL AND @razon_social IS NULL
BEGIN
    SELECT id_cliente AS ID, razon_social AS 'Razón Social'
    FROM Clientes
END
ELSE
BEGIN
    SELECT * FROM Clientes
    WHERE
    (@id_cliente IS NULL OR id_cliente = @id_cliente)
    AND
    (@razon_social IS NULL OR razon_social = @razon_social)
END

EXEC spu_mostrar_clientes

CREATE PROCEDURE spu_cargar_cliente
@id_cliente INT,
@razon_social NVARCHAR(60)
AS
INSERT INTO Clientes
VALUES(@id_cliente, @razon_social)

CREATE PROCEDURE spu_eliminar_cliente
@id_cliente INT
AS
DELETE FROM Clientes WHERE id_cliente = @id_cliente

CREATE PROCEDURE spu_actualizar_cliente
@id_cliente INT,
@razon_social NVARCHAR(60)
AS
UPDATE Clientes SET razon_social = @razon_social WHERE id_cliente = @id_cliente

CREATE PROCEDURE spu_id_nuevo_cliente
AS
SELECT MAX(id_cliente) + 1 AS id from Clientes

--PRODUCTOS

CREATE PROCEDURE spu_mostrar_productos
    @codigo INT = NULL,
    @descripcion NVARCHAR(60) = NULL,
    @stock INT = NULL,
    @precio DECIMAL(18,2) = NULL
AS
BEGIN

    -- Validar: si todos los parámetros son NULL, lanzar error
    IF @codigo IS NULL 
       AND @descripcion IS NULL 
       AND @stock IS NULL 
       AND @precio IS NULL
    BEGIN
        SELECT codigo AS 'Código',
        descripcion AS 'Descripción',
        stock AS 'Stock',
        precio AS 'Precio'
        FROM Productos
    END
    ELSE
    BEGIN
        SELECT codigo AS 'Código',
        descripcion AS 'Descripción',
        stock AS 'Stock',
        precio AS 'Precio'
        FROM Productos
        WHERE
            (@codigo IS NULL OR Codigo = @codigo)
            AND (@descripcion IS NULL OR Descripcion LIKE '%' + @descripcion + '%')
            AND (@stock IS NULL OR Stock = @stock)
            AND (@precio IS NULL OR Precio = @precio);
    END
END

EXEC spu_mostrar_productos

CREATE PROCEDURE spu_cargar_productos
@codigo INT,
@descripcion NVARCHAR(60),
@stock INT,
@precio DECIMAL(18,2)
AS
INSERT INTO Productos
VALUES(@codigo, @descripcion, @stock, @precio)

CREATE PROCEDURE spu_eliminar_productos
@codigo INT
AS
DELETE FROM Productos WHERE codigo = @codigo

CREATE PROCEDURE spu_id_nuevo_producto
AS
SELECT MAX(codigo) + 1 AS id from Productos


--VENTAS

CREATE PROCEDURE spu_cargar_venta
@id_venta INT,
@fecha DATETIME,
@id_cliente INT,
@id_usuario INT
AS
INSERT INTO Ventas
VALUES(@id_venta, @fecha, @id_cliente, 0, @id_usuario)

--ALTA/BAJA DETALLE DE VENTA

CREATE PROCEDURE spu_cargar_detalle_venta
@id_detalle_venta INT,
@id_venta INT,
@codigo INT,
@precio DECIMAL,
@cantidad INT,
@precio_r DECIMAL
AS
INSERT INTO Detalle_Venta
VALUES(@id_detalle_venta, @id_venta, @codigo, @precio, @cantidad, @precio_r);

CREATE PROCEDURE spu_id_nueva_venta
AS
SELECT MAX(id_venta) + 1 AS id from Ventas

CREATE PROCEDURE spu_eliminar_detalle_venta
@id_detalle_venta INT
AS
DELETE FROM Detalle_Venta WHERE id_detalle_venta = @id_detalle_venta

CREATE PROCEDURE spu_actualizar_ventas
@id_venta INT,
@id_cliente INT,
@importe DECIMAL(19,2)
AS
UPDATE Ventas SET id_cliente = @id_cliente, importe = @importe WHERE id_venta = @id_venta

--DETALLE DE VENTA
CREATE PROCEDURE spu_nuevo_detalle_vta
@id_venta INT,
@codigo INT,
@precio DECIMAL(18,2),
@cantidad INT,
@precio_r DECIMAL(18,2)
AS
INSERT INTO Detalle_Venta
VALUES(@id_venta, @codigo, @precio, @cantidad, (@precio * @cantidad))

--BACKUP
CREATE PROCEDURE spu_backup
AS
DECLARE @MyFileName VARCHAR(1000)
SELECT @MyFileName = (SELECT 'C:\BACKUP DB\PARCIAL FINAL\'+ CONVERT (VARCHAR(500),GETDATE(),112)+'.bak') 
BACKUP DATABASE [Comercio]
TO DISK = @MyFileName



--TRIGGERS

CREATE TRIGGER baja_stock ON Detalle_Venta
FOR INSERT
AS
UPDATE Productos SET stock = (stock - inserted.cantidad)
WHERE codigo = (SELECT codigo FROM inserted)

CREATE TRIGGER sube_stock ON Detalle_Venta
FOR DELETE
AS
UPDATE Productos SET stock = stock + (SELECT cantidad from deleted)
WHERE codigo = (SELECT codigo FROM deleted)

CREATE TRIGGER insertar_precio ON Detalle_Venta
FOR INSERT, UPDATE
AS
INSERT INTO Detalle_Venta 


--VISTAS
--PRODUCTOS
CREATE VIEW vw_mostrar_Productos
AS
SELECT * FROM Productos

--CLIENTES
CREATE VIEW vw_mostrar_Clientes
AS
SELECT * FROM Clientes

--VENTAS
CREATE VIEW vw_mostrar_ventas
AS
SELECT 
  V.id_venta,
  V.fecha,
  V.id_cliente,
  C.razon_social    AS razon_social_cliente,
  V.importe,
  V.id_usuario,
  U.usuario         AS nombre_usuario
FROM Ventas V
INNER JOIN Clientes C ON V.id_cliente = C.id_cliente
INNER JOIN Usuarios  U ON V.id_usuario = U.id_usuario;

--DETALLE  VENTA
CREATE VIEW vw_mostrar_detalle_venta
AS
SELECT 
M.id_detalle_venta,
M.id_venta,
--V.id_cliente AS id_cliente,
C.razon_social    AS razon_social_cliente,
--V.id_usuario,
U.usuario         AS nombre_usuario,
M.codigo,
P.descripcion AS nombre_producto,
M.precio,
M.cantidad,
M.precio_r
FROM Detalle_Venta M
INNER JOIN Ventas V ON V.id_venta = M.id_venta
INNER JOIN Clientes C ON V.id_cliente = C.id_cliente
INNER JOIN Productos P ON M.codigo = P.codigo
INNER JOIN Usuarios U ON V.id_usuario = U.id_usuario


--PRUEBAS
INSERT INTO Usuarios
VALUES(1, 'admin',123)
SELECT * FROM Usuarios

INSERT INTO Clientes
VALUES(1, 'CONSUMIDOR FINAL')

INSERT INTO Productos
VALUES(1,'Dulce de Leche', 10, 5000)

INSERT INTO Productos
VALUES(2,'Manteca', 10, 4000)

SELECT * FROM Productos

SELECT * FROM Ventas

INSERT INTO Ventas
VALUES(1, 15/10/2025, 1, 0 ,1)

SELECT * FROM Detalle_Venta

INSERT INTO Detalle_Venta
VALUES(1, 1, 1, 5000, 2, 10000)

INSERT INTO Detalle_Venta
VALUES(2, 1, 1, 5000, 1, 5000)

INSERT INTO Detalle_Venta
VALUES(3, 1, 1, 5000, 1, 5000)


SELECT * FROM Usuarios
SELECT * FROM Ventas
SELECT * FROM Productos
SELECT * FROM Clientes
