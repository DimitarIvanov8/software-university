CREATE FUNCTION udf_GetCost(@jobId INT)
RETURNS DECIMAL(6,2)
AS
BEGIN
	DECLARE @totalSum DECIMAL(6,2) = (SELECT ISNULL(SUM(P.Price * op.Quantity), 0) AS Result FROM Parts AS p
	JOIN OrderParts AS op ON op.PartId = p.PartId
	JOIN Orders AS o ON o.OrderId = op.OrderId
	JOIN Jobs AS jo ON jo.JobId = o.JobId
	WHERE jo.JobId = @jobId)
	RETURN @totalSum
END

SELECT dbo.udf_GetCost(1)
