-- Create a table called MovieHistory with a column for Id and a column for Message.
CREATE TABLE MovieHistory (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Message NVARCHAR(100) NOT NULL
);
GO

-- Create a trigger that will add a new entry in the MovieHistory table when a row from Movie's table is updated.

--trigger definition
CREATE OR ALTER TRIGGER trg_AfterMovieUpdate
ON Movie
AFTER UPDATE
AS
BEGIN
    -- Trigger body
	--declare variable
	DECLARE @Message NVARCHAR(100), @MovieId INT, @OldRating DECIMAL(3,1), @NewRating DECIMAL(3,1);

	SELECT @MovieId = i.Id, @OldRating = d.Rating, @NewRating = i.Rating 
	FROM inserted i
	JOIN deleted d ON i.Id = d.Id

	--assign value to var
	SET @Message = 'Movie with Id ' + CAST(@MovieId AS NVARCHAR(10)) + 'had it''s rating changed from ' +
					CAST(@OldRating AS NVARCHAR(10)) + 'to ' + CAST(@NewRating AS NVARCHAR(10)); 

	-- insert values into MovieHistory
	INSERT INTO MovieHistory (Message)
	VALUES (@Message);

END;
GO

--before
SELECT * FROM Movie where Id = 1;
SELECT * FROM MovieHistory;

--update to movies
UPDATE Movie
SET Rating = 7.6
WHERE Id = 1

--after
SELECT * FROM Movie where Id = 1;
SELECT * FROM MovieHistory;