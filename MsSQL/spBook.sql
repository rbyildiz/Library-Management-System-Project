-- LibraryDB Stored Procedures
USE LibraryDB
GO
-- Book SP
-- INSERT - BOOK
CREATE PROC [Product].[uspInsertBook]	@BookName VARCHAR(30),
										@AuthorID INT,
										@BookPublicationYear INT,
										@BookSummary VARCHAR(500),
										@BookImagePath VARCHAR(100),
										@BookLanguage VARCHAR(30),
										@CategoryID INT,
										@Active BIT
AS
BEGIN
	INSERT INTO Books
	VALUES(@BookName, @AuthorID, @BookPublicationYear, @BookSummary, @BookImagePath, @BookLanguage, @CategoryID, @Active)
END
GO
-- DELETE - BOOK
CREATE PROC [Product].[uspDeleteBook] @Id INT
AS
BEGIN
	UPDATE Books SET Active = 0
	WHERE Id = @Id
END
GO
-- UPDATE - BOOK
CREATE PROC [Product].[uspUpdateBook]	@Id INT,
										@BookName VARCHAR(30),
										@AuthorID INT,
										@BookPublicationYear INT,
										@BookSummary VARCHAR(500),
										@BookImagePath VARCHAR(100),
										@BookLanguage VARCHAR(30),
										@CategoryID INT,
										@Active BIT
AS
BEGIN
	UPDATE Books SET BookName = @BookName,	AuthorID = @AuthorID,
					 BookPublicationYear = @BookPublicationYear,
					 BookSummary = @BookSummary,
					 BookImagePath = @BookImagePath,
					 BookLanguage = @BookLanguage,
					 CategoryID = @CategoryID,
					 Active = @Active
	WHERE Id = @Id
END
GO
----------------
CREATE FUNCTION [Product].[GetAllBook] (@Active BIT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN( SELECT Books.Id, Books.BookName, Books.BookPublicationYear,
					Books.BookSummary, Books.BookImagePath, Books.BookLanguage, CategoryID, AuthorID, Books.Active,
					JSON_QUERY((SELECT * FROM Categories WHERE Categories.Id = Books.CategoryID FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Category,
					JSON_QUERY((SELECT * FROM [Person].[Authors] WHERE Authors.Id = Books.AuthorID FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Author
			FROM [Product].[Books]
			INNER JOIN [Product].[Categories] AS Category
			ON Category.Id = [Product].[Books].CategoryID
			INNER JOIN [Person].[Authors] AS Author
			ON Author.Id = [Product].[Books].AuthorID
			WHERE [Product].[Books].Active = @Active
			FOR JSON PATH)
END
GO
-------------------
CREATE FUNCTION [Product].[GetBook](@Id INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN( SELECT Books.Id, Books.BookName, Books.BookPublicationYear,
					Books.BookSummary, Books.BookImagePath, Books.BookLanguage, CategoryID, AuthorID, Books.Active,
					JSON_QUERY((SELECT * FROM Categories WHERE Categories.Id = Books.CategoryID FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Category,
					JSON_QUERY((SELECT * FROM [Person].[Authors] WHERE Authors.Id = Books.AuthorID FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Author
			FROM [Product].[Books]
			INNER JOIN [Product].[Categories] AS Category
			ON Category.Id = [Product].[Books].CategoryID
			INNER JOIN [Person].[Authors] AS Author
			ON Author.Id = [Product].[Books].AuthorID
			WHERE [Product].[Books].Id = @Id
			FOR JSON PATH)
END
GO
--------------------
CREATE FUNCTION [Product].[FindBook](@Name VARCHAR(30))
RETURNS NVARCHAR(MAX)
AS
BEGIN
		RETURN( SELECT Books.Id, Books.BookName, Books.BookPublicationYear,
					Books.BookSummary, Books.BookImagePath, Books.BookLanguage,CategoryID, AuthorID, Books.Active,
					JSON_QUERY((SELECT * FROM Categories WHERE Categories.Id = Books.CategoryID FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Category,
					JSON_QUERY((SELECT * FROM [Person].[Authors] WHERE Authors.Id = Books.AuthorID FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Author
			FROM [Product].[Books]
			INNER JOIN [Product].[Categories] AS Category
			ON Category.Id = [Product].[Books].CategoryID
			INNER JOIN [Person].[Authors] AS Author
			ON Author.Id = [Product].[Books].AuthorID
			WHERE [Product].[Books].BookName LIKE '%' + @Name + '%'
			FOR JSON PATH)
END
GO