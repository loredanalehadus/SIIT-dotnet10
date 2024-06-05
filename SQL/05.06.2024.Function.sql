-- Create a function that will calculate and return the average rating of movies for a given director id

-- function definition
CREATE OR ALTER FUNCTION GetAverageRatingForDirector
(
	@DirectorID INT
)
RETURNS DECIMAL(3,1)
AS
BEGIN
    -- Function body

	--declare variable
	DECLARE @AverageRating DECIMAL(3,1);

	-- average rating for a given director
	SELECT @AverageRating = AVG(Rating)
	FROM Movie m 
	INNER JOIN Director d ON m.DirectorID = d.Id
	WHERE DirectorID = @DirectorID

	RETURN ISNULL(@AverageRating, 0); -- Returns 0 if there are no movies fro the given director id
END;
GO


-- usage of the function
SELECT dbo.GetAverageRatingForDirector(1) AS AverageRatingForDirector1;