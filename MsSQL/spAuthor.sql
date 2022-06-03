USE LibraryDB
GO
-- Author SP
-- INSERT - AUTHOR
CREATE PROC [Person].[uspInsertAuthor] 	@FirstName VARCHAR(30),
					@LastName VARCHAR(30),
					@Active BIT
AS
BEGIN
	INSERT INTO Authors 
	VALUES(@FirstName, @LastName, @Active)
END
GO
-- UPDATE - AUTHOR
CREATE PROC [Person].[uspUpdateAuthor] 	@Id INT,
					@FirstName VARCHAR(30),
					@LastName VARCHAR(30),
					@Active BIT
AS
BEGIN
	UPDATE Authors SET AuthorFirstName = @FirstName, 
			   AuthorLastName = @LastName,
			   Active = @Active
	WHERE Id = @Id
END
GO
-- DELETE - AUTHOR
CREATE PROC [Person].[uspDeleteAuthor] @Id INT
AS
BEGIN
	UPDATE Authors SET Active = 0
	WHERE Id = @Id
END
GO
---
CREATE FUNCTION [Person].[GetAllAuthor] (@Active BIT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN( SELECT * FROM [Person].[Authors]
			WHERE Active = @Active
			FOR JSON AUTO)
END
GO
