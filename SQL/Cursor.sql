USE Cinema;
GO

--Create a cursor that will print on the screen all movies with a title shorter than 10 characters

-- Declare variables to hold the movie title and ID
DECLARE @MovieTitle NVARCHAR(255);
DECLARE @MovieID INT;

-- Declare the cursor
DECLARE MovieCursor CURSOR FOR
SELECT MovieID, Title
FROM Movie
WHERE LEN(Title) < 10;

-- Open the cursor
OPEN MovieCursor;

-- Fetch the first row from the cursor
FETCH NEXT FROM MovieCursor INTO @MovieID, @MovieTitle;

-- Loop until there are no more rows to fetch
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Print the movie title
    PRINT 'Movie ID: ' + CAST(@MovieID AS NVARCHAR(10)) + ', Title: ' + @MovieTitle;

    -- Fetch the next row from the cursor
    FETCH NEXT FROM MovieCursor INTO @MovieID, @MovieTitle;
END;

-- Close and deallocate the cursor
CLOSE MovieCursor;
DEALLOCATE MovieCursor;



