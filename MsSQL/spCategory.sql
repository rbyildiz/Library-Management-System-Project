USE LibraryDB
GO
-- Category Stored Procedures
-- INSERT - Category
CREATE PROCEDURE [Product].[uspInsertCategory]	@Name VARCHAR(30), Active BIT
AS
BEGIN
	INSERT INTO Categories
	VALUES(@Name, @Active)
END
GO
-- UPDATE - Category
CREATE PROC [Product].[uspUpdateCategory]  @Id INT, @Name VARCHAR(30), @Active BIT
AS
BEGIN
	UPDATE Categories 
	SET CategoryName = @Name, Active = @Active
	WHERE Id = @Id
END
GO
-- DELETE - Category
CREATE PROC [Product].[uspDeleteCategory] @Id INT
AS
BEGIN
	UPDATE Categories
	SET Active = 0
	WHERE Id = @Id
END
GO
-----------------------
-- Category GET
CREATE PROC [Product].[uspGetCategory] @Id INT, @Name VARCHAR(30) OUT, @Active BIT OUTPUT
AS
BEGIN
	SELECT @Name = CategoryName, @Active = Active
	FROM Categories
	WHERE Id = @Id
END
GO
-- Category Find (Function)
CREATE FUNCTION [Product].[FindCategory] (@Name VARCHAR(30))
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN(SELECT * FROM [Product].[Categories]
			WHERE CategoryName LIKE '%' + @Name + '%'
			FOR JSON AUTO)
END
GO
