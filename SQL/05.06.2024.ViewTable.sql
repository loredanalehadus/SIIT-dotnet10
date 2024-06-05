-- Create a view that will display all the movie titles with the directors' first names and last names.

-- definition of the view
CREATE VIEW MovieDirectorView
AS
SELECT m.Title, d.FirstName, d.LastName
FROM Movie m
INNER JOIN Director d ON m.DirectorID = d.Id

-- usage
SELECT * FROM MovieDirectorView
