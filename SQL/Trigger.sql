USE Cinema;
GO

-- Create a trigger that will add a new entry in the MovieHistory table when a row from Movie's table is updated.
-- Create the trigger
CREATE TRIGGER trg_AfterMovieUpdate
ON Movie
AFTER UPDATE
AS
BEGIN
    DECLARE @MovieID INT, @OldRating DECIMAL(3,1), @NewRating DECIMAL(3,1), @Message NVARCHAR(MAX);

    -- Capture the MovieID and the old and new ratings from the inserted and deleted tables
    SELECT @MovieID = i.MovieID, @OldRating = d.Rating, @NewRating = i.Rating
    FROM inserted i
    JOIN deleted d ON i.MovieID = d.MovieID;

    -- Construct the message
    SET @Message = 'Movie with ID ' + CAST(@MovieID AS NVARCHAR(10)) + ' had its rating changed from ' 
                   + CAST(@OldRating AS NVARCHAR(10)) + ' to ' + CAST(@NewRating AS NVARCHAR(10)) + '.';

    -- Insert the message into the MovieHistory table
    INSERT INTO MovieHistory (Message)
    VALUES (@Message);
END;
GO

-- Update a movie's rating
UPDATE Movie
SET Rating = 8.5
WHERE MovieID = 1;