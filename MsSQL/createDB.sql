CREATE DATABASE LibraryDB
GO
USE LibraryDB
GO
CREATE SCHEMA Product
GO
CREATE SCHEMA Person
GO
CREATE TABLE Product.Categories(Id INT PRIMARY KEY IDENTITY,
								CategoryName VARCHAR(30) NOT NULL,
								Active BIT DEFAULT 1)
GO
CREATE TABLE Person.Authors(Id INT IDENTITY PRIMARY KEY,
							AuthorFirstName VARCHAR(30) NOT NULL,
							AuthorLastName VARCHAR(30) NOT NULL,
							Active BIT DEFAULT 1)
GO
CREATE TABLE Person.Members(Id INT PRIMARY KEY IDENTITY,
							MemberFirstName VARCHAR(30) NOT NULL,
							MemberLastName VARCHAR(30) NOT NULL,
							MemberPhoneNumber VARCHAR(16) NOT NULL UNIQUE,
							MemberEmail VARCHAR(40) NOT NULL UNIQUE,
							MemberAddress VARCHAR(300) NOT NULL,
							Active BIT DEFAULT 1)
GO
CREATE TABLE Product.Books(Id INT PRIMARY KEY IDENTITY,
							BookName VARCHAR(30) NOT NULL,
							AuthorID INT REFERENCES Person.Authors(Id),
							BookPublicationYear INT NOT NULL,
							BookSummary VARCHAR(500) NOT NULL,
							BookImagePath VARCHAR(100) NOT NULL,
							BookLanguage VARCHAR(30) NOT NULL,
							CategoryID INT REFERENCES Product.Categories(Id),
							Active BIT DEFAULT 1)
GO
CREATE TABLE Product.BookMembers(Id INT PRIMARY KEY IDENTITY,
								MemberID INT REFERENCES Person.Members(Id),
								BookID INT REFERENCES Product.Books(Id),
								BookMemberRentalDate SMALLDATETIME NOT NULL DEFAULT GETDATE(),
								BookMemberLeaseEndDate SMALLDATETIME NOT NULL,
								Active BIT DEFAULT 1)
GO