--====================
--For Exercises 1 - 11 
--USE SoftUni
--====================

--1. Employee Address
SELECT TOP(5) 
           EmployeeID, 
		 JobTitle, 
		 e.AddressID, 
		 a.AddressText 
      FROM Employees AS e
      JOIN Addresses AS a 
	   ON a.AddressID = e.AddressID
  ORDER BY e.AddressID

--2. Addresses with Towns
SELECT TOP(50) 
           e.FirstName, 
		 e.LastName, 
		 t.Name AS [Town], 
		 a.AddressText 
      FROM Employees AS e
      JOIN Addresses AS a 
	   ON a.AddressID = e.AddressID
      JOIN Towns AS t 
	   ON t.TownID = a.TownID
  ORDER BY e.FirstName, e.LastName

--3. Sales Employees
SELECT e.EmployeeID,
       e.FirstName,
   	  e.LastName,
   	  d.Name AS [DepartmentName] 
    FROM Employees AS e
    JOIN Departments AS d
      ON d.DepartmentID = e.DepartmentID
   WHERE d.DepartmentID = 3
ORDER BY e.EmployeeID

--4. Employee Departments
SELECT TOP(5) e.EmployeeID, 
		    e.FirstName, 
		    e.Salary, 
		    d.Name AS [DepartmentName] 
         FROM Employees AS e
	    JOIN Departments AS d 
	      ON d.DepartmentID = e.DepartmentID
        WHERE e.Salary >= 15000
     ORDER BY d.DepartmentID

--5. Employees Without Projects
SELECT TOP(3) 
           e.EmployeeID, 
           e.FirstName 
	 FROM Employees AS e
     WHERE e.EmployeeID 
    NOT IN (
    SELECT ep2.EmployeeID 
      FROM EmployeesProjects AS ep2)
  ORDER BY e.EmployeeID

--or

SELECT TOP(3) 
           e.EmployeeID, 
		 e.FirstName 
      FROM Employees AS e
 LEFT JOIN EmployeesProjects AS ep 
        ON ep.EmployeeID = e.EmployeeID
     WHERE ep.ProjectID IS NULL


--6. Employees Hired After
SELECT e.FirstName, 
       e.LastName, 
  	  e.HireDate, 
  	  d.Name AS DeptName  
    FROM Employees AS e
    JOIN Departments AS d 
      ON d.DepartmentID = e.DepartmentID
   WHERE d.Name IN ('Finance', 'Sales')
     AND e.HireDate > '1.1.1999'	
ORDER BY e.HireDate

--7. Employees With Project
SELECT TOP(5) 
	      ep.EmployeeID, 
		 e.FirstName, p.Name AS ProjectName 
	 FROM Employees AS e
      JOIN EmployeesProjects AS ep 
	   ON ep.EmployeeID = e.EmployeeID
      JOIN Projects AS p 
	   ON p.ProjectID = ep.ProjectID
     WHERE ep.ProjectID IS NOT NULL
	  AND p.EndDate IS NULL
	  AND p.StartDate >= '08/13/2002'
  ORDER BY ep.EmployeeID

--8. Employee 24
SELECT e.EmployeeID, 
       e.FirstName, 
	  CASE 
	  WHEN p.StartDate > '2005' THEN NULL
	  ELSE p.Name
	  END AS ProjectName
 FROM Employees AS e
 JOIN EmployeesProjects AS ep 
   ON ep.EmployeeID = e.EmployeeID
 JOIN Projects AS p 
   ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24

--9. Employee Manager
SELECT e.EmployeeID, 
	  e.FirstName, 
	  e.ManagerID, (
	  SELECT FirstName 
	    FROM Employees AS e2
	   WHERE e2.EmployeeID = e.ManagerID) AS ManagerName
    FROM Employees AS e
   WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID

