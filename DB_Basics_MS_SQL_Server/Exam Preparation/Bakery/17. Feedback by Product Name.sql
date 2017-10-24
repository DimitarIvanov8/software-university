CREATE FUNCTION udf_GetRating (@ProductName VARCHAR(50))
RETURNS VARCHAR(20)
AS
BEGIN
	DECLARE @rating DECIMAL(4,2) = (	
	SELECT AVG(f.rate)
	FROM Feedbacks AS f
	JOIN Products AS p ON f.ProductId = p.Id
	WHERE p.Name = @ProductName
	);

	DECLARE @describeRating VARCHAR(20);
	IF(@rating < 5)
	SET @describeRating = 'Bad'

	ELSE IF(@rating BETWEEN 5 AND 8)
	SET @describeRating = 'Average'

	ELSE IF(@rating > 8)
	SET @describeRating = 'Good'

	ELSE IF(@rating IS NULL)
	SET @describeRating = 'No rating'
		 	    
	RETURN @describeRating
END

--Testing:
SELECT TOP 5 Id, Name, dbo.udf_GetRating(Name)
  FROM Products
 ORDER BY Id
