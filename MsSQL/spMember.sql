USE LibraryDB
GO
-- Member Stored Procedures
-- INSERT - Member
CREATE PROC [Person].[uspInsertMember]  @FirstName VARCHAR(30),
					@LastName VARCHAR(30),
					@PhoneNumber VARCHAR(13),
					@Email VARCHAR(40),
					@Address VARCHAR(300),
					@Active BIT
AS
BEGIN
	INSERT INTO Members 
	VALUES(@FirstName, @LastName, @PhoneNumber, @Email, @Address, @Active)
END
GO
-- UPDATE - Member
CREATE PROC [Person].[uspUpdateMember]  @Id INT,
					@FirstName VARCHAR(30),
					@LastName VARCHAR(30),
					@PhoneNumber VARCHAR(13),
					@Email VARCHAR(40),
					@Address VARCHAR(300),
					@Active BIT
AS
BEGIN
	UPDATE Members SET  MemberFirstName = @FirstName,
			    MemberLastName = @LastName,
			    MemberPhoneNumber = @PhoneNumber,
			    MemberEmail = @Email,
			    MemberAddress = @Address,
			    Active = @Active
	WHERE Id = @Id
END
GO
-- DELETE - Member
CREATE PROC [Person].[uspDeleteMember] @Id INT
AS
BEGIN
	UPDATE Members SET Active = 0
	WHERE Id = @Id
END
GO
---
CREATE FUNCTION [Person].[GetAllMember] (@Active BIT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN( SELECT * FROM [Person].[Members]
			WHERE Active = @Active
			FOR JSON AUTO)
END
GO
-- Member Find (Function)
CREATE FUNCTION [Person].[FindMember] (@Name VARCHAR(30))
RETURNS NVARCHAR(MAX)
AS
BEGIN
	RETURN(SELECT * FROM [Person].[Members]
			WHERE MemberFirstName LIKE '%' + @Name + '%'
			FOR JSON AUTO)
END
GO
