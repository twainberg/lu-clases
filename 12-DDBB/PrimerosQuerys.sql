USE Empresa

SELECT 'HOLA'

SELECT 'CHAU'

CREATE TABLE Clientes (Id Int, Nombre NVarchar(40), Cuit NVarchar(15))
 
SELECT * 
  FROM Clientes

sp_help Clientes

INSERT INTO Clientes
VALUES ( 1, 'Lagash', '30-30303030-1')

CREATE TABLE Telefono (Id Int, Telefono NVarchar(10), ClienteId Int)

SELECT * 
  FROM Telefono

INSERT INTO Telefono
VALUES ( 1, '5555-5555', 1)

INSERT INTO Clientes
VALUES ( 2, 'Amazon', '40-40404040-1')

INSERT INTO Telefono
VALUES ( 2, '8888-8888', 2)

SELECT ClienteId, 
       Telefono 
  FROM Telefono
 WHERE ClienteId = 1
    OR ClienteId = 2
 ORDER BY Telefono DESC

SELECT Count(ClienteId) AS 'Total'
  FROM Telefono
 WHERE ClienteId = 1
    OR ClienteId = 2

CREATE TABLE Producto (Id int, Nombre NVarchar(50))

CREATE TABLE Factura (Id int, Numero NVarchar(10), ClienteId int)

CREATE TABLE Item (Id int, ProductoId int, FacturaId int, Cantidad int, Precio decimal(3,2))

DROP TABLE Item

CREATE TABLE Item (Id int, ProductoId int, FacturaId int, Cantidad int, Precio decimal(5,2))

INSERT INTO Producto 
VALUES (1, 'Computadora')

INSERT INTO Producto 
VALUES (2, 'Mouse')

INSERT INTO Producto 
VALUES (3, 'Teclado')

SELECT * 
  FROM Producto

INSERT INTO Factura
VALUES (1, '0001-03030', 1)

INSERT INTO Item
VALUES (1, 1, 1, 10, 12.35),
       (2, 2, 1, 20, 2.80)

SELECT *, 
       (Cantidad * Precio) AS 'Precio Total'
  FROM Item

SELECT SUM((Cantidad * Precio)) AS 'Precio Total'
  FROM Item

INSERT INTO Factura
VALUES (2, '0001-04040', 2)

INSERT INTO Item
VALUES (3, 1, 2, 20, 11.35),
       (4, 3, 2, 20, 1.58)

SELECT SUM((Cantidad * Precio))
  FROM Clientes,
       Factura, 
	   Item
 WHERE Clientes.Id = Factura.ClienteId
   AND Factura.Id = Item.FacturaId
   AND Clientes.Nombre LIKE 'Ama%'

SELECT Clientes.Id,
       Clientes.Nombre,
       SUM((Cantidad * Precio))
  FROM Clientes,
       Factura, 
	   Item
 WHERE Clientes.Id = Factura.ClienteId
   AND Factura.Id = Item.FacturaId
 GROUP BY Clientes.Id,
          Clientes.Nombre

-------------------------------------------------------------------------------------------------------------------

ALTER TABLE Clientes ALTER COLUMN id int not null
ALTER TABLE Clientes ADD PRIMARY KEY (id)

ALTER TABLE Factura ALTER COLUMN id int not null
ALTER TABLE Factura ADD PRIMARY KEY (id)
ALTER TABLE Factura ADD ClienteId INTEGER, FOREIGN KEY (ClienteId) REFERENCES Clientes(id)

ALTER TABLE Item ALTER COLUMN id int not null
ALTER TABLE Item ADD PRIMARY KEY (id)

ALTER TABLE Producto ALTER COLUMN id int not null
ALTER TABLE Producto ADD PRIMARY KEY (id)

INSERT INTO Clientes 
VALUES (3, NULL, 50-50505050-1)

SELECT *
  FROM Clientes