USE master;
GO

-- Create a new database named Cinema
CREATE DATABASE Cinema;
GO

--Delete database
--DROP DATABASE Cinema;
--GO

-- Switch to the Cinema database context
USE Cinema;
GO

-- Create the Director table
CREATE TABLE Director (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Nationality NVARCHAR(50),
    BirthDate DATE
);
GO

-- Insert 5 rows into the Director table
INSERT INTO Director (FirstName, LastName, Nationality, BirthDate)
VALUES 
('Christopher', 'Nolan', 'British-American', '1970-07-30'),
('Quentin', 'Tarantino', 'American', '1963-03-27'),
('Steven', 'Spielberg', 'American', '1946-12-18'),
('Martin', 'Scorsese', 'American', '1942-11-17'),
('Ridley', 'Scott', 'British', '1937-11-30');
GO

-- Delete the director with DirectorID = 3
--DELETE FROM Director
--WHERE Id = 3;
--GO

--Find all the directors that born between 1960 and 1980.
SELECT *
FROM Director
WHERE YEAR(BirthDate) BETWEEN 1960 AND 1980;

--Get all directors which have the last name starting with letter S.
SELECT FirstName, LastName
FROM Director
WHERE LastName LIKE 'S%';

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

-- Update all movies with a rating lower than 10
--UPDATE Movie
--SET Rating = 10, -- Example change: set the rating to 10
--    Title = Title + ' (Updated)' -- Example change: append "(Updated)" to the title
--WHERE Rating < 10;
--GO

CREATE TABLE Actor (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Nationality NVARCHAR(50),
    BirthDate DATE,
    PopularityRating DECIMAL(3,1)
);
GO

INSERT INTO Actor (FirstName, LastName, Nationality, BirthDate, PopularityRating)
VALUES
('Leonardo', 'DiCaprio', 'American', '1974-11-11', 9.8),
('Morgan', 'Freeman', 'American', '1937-06-01', 9.5),
('Scarlett', 'Johansson', 'American', '1984-11-22', 9.3),
('Tom', 'Hanks', 'American', '1956-07-09', 9.7),
('Natalie', 'Portman', 'American', '1981-06-09', 9.2);
GO

-- Find the movie with the lowest rating
SELECT TOP 1 *
FROM Movie
ORDER BY Rating ASC;
GO

-- Find the director who has directed the most movies
SELECT TOP 1 d.FirstName, d.LastName, COUNT(m.Id) AS MovieCount
FROM Director d
JOIN Movie m ON d.Id = m.DirectorID
GROUP BY d.FirstName, d.LastName
ORDER BY MovieCount DESC;
GO

-- Display all movies ordered by director's LastName ascending, then by BirthDate descending
SELECT m.Id, m.Title, m.ReleaseDate, m.Rating, m.Duration, d.FirstName, d.LastName, d.BirthDate
FROM Movie m
JOIN Director d ON m.DirectorID = d.Id
ORDER BY d.LastName ASC, d.BirthDate DESC;
GO

--Create a function that will calculate and return the average rating of movies for a given director id
-- Create the function
CREATE FUNCTION GetAverageRatingForDirector
(
    @DirectorID INT
)
RETURNS DECIMAL(3,1)
AS
BEGIN
    DECLARE @AverageRating DECIMAL(3,1);

    SELECT @AverageRating = AVG(Rating)
    FROM Movie
    WHERE DirectorID = @DirectorID;

    RETURN ISNULL(@AverageRating, 0); -- Return 0 if there are no movies for the director
END;
GO

--DROP FUNCTION GetAverageRatingForDirector;
--GO

--Create a view that will display all the movie titles with the directors' first names and last names.
-- Create the view
CREATE VIEW MovieDirectorView
AS
SELECT m.Title AS MovieTitle, d.FirstName AS DirectorFirstName, d.LastName AS DirectorLastName
FROM Movie m
JOIN Director d ON m.DirectorID = d.Id;
GO

--DROP VIEW MovieDirectorView;
--GO

SELECT * FROM MovieDirectorView;

--Create a table called MovieHistory with a column for Id and a column for Message.
-- Create the MovieHistory table
CREATE TABLE MovieHistory (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Message NVARCHAR(MAX) NOT NULL
);
GO

-- Insert a sample message into the MovieHistory table
INSERT INTO MovieHistory (Message)
VALUES ('Movie rating incremented successfully.');

-- Select all records from the MovieHistory table
SELECT * FROM MovieHistory;


-- Many to many relationship

