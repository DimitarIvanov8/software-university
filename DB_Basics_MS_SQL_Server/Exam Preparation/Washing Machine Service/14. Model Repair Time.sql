--all models with
--average time it took to service (in DAYS)
--out of all the times it was repaired

SELECT m.ModelId, 
	   m.Name, 
	   CAST(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)) AS VARCHAR(10)) + ' days' AS [Average Service Time]
  FROM Models AS m
  JOIN Jobs AS j ON j.ModelId = m.ModelId
GROUP BY m.ModelId, M.Name
ORDER BY AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))