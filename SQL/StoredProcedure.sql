--Create a stored procedure that will increment the rating by 1 for a given movie id.

USE Cinema;
GO

-- Create the stored procedure
CREATE PROCEDURE IncrementMovieRating @MovieID INT
AS
BEGIN
    -- Check if the movie exists and its current rating
    IF EXISTS (SELECT 1 FROM Movie WHERE MovieID = @MovieID)
    BEGIN
        -- Update the rating by incrementing it by 1
        UPDATE Movie
        SET Rating = Rating + 1
        WHERE MovieID = @MovieID;
    END
    ELSE
    BEGIN
        -- If the movie does not exist, raise an error
        RAISERROR ('Movie with ID %d does not exist.', 16, 1, @MovieID);
    END
END;
GO

-- Increment the rating for the movie with ID 1
EXEC IncrementMovieRating @MovieID = 1;

--This command calls the IncrementMovieRating stored procedure and increments the rating of the movie with ID 1 by 1.