SELECT m.FirstName + ' ' + m.LastName AS Available 
  FROM Mechanics AS m
WHERE MechanicId NOT IN (SELECT DISTINCT MechanicId FROM Jobs
WHERE MechanicId IS NOT NULL AND Status <> 'Finished')
ORDER BY m.MechanicId