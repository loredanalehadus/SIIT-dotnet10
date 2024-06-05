------------------------
-- Recap SELECT Examples
------------------------
-- Arithmetic operations: +, -, *, /
-- Select Movie rating and increase it with 0,5

USE Cinema;
GO

SELECT Rating, Rating + 0.5 
FROM Movie;

SELECT * FROM Movie;

-- Concatenate Actor's first and last name into FullName

-- Use literals to concatenate data
SELECT Movie.Title + ' is ' + Director.LastName + '''s movie' AS [Director's Movies]
FROM Director 
INNER JOIN Movie ON Director.Id = Movie.DirectorID

-- (DISTINCT) Get all unique ratings from Movie
SELECT DISTINCT Rating
From Movie;

-- Logical operators: NOT, OR, AND 
-- Get all movies with a rating higher of 8.5 AND duration less than 200 m
SELECT *
FROM Movie
WHERE Rating >= 8.5 
AND Duration < 200
AND Title LIKE 'I%'
AND DirectorID NOT IN (2, 3)

-- Get all directors which are either born before 1950 or
-- and their nationality is either British or American

SELECT FirstName + ' ' + LastName AS FullName
From Director
WHERE YEAR(BirthDate) <= 1950 
AND (Nationality = 'British' OR Nationality = 'American')

------------------------
-- GROUP Functions
------------------------
-- COUNT all movies with rating higher than 8.0
SELECT COUNT(*)  
FROM Movie
WHERE Rating > 8

-- Select movies with MIN, MAX, AVG and SUM of movie duration 
SELECT 
	MIN(Duration) [Min],
	MAX(Duration) [Max], 
	AVG(Duration) [Average],
	SUM(Duration) [Sum]
FROM Movie 

-- Display Actor's last name in alphabetical order using MIN
SELECT TOP 1 LastName
FROM Actor
ORDER BY 1 

SELECT MIN(LastName)
FROM Actor

------------------------
-- GROUP BY
------------------------
-- How many movies do the actors play on?

SELECT a.LastName AS ActorName, COUNT(*) as [Number of movies]--, m.Title as MovieTitle
FROM Movie m 
JOIN MovieActor ma ON ma.MovieId = m.Id
JOIN Actor a ON a.Id = ma.ActorId
GROUP BY a.LastName

-- Which are the actors that play in more than 2 movies?
SELECT a.LastName AS ActorName, COUNT(m.Title) as [Number of movies]--, m.Title as MovieTitle
FROM Movie m 
JOIN MovieActor ma ON ma.MovieId = m.Id
JOIN Actor a ON a.Id = ma.ActorId
GROUP BY a.LastName
HAVING COUNT(m.Title) >= 2 

----------
--JOINS
----------
-- Which actor has worked with the most distinct movie directors?


SELECT a.Id, a.FirstName, a.LastName, d.LastName as Director--, COUNT(DISTINCT d.Id) AS DistinctDirectorsCount
FROM Actor a
INNER JOIN MovieActor ma ON a.Id = ma.ActorID
INNER JOIN Movie m ON ma.MovieID = m.Id
INNER JOIN Director d ON m.DirectorID = d.Id


SELECT a.Id, a.FirstName, a.LastName, d.LastName as Director, COUNT(DISTINCT d.Id) AS DistinctDirectorsCount
FROM Actor a
INNER JOIN MovieActor ma ON a.Id = ma.ActorID
INNER JOIN Movie m ON ma.MovieID = m.Id
INNER JOIN Director d ON m.DirectorID = d.Id
GROUP BY a.Id, a.FirstName, a.LastName, d.LastName
ORDER BY DistinctDirectorsCount DESC;