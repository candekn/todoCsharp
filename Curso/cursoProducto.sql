USE dbCurso
GO

SELECT Id,Nombre,CategoriaID,Proveedor
  FROM Producto
GO


INSERT INTO Producto(Nombre,CategoriaID,Proveedor)
     VALUES ('Teclado',1,'Noga'),
		    ('Mouse',1,'NogaNet'),
		    ('Windows 10',2,'Microsoft')
GO

UPDATE Producto
   SET Nombre = 'Mouse Escritorio',CategoriaID = 1,Proveedor = 'Genius'
   WHERE Id=2
GO

DELETE FROM Producto
      WHERE Id = 2
GO

