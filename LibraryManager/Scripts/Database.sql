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

-- Insert data into Books table
INSERT INTO Books (Title, ISBN, Authors, Category, Publisher, PublishedDate, Quantity)
VALUES 
('The Great Gatsby', '9780743273565', 'F. Scott Fitzgerald', 'Fiction', 'Scribner', '1925-04-10', 5),
('1984', '9780451524935', 'George Orwell', 'Dystopian', 'Plume', '1949-06-08', 3),
('To Kill a Mockingbird', '9780061120084', 'Harper Lee', 'Fiction', 'J.B. Lippincott & Co.', '1960-07-11', 7),
('Moby Dick', '9781503280786', 'Herman Melville', 'Adventure', 'Harper & Brothers', '1851-11-14', 4),
('Pride and Prejudice', '9780141439518', 'Jane Austen', 'Romance', 'T. Egerton', '1813-01-28', 6),
('The Catcher in the Rye', '9780316769488', 'J.D. Salinger', 'Fiction', 'Little, Brown and Company', '1951-07-16', 8),
('The Lord of the Rings', '9780544003415', 'J.R.R. Tolkien', 'Fantasy', 'George Allen & Unwin', '1954-07-29', 10),
('Harry Potter and the Sorcerer''s Stone', '9780590353427', 'J.K. Rowling', 'Fantasy', 'Bloomsbury', '1997-06-26', 12),
('The Hobbit', '9780547928227', 'J.R.R. Tolkien', 'Fantasy', 'George Allen & Unwin', '1937-09-21', 5),
('Brave New World', '9780060850524', 'Aldous Huxley', 'Dystopian', 'Chatto & Windus', '1932-08-18', 9);
GO

-- Insert data into Students table
INSERT INTO Students (StudentId, FirstName, LastName, Sex, Department, Email, PhoneNumber, Address)
VALUES
(1, 'John', 'Doe', 'Male', 'Computer Science', 'john.doe@example.com', '555-1234', '123 Main St.'),
(2, 'Jane', 'Smith', 'Female', 'Mathematics', 'jane.smith@example.com', '555-5678', '456 Oak St.'),
(3, 'Emily', 'Johnson', 'Female', 'Biology', 'emily.johnson@example.com', '555-9876', '789 Maple St.'),
(4, 'Michael', 'Brown', 'Male', 'History', 'michael.brown@example.com', '555-5432', '321 Pine St.'),
(5, 'David', 'Lee', 'Male', 'Physics', 'david.lee@example.com', '555-6543', '654 Birch St.'),
(6, 'Sarah', 'Miller', 'Female', 'Chemistry', 'sarah.miller@example.com', '555-7654', '987 Cedar St.'),
(7, 'Jessica', 'Davis', 'Female', 'Engineering', 'jessica.davis@example.com', '555-8765', '111 Walnut St.'),
(8, 'Daniel', 'Garcia', 'Male', 'Business', 'daniel.garcia@example.com', '555-4321', '222 Spruce St.'),
(9, 'Robert', 'Martinez', 'Male', 'Economics', 'robert.martinez@example.com', '555-5432', '333 Chestnut St.'),
(10, 'Laura', 'Wilson', 'Female', 'Literature', 'laura.wilson@example.com', '555-6543', '444 Aspen St.');
GO

-- Insert data into Librarians table
INSERT INTO Librarians (FirstName, LastName, Email, PhoneNumber, Password, Role)
VALUES
('Anna', 'Baker', 'anna.baker@example.com', '555-1111', 'password123', 'Admin'),
('Chris', 'Wilson', 'chris.wilson@example.com', '555-2222', 'password123', 'Staff'),
('Eve', 'Robinson', 'eve.robinson@example.com', '555-3333', 'password123', 'Staff'),
('Mark', 'Thompson', 'mark.thompson@example.com', '555-4444', 'password123', 'Staff'),
('Sophie', 'Wright', 'sophie.wright@example.com', '555-5555', 'password123', 'Admin'),
('Tom', 'Hall', 'tom.hall@example.com', '555-6666', 'password123', 'Staff'),
('James', 'King', 'james.king@example.com', '555-7777', 'password123', 'Admin'),
('Olivia', 'Green', 'olivia.green@example.com', '555-8888', 'password123', 'Staff'),
('Lucas', 'Young', 'lucas.young@example.com', '555-9999', 'password123', 'Staff'),
('Grace', 'Carter', 'grace.carter@example.com', '555-1010', 'password123', 'Admin');
