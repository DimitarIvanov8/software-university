-- distributors 
-- which distribute ingredients used in the making process of all products 
-- having average rate between 5 and 8 (inclusive). 

SELECT d.Name AS DistributorName, 
       i.Name AS IngredientName, 
	   p.Name AS ProductName, 
	   AVG(f.Rate) AS AverageRate 
  FROM Distributors AS d
  JOIN Ingredients AS i ON d.Id = i.DistributorId
  JOIN ProductsIngredients AS pin ON i.Id = pin.IngredientId
  JOIN Products AS p ON p.Id = pin.ProductId
  JOIN Feedbacks AS f ON p.Id = f.ProductId
GROUP BY d.Name, i.Name, p.Name
HAVING AVG(f.Rate) BETWEEN 5 AND 8
ORDER BY DistributorName, IngredientName, ProductName
