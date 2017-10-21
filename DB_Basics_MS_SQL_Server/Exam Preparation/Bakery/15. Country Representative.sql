-- all countries with their most active distributor 
-- (the one with the greatest number of ingredients). 
-- If there are several distributors with most ingredients delivered, list them all. 

SELECT * FROM Countries
SELECT * FROM Distributors
SELECT * FROM Ingredients

SELECT c.Name AS CountryName, 
	   d.Name AS DisributorName 
  FROM Countries AS c
  JOIN Distributors AS d ON c.Id = d.CountryId
  JOIN Ingredients AS i ON d.Id = i.DistributorId
ORDER BY c.Name, d.Name