SELECT CONCAT(FirstName, ' ', LastName) AS CustomerName, 
	   PhoneNumber, 
	   Gender 
  FROM Customers AS c
 WHERE Id NOT IN (SELECT CustomerId FROM Feedbacks)
ORDER BY c.Id
--
