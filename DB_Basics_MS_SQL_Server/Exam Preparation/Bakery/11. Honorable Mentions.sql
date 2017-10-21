SELECT f.ProductId, 
	   CONCAT(FirstName, ' ', LastName) AS CustomerName, 
	   f.Description 
  FROM Feedbacks AS f
  JOIN Customers AS c ON c.Id = f.CustomerId
 WHERE c.Id IN (
	SELECT CustomerId 
	FROM Feedbacks AS f
	GROUP BY CustomerId
	HAVING COUNT(f.Id) >= 3
)
ORDER BY ProductId, CustomerName, f.Id