-- Implement many to many relationship between Movie and Actor
-- Create the MovieActor junction table
CREATE TABLE MovieActor (
    MovieID INT NOT NULL,
    ActorID INT NOT NULL,
    PRIMARY KEY (MovieID, ActorID),
    FOREIGN KEY (MovieID) REFERENCES Movie(Id),
    FOREIGN KEY (ActorID) REFERENCES Actor(Id)
);
GO

-- Insert a movie-actor pair
INSERT INTO MovieActor (MovieID, ActorID)
VALUES (1, 1);  -- Assuming MovieID 1 and ActorID 1 exist

INSERT INTO MovieActor (MovieID, ActorID)
VALUES (1, 2);  -- Assuming MovieID 1 and ActorID 2 exist

INSERT INTO MovieActor (MovieID, ActorID)
VALUES (2, 1);  -- Assuming MovieID 2 and ActorID 1 exist

-- Select movies with their actors
SELECT m.Title AS MovieTitle, a.FirstName AS ActorFirstName, a.LastName AS ActorLastName
FROM Movie m
JOIN MovieActor ma ON m.Id = ma.MovieID
JOIN Actor a ON ma.ActorID = a.Id;


-- Implement many to many relationship between Movie and Genre

-- Create the Genre table
CREATE TABLE Genre (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);
GO

ALTER TABLE MovieGenre
DROP CONSTRAINT FK_MovieGenre;

DROP TABLE Genre;
GO

INSERT INTO Genre 
VALUES

-- Create the MovieGenre junction table
CREATE TABLE MovieGenre (
    MovieID INT NOT NULL,
    GenreID INT NOT NULL,
    PRIMARY KEY (MovieID, GenreID),
    FOREIGN KEY (MovieID) REFERENCES Movie(Id),
    FOREIGN KEY (GenreID) REFERENCES Genre(GenreID)
);
GO

-- Insert a movie-genre pair
INSERT INTO MovieGenre (MovieID, GenreID)
VALUES (1, 1);  -- Assuming MovieID 1 and GenreID 1 exist

INSERT INTO MovieGenre (MovieID, GenreID)
VALUES (1, 2);  -- Assuming MovieID 1 and GenreID 2 exist

INSERT INTO MovieGenre (MovieID, GenreID)
VALUES (2, 1);  -- Assuming MovieID 2 and GenreID 1 exist

-- Select movies with their genres
SELECT m.Title AS MovieTitle, g.Name AS GenreName
FROM Movie m
JOIN MovieGenre mg ON m.MovieID = mg.MovieID
JOIN Genre g ON mg.GenreID = g.GenreID;

--Which actor has worked with the most distinct movie directors?
-- Find the actor who has worked with the most distinct movie directors
SELECT TOP 1 a.ActorID, a.FirstName, a.LastName, COUNT(DISTINCT d.DirectorID) AS DistinctDirectorsCount
FROM Actor a
JOIN MovieActor ma ON a.ActorID = ma.ActorID
JOIN Movie m ON ma.MovieID = m.MovieID
JOIN Director d ON m.DirectorID = d.DirectorID
GROUP BY a.ActorID, a.FirstName, a.LastName
ORDER BY DistinctDirectorsCount DESC;

-- Which is the preferred genre of each actor?
-- CTE to count appearances of each actor in each genre
WITH ActorGenreCount AS (
    SELECT
        a.ActorID,
        a.FirstName,
        a.LastName,
        g.GenreID,
        g.Name AS GenreName,
        COUNT(*) AS GenreCount
    FROM Actor a
    JOIN MovieActor ma ON a.ActorID = ma.ActorID
    JOIN Movie m ON ma.MovieID = m.MovieID
    JOIN MovieGenre mg ON m.MovieID = mg.MovieID
    JOIN Genre g ON mg.GenreID = g.GenreID
    GROUP BY a.ActorID, a.FirstName, a.LastName, g.GenreID, g.Name
),
-- CTE to rank genres for each actor by count
ActorGenreRank AS (
    SELECT
        ActorID,
        FirstName,
        LastName,
        GenreID,
        GenreName,
        GenreCount,
        ROW_NUMBER() OVER (PARTITION BY ActorID ORDER BY GenreCount DESC, GenreName ASC) AS GenreRank
    FROM ActorGenreCount
)
-- Select the preferred genre for each actor
SELECT
    ActorID,
    FirstName,
    LastName,
    GenreID,
    GenreName,
    GenreCount
FROM ActorGenreRank
WHERE GenreRank = 1;