--10. Employees Summary
SELECT TOP(50) 
	      e.EmployeeID, 
		 e.FirstName + ' ' + e.LastName AS [EmployeeName],
		 e2.FirstName + ' ' + e2.LastName AS [ManagerName], 
		 d.Name AS [DepartmentName]  
      FROM Employees AS e
      JOIN Departments AS d 
	   ON d.DepartmentID = e.DepartmentID
      JOIN Employees AS e2 
	   ON e.ManagerID = e2.EmployeeID
  ORDER BY e.EmployeeID

--11. Min Average Salary
SELECT DISTINCT TOP (1) (
    SELECT AVG(Salary) 
      FROM Employees AS e2  
     WHERE e2.DepartmentID = e.DepartmentID)
        AS MinAverageSalary 
      FROM Employees AS e
  ORDER BY MinAverageSalary

--or

SELECT MIN(AvgSalary) AS MinAverageSalary
      FROM(
SELECT AVG(Salary) AS AvgSalary 
      FROM Employees
  GROUP BY DepartmentID)
        AS tempTable

--=====================
--For Exercises 12 - 17 
--USE Geography
--=====================
--12. Highest Peaks in Bulgaria
SELECT mc.CountryCode, 
       m.MountainRange, 
	  p.PeakName, 
	  p.Elevation 
  FROM Peaks AS p
  JOIN Mountains AS m 
    ON m.Id = p.MountainId
  JOIN MountainsCountries AS mc 
    ON m.Id = mc.MountainId 
 WHERE mc.CountryCode = 'BG' 
   AND p.Elevation > 2835
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges
SELECT mc.CountryCode, 
 COUNT(m.MountainRange) AS MountainRanges 
  FROM MountainsCountries AS mc
  JOIN Mountains AS m 
    ON m.Id = mc.MountainId
 WHERE mc.CountryCode IN ('BG', 'RU', 'US')
GROUP BY mc.CountryCode

--14. Countries With or Without Rivers
SELECT TOP(5) 
	      c.CountryName, 
		 r.RiverName 
      FROM Countries AS c
 LEFT JOIN CountriesRivers AS cr 
        ON cr.CountryCode = c.CountryCode
 LEFT JOIN Rivers AS r 
        ON r.Id = cr.RiverId
     WHERE ContinentCode = 'AF'
  ORDER BY CountryName

--15. *Continents and Currencies
SELECT ContinentCode, CurrencyCode, CurrencyUsage
FROM(
    SELECT ContinentCode, CurrencyCode, CurrencyUsage,
    DENSE_RANK() OVER(PARTITION BY(ContinentCode)
    ORDER BY CurrencyUsage DESC) AS [Rank]
	   FROM(
	  SELECT ContinentCode, CurrencyCode, 
	   COUNT(CurrencyCode) AS CurrencyUsage
	   FROM Countries
    GROUP BY CurrencyCode, ContinentCode) AS currencies) AS rankedCurrencies
WHERE [Rank] = 1 AND CurrencyUsage > 1
ORDER BY ContinentCode

--16. Countries Without any Mountains
SELECT COUNT(CountryCode) AS CountryCode 
  FROM Countries
 WHERE CountryCode NOT IN 
(SELECT CountryCode FROM MountainsCountries)

--or

SELECT mc.CountryCode INTO TEST
  FROM MountainsCountries AS mc
  RIGHT JOIN Countries AS c 
   ON c.CountryCode = mc.CountryCode
WHERE mc.MountainId IS NULL

SELECT COUNT(*) AS [CountryCode] FROM TEST

--17. Highest Peak and Longest River by Country
--CountryName	HighestPeakElevation	LongestRiverLength
SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS HighestPeakElevation, MAX(r.Length) AS LongestRiverLength FROM Countries AS c
RIGHT OUTER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
RIGHT OUTER JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
RIGHT OUTER JOIN Rivers AS r ON r.Id = cr.RiverId
RIGHT OUTER JOIN Mountains AS m ON m.Id = mc.MountainId
RIGHT OUTER JOIN Peaks AS p ON p.MountainId = m.Id
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName
