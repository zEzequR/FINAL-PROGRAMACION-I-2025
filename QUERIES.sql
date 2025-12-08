CREATE TABLE Usuarios(
id_usuario INT PRIMARY KEY,
usuario NVARCHAR(15),
psw INT
)

CREATE TABLE Clientes(
id_cliente INT PRIMARY KEY,
razon_social NVARCHAR(60)
)

CREATE TABLE Proveedores(
id_proveedor INT,
nombre_Proveedor NVARCHAR(60),
telefono NVARCHAR(15),
email VARCHAR(254),
PRIMARY KEY (id_proveedor)
);

CREATE TABLE Productos(
codigo INT PRIMARY KEY,
descripcion NVARCHAR(60),
stock INT,
precio DECIMAL(18,2)
)

ALTER TABLE Productos
ADD
    proveedor INT FOREIGN KEY REFERENCES Proveedores(id_proveedor)

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

CREATE PROCEDURE spu_mostrar_usuarios
AS
SELECT * FROM Usuarios

EXEC spu_mostrar_usuarios

CREATE PROCEDURE spu_get_id_usuario
    @getID INT OUTPUT,
    @username NVARCHAR(60)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ID INT;
    SET @ID = NULL;

    SELECT @ID = id_usuario
    FROM Usuarios
    WHERE usuario LIKE @username;

    -- si no encontró nada, devolver -1; si encontró, devolver el id
    SET @getID = ISNULL(@ID, -1);
END;

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
    SELECT id_cliente AS ID, razon_social AS 'Razón Social'
    FROM Clientes
    WHERE
    (@id_cliente IS NULL OR id_cliente = @id_cliente)
    AND
    (@razon_social IS NULL OR razon_social = @razon_social)
END

EXEC spu_mostrar_clientes

EXEC spu_mostrar_clientes NULL, 'eze'

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
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(id_cliente), 0) + 1
    FROM Clientes;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;

--PROVEEDORES
CREATE PROCEDURE spu_mostrar_proveedores
    @id_proveedor INT = NULL,
    @nombre_Proveedor NVARCHAR(60) = NULL,
    @telefono NVARCHAR(15) = NULL,
    @email NVARCHAR(256) = NULL
AS
BEGIN

    -- Validar: si todos los parámetros son NULL, lanzar error
    IF @id_proveedor IS NULL 
       AND @nombre_Proveedor IS NULL 
       AND @telefono IS NULL 
       AND @email IS NULL
    BEGIN
        SELECT id_proveedor AS 'ID',
        nombre_Proveedor AS 'Proveedor',
        telefono AS 'Teléfono',
        email AS 'Email'
        FROM Proveedores
    END
    ELSE
    BEGIN
        SELECT id_proveedor AS 'ID',
        nombre_Proveedor AS 'Proveedor',
        telefono AS 'Teléfono',
        email AS 'Email'
        FROM Proveedores
        WHERE
            (@id_proveedor IS NULL OR id_proveedor = @id_proveedor)
            AND (@nombre_Proveedor IS NULL OR nombre_Proveedor LIKE '%' + @nombre_Proveedor + '%')
            AND (@telefono IS NULL OR telefono = @telefono)
            AND (@email IS NULL OR email = @email);
    END
END

EXEC spu_mostrar_proveedores

INSERT INTO Proveedores
VALUES(1, 'EZE', '3413922015', 'ezequiel.ramos@institutozonaoeste.edu.ar')
SELECT * FROM Proveedores

CREATE PROCEDURE spu_cargar_proveedores
@id_proveedor INT,
@nombre_Proveedor NVARCHAR(60),
@telefono NVARCHAR(15),
@email NVARCHAR(256) 
AS
INSERT INTO Proveedores
VALUES(@id_proveedor, @nombre_Proveedor, @telefono, @email)

CREATE PROCEDURE spu_eliminar_proveedores
@id_proveedor INT
AS
DELETE FROM Proveedores WHERE id_proveedor = @id_proveedor

CREATE PROCEDURE spu_modificar_proveedores
@id_proveedor INT,
@nombre_Proveedor NVARCHAR(60),
@telefono NVARCHAR(15),
@email NVARCHAR(256) 
AS
UPDATE Proveedores SET id_proveedor = @id_proveedor, nombre_Proveedor = @nombre_Proveedor, telefono = @telefono WHERE id_proveedor = @id_proveedor

CREATE PROCEDURE spu_id_nuevo_proveedor
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(id_proveedor), 0) + 1
    FROM Proveedores;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;


--PRODUCTOS

CREATE PROCEDURE spu_mostrar_productos
    @codigo INT = NULL,
    @descripcion NVARCHAR(60) = NULL,
    @id_prov INT = NULL,
    @stock INT = NULL,
    @precio DECIMAL(18,2) = NULL
AS
BEGIN

    -- Validar: si todos los parámetros son NULL, lanzar error
    IF @codigo IS NULL 
       AND @descripcion IS NULL 
       AND @stock IS NULL 
       AND @id_prov IS NULL
       AND @precio IS NULL
    BEGIN
        SELECT codigo AS 'Código',
        descripcion AS 'Descripción',
        Proveedores.nombre_Proveedor AS 'Proveedor',
        stock AS 'Stock',
        precio AS 'Precio'
        FROM Productos
        INNER JOIN Proveedores ON Proveedores.id_proveedor = Productos.proveedor
    END
    ELSE
    BEGIN
        SELECT codigo AS 'Código',
        descripcion AS 'Descripción',
        stock AS 'Stock',
        Proveedores.nombre_Proveedor AS 'Proveedor',
        precio AS 'Precio'
        FROM Productos
        INNER JOIN Proveedores ON Proveedores.id_proveedor = Productos.proveedor
        WHERE
            (@codigo IS NULL OR Codigo = @codigo)
            AND (@descripcion IS NULL OR Descripcion LIKE '%' + @descripcion + '%')
            AND (@id_prov IS NULL OR proveedor = @id_prov)
            AND (@stock IS NULL OR Stock = @stock)
            AND (@precio IS NULL OR Precio = @precio);
    END
END

EXEC spu_mostrar_productos

SELECT * FROM Productos

CREATE PROCEDURE spu_mostrar_prodStock
AS
SELECT codigo AS 'Código',
descripcion AS 'Descripción',
Proveedores.nombre_Proveedor AS 'Proveedor',
stock AS 'Stock',
precio AS 'Precio'
FROM PRODUCTOS 
INNER JOIN Proveedores ON Proveedores.id_proveedor = Productos.proveedor
WHERE Stock >= 1

EXEC spu_mostrar_productos

ALTER PROCEDURE spu_buscar_producto
@desc NVARCHAR(60)
AS
BEGIN
    SET NOCOUNT ON;

    SET @desc = ISNULL(LTRIM(RTRIM(@desc)), '');

    DECLARE @pattern NVARCHAR(62);

    IF LEN(@desc) = 0
        SET @pattern = '%';
    ELSE IF LEN(@desc) = 1
        SET @pattern = @desc + '%';   -- empiezan con
    ELSE
        SET @pattern = '%' + @desc + '%'; -- contienen

    SELECT *
    FROM Productos
    WHERE descripcion LIKE @pattern;
END;

CREATE PROCEDURE spu_cargar_productos
@codigo INT,
@descripcion NVARCHAR(60),
@id_prov INT,
@stock INT,
@precio DECIMAL(18,2)
AS
INSERT INTO Productos
VALUES(@codigo, @descripcion, @id_prov, @stock, @precio)

CREATE PROCEDURE spu_eliminar_productos
@codigo INT
AS
DELETE FROM Productos WHERE codigo = @codigo

CREATE PROCEDURE spu_modificar_productos
@codigo INT,
@descripcion NVARCHAR(60),
@id_prov INT,
@stock INT,
@precio DECIMAL(18,2)
AS
UPDATE Productos SET descripcion = @descripcion, proveedor = @id_prov, stock = @stock, precio = @precio WHERE codigo = @codigo

CREATE PROCEDURE spu_id_nuevo_producto
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(codigo), 0) + 1
    FROM Productos;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;


--VENTAS

CREATE PROCEDURE spu_mostrar_ventas
AS
SELECT * FROM Ventas

EXEC spu_mostrar_ventas

CREATE PROCEDURE spu_cargar_venta
@id_venta INT,
@fecha DATETIME,
@id_cliente NVARCHAR(60),
@id_usuario INT
AS
INSERT INTO Ventas
VALUES(@id_venta, @fecha, @id_cliente, 0, @id_usuario)

--ALTA/BAJA DETALLE DE VENTA

CREATE PROCEDURE spu_id_nueva_venta
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(id_venta), 0) + 1
    FROM Ventas;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;

CREATE PROCEDURE spu_eliminar_venta
@idVta INT
AS
DELETE FROM Ventas WHERE id_venta = @idVta

CREATE PROCEDURE spu_actualizar_ventas
@id_venta INT,
@id_cliente INT,
@importe DECIMAL(19,2)
AS
UPDATE Ventas SET id_cliente = @id_cliente, importe = @importe WHERE id_venta = @id_venta

--DETALLE DE VENTA

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

CREATE PROCEDURE spu_eliminar_prod_detVta
@codProd INT
AS
DELETE FROM Detalle_Venta WHERE codigo = @codProd

CREATE PROCEDURE spu_mostrar_detalle_venta
@id_vta INT
AS
SELECT 
--M.id_detalle_venta,
--M.id_venta,
--V.id_cliente AS id_cliente,
C.razon_social    AS Cliente,
--V.id_usuario,
U.usuario         AS Usuario,
M.codigo AS 'Código del producto',
P.descripcion AS 'Producto',
M.precio AS Precios,
M.cantidad AS Cantidad,
M.precio_r AS Subtotal
FROM Detalle_Venta M
INNER JOIN Ventas V ON V.id_venta = M.id_venta
INNER JOIN Clientes C ON V.id_cliente = C.id_cliente
INNER JOIN Productos P ON M.codigo = P.codigo
INNER JOIN Usuarios U ON V.id_usuario = U.id_usuario
WHERE M.id_venta = @id_vta



EXEC spu_mostrar_detalle_venta 1

CREATE PROCEDURE spu_mostrar_detalle_venta_V2
    @id_vta INT = NULL,
    @fecha DATETIME = NULL,
    @id_cliente INT = NULL,
    @importe DECIMAL(18,2) = NULL,
    @id_usuario INT = NULL
AS
BEGIN
    IF @id_vta IS NULL 
       AND @fecha IS NULL 
       AND @id_cliente IS NULL 
       AND @importe IS NULL 
       AND @id_usuario IS NULL
    BEGIN
        SELECT
            C.razon_social AS Cliente,
            U.usuario AS Usuario,
            M.codigo AS 'Código del producto',
            P.descripcion AS 'Producto',
            M.precio AS 'Precio',
            M.cantidad AS Cantidad,
            M.precio_r AS Subtotal
        FROM Detalle_Venta M
        INNER JOIN Ventas V ON V.id_venta = M.id_venta
        INNER JOIN Clientes C ON V.id_cliente = C.id_cliente
        INNER JOIN Productos P ON M.codigo = P.codigo
        INNER JOIN Usuarios U ON V.id_usuario = U.id_usuario
    END
    ELSE
    BEGIN
        SELECT
            C.razon_social AS Cliente,
            U.usuario AS Usuario,
            M.codigo AS 'Código del producto',
            P.descripcion AS 'Producto',
            M.precio AS 'Precio',
            M.cantidad AS Cantidad,
            M.precio_r AS Subtotal
        FROM Detalle_Venta M
        INNER JOIN Ventas V ON V.id_venta = M.id_venta
        INNER JOIN Clientes C ON V.id_cliente = C.id_cliente
        INNER JOIN Productos P ON M.codigo = P.codigo
        INNER JOIN Usuarios U ON V.id_usuario = U.id_usuario
        WHERE

            (@id_vta IS NULL OR V.id_venta = @id_vta)
            
            AND (@fecha IS NULL OR V.fecha = @fecha)

            AND (@id_cliente IS NULL OR V.id_cliente = @id_cliente)
            
            AND (@importe IS NULL OR V.importe = @importe) 

            AND (@id_usuario IS NULL OR V.id_usuario = @id_usuario);
    END
END

EXEC spu_mostrar_detalle_venta_V2 1

CREATE PROCEDURE spu_id_nuevo_detalleVta
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(id_detalle_venta), 0) + 1
    FROM Detalle_Venta;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;

CREATE PROCEDURE spu_cancelar_detalle_vta
@id_Vta INT
AS
DELETE FROM Detalle_Venta WHERE id_venta = @id_Vta

--BACKUP
CREATE PROCEDURE spu_backup
AS
DECLARE @MyFileName VARCHAR(1000)
SELECT @MyFileName = (SELECT 'C:\Users\ezequ\Documents\GitHub\FINAL-PROGRAMACION-I-2025\RAMOS EZEQUIEL\DB\BACKUP\'+ CONVERT (VARCHAR(500),GETDATE(),112)+'.bak') 
BACKUP DATABASE [Comercio]
TO DISK = @MyFileName

EXEC spu_backup

--TRIGGERS

ALTER TRIGGER baja_stock ON Detalle_Venta
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.stock = p.stock - i.total_qty
    FROM dbo.Productos p
    JOIN (
        SELECT codigo, SUM(cantidad) AS total_qty
        FROM inserted
        GROUP BY codigo
    ) AS i
      ON p.codigo = i.codigo;
END;


CREATE TRIGGER sube_stock ON Detalle_Venta
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.stock = p.stock + i.total_qty
    FROM dbo.Productos p
    JOIN (
        SELECT codigo, SUM(cantidad) AS total_qty
        FROM deleted
        GROUP BY codigo
    ) AS i
      ON p.codigo = i.codigo;
END;


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
--M.id_detalle_venta,
--M.id_venta,
--V.id_cliente AS id_cliente,
C.razon_social    AS Cliente,
--V.id_usuario,
U.usuario         AS Usuario,
M.codigo AS 'Código del producto',
P.descripcion AS 'Producto',
M.precio AS Precios,
M.cantidad AS Cantidad,
M.precio_r AS Subtotal
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
SELECT * FROM Productos
SELECT * FROM Clientes
SELECT * FROM Detalle_Venta
SELECT * FROM Ventas

EXEC spu_mostrar_detalle_venta 10

SELECT * FROM Ventas

DELETE FROM Ventas WHERE id_cliente = 1
DELETE FROM Detalle_Venta WHERE precio = 2000

EXEC spu_cargar_venta 1, '11-11-25', 1, 1
EXEC spu_nuevo_detalle_vta 1,1,2,4000,2,8000

EXEC spu_mostrar_detalle_venta 9

UPDATE Productos SET stock = 20 WHERE precio = 4000

SELECT * FROM Ventas

DELETE Ventas WHERE id_venta = 17

SELECT * FROM Detalle_Venta

DELETE Detalle_Venta WHERE id_venta = 17