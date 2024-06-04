-- Create database
CREATE DATABASE Cinema;
GO

USE Cinema;
GO

-- DROP Database
-- DROP DATABASE Cinema

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
SELECT * 
FROM Director
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

-- BETWEEN 
-- Select directors born between 1940-1970
SELECT FirstName, LastName
FROM Director
WHERE YEAR(BirthDate) BETWEEN 1960 AND 1970

-- LIKE
-- Select directors that last name starts with S
SELECT * 
FROM Director
WHERE LastName LIKE 'S%'
GO

-- FOREIGN KEY (one to many)
-- Create the Movie table
CREATE TABLE Movie (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DirectorID INT,
    Title NVARCHAR(100) NOT NULL,
    ReleaseDate DATE,
    Rating DECIMAL(3,1),
    Duration INT, -- Duration in minutes
    FOREIGN KEY (DirectorID) REFERENCES Director(Id)
);
GO

-- Insert some sample rows into the Movie table
INSERT INTO Movie (DirectorID, Title, ReleaseDate, Rating, Duration)
VALUES
(1, 'Inception', '2010-07-16', 8.8, 148),
(1, 'Interstellar', '2014-11-07', 8.6, 169),
(2, 'Pulp Fiction', '1994-10-14', 8.9, 154),
(3, 'Jurassic Park', '1993-06-11', 8.1, 127),
(3, 'Schindler''s List', '1993-12-15', 8.9, 195),
(4, 'Goodfellas', '1990-09-19', 8.7, 146),
(5, 'Blade Runner', '1982-06-25', 8.1, 117);
GO

-- INNER
SELECT *
FROM Director d INNER JOIN Movie m
	ON d.Id = m.DirectorID

-- ORDER BY
-- lowest rating
SELECT TOP 1 * 
FROM Movie
ORDER BY Rating ASC

-- which director has the most movies directed?
SELECT TOP 1 d.FirstName, d.LastName, COUNT(m.Id) AS MovieCount
FROM Director d INNER JOIN Movie m
	ON d.Id = m.DirectorID
GROUP BY d.FirstName, d.LastName
ORDER BY MovieCount DESC


-- MANY to MAny
CREATE TABLE MovieActor(
	MovieId INT NOT NULL,
	ActorId INT NOT NULL,
	PRIMARY KEY (MovieId, ActorId),
	FOREIGN KEY (MovieId) REFERENCES Movie(Id),
	FOREIGN KEY (ActorId) REFERENCES Actor(Id)
);
GO

INSERT INTO Actor(Id, FirstName, LastName, Nationality, BirthDate)
VALUES
(2, 'Johnny', 'Wactor', 'American', '1986-08-31'),(3, 'Josh', 'Helman', 'Australian', '1986-02-22'),(4, 'Alexandra', 'Daddario', 'American', '1986-03-16'),(5, 'Jessica', 'Gunning', 'British', '1986-01-01'),(6, 'Astrid', 'Berges-Frisbey', 'Spanish', '1986-05-26');
GO
-- Insert a movie-actor pair
INSERT INTO MovieActor (MovieID, ActorID)
VALUES (1, 1);  -- Assuming MovieID 1 and ActorID 1 exist

INSERT INTO MovieActor (MovieID, ActorID)
VALUES (1, 2);  -- Assuming MovieID 1 and ActorID 2 exist

INSERT INTO MovieActor (MovieID, ActorID)
VALUES (2, 1);  -- Assuming MovieID 2 and ActorID 1 exist

SELECT * FROM MovieActor

-- Select movies with their actors
SELECT m.Title as MovieTitle, a.FirstName + ' ' + a.LastName AS ActorName 
FROM Movie m 
JOIN MovieActor ma ON ma.MovieId = m.Id
JOIN Actor a ON a.Id = ma.ActorId