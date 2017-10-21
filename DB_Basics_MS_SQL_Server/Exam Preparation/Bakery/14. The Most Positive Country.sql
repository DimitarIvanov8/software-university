SELECT TOP(1) WITH TIES
	   c.Name AS CountryName, 
	   AVG(f.Rate) AS FeedbackRate
  FROM Countries AS c
  JOIN Customers AS cc ON c.Id = cc.CountryId
  JOIN Feedbacks AS f ON cc.Id = f.CustomerId
GROUP BY c.Name
ORDER BY FeedbackRate DESC