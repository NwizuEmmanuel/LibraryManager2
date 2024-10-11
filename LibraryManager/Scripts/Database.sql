-- Use the LibraryDB database
USE [library_db];
GO

-- Books Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Books' AND xtype = 'U')
BEGIN
    CREATE TABLE [Books] (
        [BookId] INT IDENTITY(1,1) PRIMARY KEY,
        [Title] VARCHAR(255) NOT NULL,
        [ISBN] VARCHAR(13) NOT NULL UNIQUE,
		[Authors] VARCHAR(255) NOT NULL,
        [Category] VARCHAR(255) NOT NULL,
        [Publisher] VARCHAR(255) NOT NULL,
        [PublishedDate] DATE NOT NULL,
		[Quantity] int default 1
    );
END

-- Students Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Students' AND xtype = 'U')
BEGIN
    CREATE TABLE [Students] (
        [StudentId] INT PRIMARY KEY,
        [FirstName] VARCHAR(100) NOT NULL,
        [LastName] VARCHAR(100) NOT NULL,
        [Sex] VARCHAR(10) NOT NULL,
        [Department] VARCHAR(255) NOT NULL,
        [Email] VARCHAR(100) UNIQUE,
        [PhoneNumber] VARCHAR(15),
        [Address] VARCHAR(255) NOT NULL,
    );
END

-- Librarians Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Librarians' AND xtype = 'U')
BEGIN
    CREATE TABLE [Librarians] (
        [LibrarianId] INT IDENTITY(1,1) PRIMARY KEY,
        [FirstName] VARCHAR(100) NOT NULL,
        [LastName] VARCHAR(100) NOT NULL,
        [Email] VARCHAR(100) UNIQUE NOT NULL,
        [PhoneNumber] VARCHAR(15) NOT NULL,
        [Password] VARCHAR(50) NOT NULL,
		[Role] nvarchar(10) not null
    );
END

-- Borrows Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Borrows' AND xtype = 'U')
BEGIN
    CREATE TABLE [Borrows] (
        [BorrowId] INT IDENTITY(1,1) PRIMARY KEY,
        [BookId] INT NOT NULL,
        [StudentId] INT NOT NULL,
        [BorrowDate] DATE NOT NULL,
        [DueDate] DATE NOT NULL,
        [ReturnDate] DATE,
        [LibrarianId] INT NOT NULL,
        FOREIGN KEY ([BookId]) REFERENCES [Books]([BookId]),
        FOREIGN KEY ([StudentId]) REFERENCES [Students]([StudentId]),
        FOREIGN KEY ([LibrarianId]) REFERENCES [Librarians]([LibrarianId])
    );
END

INSERT INTO [Librarians]([FirstName],[LastName],[Email],[PhoneNumber],[Password],[Role])
VALUES ('Emmanuel','Okoro','emmanuel.okoro@yahoo.com','123-234','passowrd123', 'user'),
('Lindy','Chukwuemela','lindy.chukwuemela@icloud.com','234-222','password234','admin')
GO