USE LibraryDB
GO
-- INSERT | BookMember
CREATE PROC [Product].[uspInsertBookMember] 
@MemberID INT, @BookID INT, @BookMemberRentalDate SMALLDATETIME, @BookMemberLeaseEndDate SMALLDATETIME, @Active BIT
AS
BEGIN
	INSERT INTO BookMembers 
	VALUES(@MemberID, @BookID, @BookMemberRentalDate, @BookMemberLeaseEndDate, @Active)
END
GO
-- DELETE | BookMember
CREATE PROC [Product].[uspDeleteBookMember]
@Id INT
AS
BEGIN
	UPDATE BookMembers
	SET Active = 0
	WHERE Id = @Id
END
GO
-- UPDATE | BookMember
CREATE PROC [Product].[uspUpdateBookMember]
@Id INT, @MemberID INT, @BookID INT, @BookMemberRentalDate SMALLDATETIME, @BookMemberLeaseEndDate SMALLDATETIME, @Active BIT
AS
BEGIN
	UPDATE BookMembers
	SET MemberID = @MemberID, BookID = @BookID, 
		BookMemberRentalDate = @BookMemberRentalDate,
		BookMemberLeaseEndDate = @BookMemberLeaseEndDate,
		Active = @Active
	WHERE Id = @Id
END
GO
----------------
-- FIND | BookMember
CREATE FUNCTION [Product].[FindBookMember](@Name VARCHAR(30))
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN(	SELECT  BookMembers.Id, BookMembers.BookID, BookMembers.MemberID, Book.BookName, Member.MemberFirstName,
					BookMembers.BookMemberRentalDate, 
					BookMembers.BookMemberLeaseEndDate, BookMembers.Active
			FROM BookMembers
			INNER JOIN [Product].[Books] AS Book
			ON Book.Id = BookMembers.BookID
			INNER JOIN [Person].[Members] AS Member
			ON Member.Id = BookMembers.MemberID
			WHERE Book.BookName LIKE '%' + @Name + '%' OR 
				  Member.MemberFirstName LIKE '%' + @Name + '%'
			FOR JSON PATH)
END
GO
--------------
-- GetAll | BookMember
CREATE FUNCTION [Product].[GetAllBookMember](@Active BIT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN( SELECT  BookMembers.Id, BookMembers.BookID, BookMembers.MemberID, BookMembers.BookMemberRentalDate, BookMembers.BookMemberLeaseEndDate, BookMembers.Active,
					JSON_QUERY((SELECT * FROM [Product].[Books] WHERE [Product].[Books].Id = Book.Id FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Books,
					JSON_QUERY((SELECT * FROM [Person].[Members] WHERE [Person].[Members].Id = Member.Id FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Members
			FROM [Product].[BookMembers]
			INNER JOIN [Product].[Books] AS Book
			ON Book.Id = BookMembers.BookID
			INNER JOIN [Person].[Members] AS Member
			ON Member.Id = BookMembers.MemberID
			WHERE [Product].[BookMembers].Active = @Active
			FOR JSON PATH)
END
GO
----------------
-- Get | BookMember
CREATE FUNCTION [Product].[GetBookMember](@Id INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN( SELECT  BookMembers.Id, BookMembers.BookID, BookMembers.MemberID, BookMembers.BookMemberRentalDate, BookMembers.BookMemberLeaseEndDate, BookMembers.Active,
					JSON_QUERY((SELECT * FROM [Product].[Books] WHERE [Product].[Books].Id = Book.Id FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Books,
					JSON_QUERY((SELECT * FROM [Person].[Members] WHERE [Person].[Members].Id = Member.Id FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS Members
			FROM [Product].[BookMembers]
			INNER JOIN [Product].[Books] AS Book
			ON Book.Id = BookMembers.BookID
			INNER JOIN [Person].[Members] AS Member
			ON Member.Id = BookMembers.MemberID
			WHERE [Product].[BookMembers].Id = @Id
			FOR JSON PATH)
END
GO