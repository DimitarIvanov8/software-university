SELECT FirstName + ' ' + LastName AS [Mechanic], Status, IssueDate FROM Jobs AS j
JOIN Mechanics AS m ON m.MechanicId = j.MechanicId
ORDER BY m.MechanicId, j.IssueDate, j.JobId