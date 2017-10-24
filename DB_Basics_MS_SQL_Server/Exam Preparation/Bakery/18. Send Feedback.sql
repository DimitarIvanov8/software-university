CREATE PROC usp_SendFeedback (@customerId INT, @productId INT, @rate DECIMAL(4,2), @description NVARCHAR(MAX))
AS
BEGIN
	BEGIN TRAN
	INSERT INTO Feedbacks (CustomerId, ProductId, Rate, Description)
	VALUES
	(@customerId, @productId, @rate, @description)

	DECLARE @feedbackCount INT = (
		SELECT COUNT(f.Id)
		FROM Feedbacks AS f
		WHERE ProductId = @productId AND CustomerId = @customerId)
	IF @feedbackCount > 3
	BEGIN
		ROLLBACK
		RAISERROR('You are limited to only 3 feedbacks per product!', 16, 1);
	END
	ELSE
	BEGIN
		COMMIT
	END
END 

--Testing:
EXEC usp_SendFeedback 1, 5, 7.50, 'Average experience';
SELECT COUNT(*) FROM Feedbacks WHERE CustomerId = 1 AND ProductId = 5;


