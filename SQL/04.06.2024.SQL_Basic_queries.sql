-- Create database
CREATE DATABASE Cinema;
USE Cinema;
GO

-- Create Director's table
CREATE TABLE Director (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Nationality NVARCHAR(50),
	BirthDate DATE
);
GO

--ALTER TABLE Director 
--ADD Gendre BIT

--ALTER TABLE Director 
--DROP COLUMN Gendre

-- Insert data into Director table
INSERT INTO Director (FirstName, LastName, Nationality, BirthDate)
VALUES 
('Christopher', 'Nolan', 'British-American', '1970-07-30'),
('Quentin', 'Tarantino', 'American', '1963-03-27'),
('Steven', 'Spielberg', 'American', '1946-12-18'),
('Martin', 'Scorsese', 'American', '1942-11-17'),
('Ridley', 'Scott', 'British', '1937-11-30');
GO

-- get all Directors
SELECT * FROM Director
GO

-- select lastname
SELECT LastName FROM Director
GO

-- select record with id 3
SELECT * FROM Director
WHERE Id = 3
GO

-- UPDATE record with ID no 3
UPDATE Director
SET Nationality = Nationality + 'Updated'
WHERE Id = 3
GO

INSERT INTO Director (FirstName, LastName, Nationality, BirthDate)
VALUES 
('Toma', 'Caragiu', 'Romanian', '1950-07-30')
GO

DELETE Director 
WHERE FirstName = 'Toma'
GO