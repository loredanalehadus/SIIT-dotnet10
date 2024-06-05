-- Create a stored procedure that will increment the rating by 1 for a given movie id.

--stored procedure definition
CREATE PROCEDURE IncrementMovieRating
    @MovieID INT
AS
BEGIN
    -- Procedure body
	
	-- Check if the movie exists and its current rating
    IF EXISTS (SELECT Id FROM Movie WHERE Id = @MovieID)
    BEGIN
        -- Update the rating by incrementing it by 1
        UPDATE Movie
        SET Rating = Rating + 1
        WHERE Id = @MovieID;
    END
    ELSE
    BEGIN
        -- If the movie does not exist, raise an error
        RAISERROR ('Movie with ID %d does not exist.', 16, 1, @MovieID);
    END
END;
GO

-- raise error severity code
-- 11-16 are considered errors that can be fixed by the user.
-- 17-19 are considered Non-Fatal errors in Sql Server Resources, Engine and other stuff .
-- 20-25 are considered Fatal Error which causes sql server to shut down the process immediately.

-- usage
EXEC IncrementMovieRating @MovieId = 10;