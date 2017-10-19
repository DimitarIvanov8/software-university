SELECT TOP (3) m.FirstName + ' ' + m.LastName AS Mechanic, 
	   COUNT(*) AS Jobs
  FROM Mechanics AS m
  JOIN Jobs AS j ON J.MechanicId = M.MechanicId
 WHERE j.Status <> 'Finished'
GROUP BY m.MechanicId, m.FirstName + ' ' + m.LastName
HAVING COUNT(*) > 1
ORDER BY Jobs DESC, m.MechanicId

