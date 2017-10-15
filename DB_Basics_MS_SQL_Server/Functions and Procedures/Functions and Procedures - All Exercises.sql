--====================
-- For Exercises 1 - 8 
-- USE SoftUni
--====================
--1. Employees with Salary Above 35000
CREATE PROC dbo.usp_GetEmployeesSalaryAbove35000
AS
  SELECT FirstName, LastName FROM Employees
  WHERE Salary > 35000

--Testing:
EXEC usp_GetEmployeesSalaryAbove35000

--2. Employees with Salary Above Number
CREATE PROC dbo.usp_GetEmployeesSalaryAboveNumber (@Salary DECIMAL(18, 4))
AS
    SELECT FirstName, LastName FROM Employees
    WHERE Salary >= @Salary

--Testing:
EXEC usp_GetEmployeesSalaryAboveNumber 50000;

--3. Town Names Starting With
CREATE PROC usp_GetTownsStartingWith (@TownStartString VARCHAR(10))
AS
    SELECT Name FROM Towns
    WHERE Name LIKE (@TownStartString + '%')

--Testing:
EXEC usp_GetTownsStartingWith 'b'

--4. Employees from Town
CREATE PROC usp_GetEmployeesFromTown(@TownName VARCHAR(10))
AS
    SELECT e.FirstName, e.LastName FROM Employees AS e
    JOIN Addresses AS a ON e.AddressID = a.AddressID
    JOIN Towns AS t ON t.TownID = a.TownID
    WHERE t.Name = @TownName

--Testing:
EXEC usp_GetEmployeesFromTown 'Sofia'

--5. Salary Level Function
CREATE FUNCTION ufn_GetSalaryLevel(@Salary MONEY)
RETURNS NVARCHAR(10)
BEGIN
    DECLARE @SalaryLevel NVARCHAR(10);
    IF (@Salary < 30000) SET @SalaryLevel = 'Low';
    ELSE IF (@Salary BETWEEN 30000 AND 50000) SET @SalaryLevel = 'Average';
    ELSE SET @SalaryLevel = 'High';

    RETURN @SalaryLevel;
END

--Testing:
SELECT e.Salary, 
	  dbo.ufn_GetSalaryLevel(Salary) AS [Salary Level] 
  FROM Employees AS e
ORDER BY Salary

--6. Employees by Salary Level
CREATE PROC usp_EmployeesBySalaryLevel(@LevelOfSalary VARCHAR(10))
AS
    SELECT e.FirstName, e.LastName FROM Employees AS e
    WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @LevelOfSalary

-- Testing:
EXEC usp_EmployeesBySalaryLevel 'Low'

--7. Define Function
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
    DECLARE @counter INT = 1;
    DECLARE @currentLetter CHAR;

    WHILE(@counter <= LEN(@word))
    BEGIN 
	   SET @currentLetter = SUBSTRING(@word, @counter, 1);
	   DECLARE @match INT = CHARINDEX(@currentLetter, @setOfLetters);
	   
	   IF (@match = 0)
	   BEGIN 
		  RETURN 0;
	   END

	   SET @counter += 1;
    END
    RETURN 1;
END

--Testing:
SELECT dbo.ufn_IsWordComprised('oistmiahf', 'Sofia') AS Result

--8. Delete Employees and Departments
CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN 
    DELETE FROM EmployeesProjects
    WHERE EmployeeID IN (
	   SELECT EmployeeID 
	     FROM Employees
	    WHERE DepartmentID = @departmentId)

    ALTER TABLE Departments
    ALTER COLUMN ManagerId INT NULL;

    UPDATE Departments
       SET ManagerID = NULL
     WHERE ManagerID IN (
	   SELECT EmployeeID 
	     FROM Employees
	    WHERE DepartmentID = @departmentId)

    UPDATE Employees
       SET ManagerID = NULL
     WHERE ManagerID IN (
	   SELECT EmployeeID 
	     FROM Employees
	    WHERE DepartmentID = @departmentId)

    DELETE FROM Employees
    WHERE DepartmentID = @departmentId

    DELETE FROM Departments
    WHERE DepartmentID = @departmentId
    
    SELECT COUNT(*) FROM Employees
    WHERE DepartmentID = @departmentId
END

--Testing:
EXEC usp_DeleteEmployeesFromDepartment 1

--====================
--For Exercises 9 - 12
--use Bank
--====================
--9. Find Full Name
CREATE PROC usp_GetHoldersFullName
AS
    SELECT ah.FirstName + ' ' + ah.LastName AS [Full Name] FROM AccountHolders AS ah

--Testing:
EXEC usp_GetHoldersFullName

--10. People with Balance Higher Than
CREATE PROC usp_GetHoldersWithBalanceHigherThan (@minBalance money)
AS
BEGIN 
    WITH CTE_MinBalanceAccountHolders (HolderId) AS (
    SELECT AccountHolderId 
    FROM Accounts
    GROUP BY AccountHolderId
    HAVING SUM(Balance) > @minBalance
  )

    SELECT ah.FirstName AS [First Name], ah.LastName AS [Last Name]
    FROM CTE_MinBalanceAccountHolders AS minBalanceHolders 
    JOIN AccountHolders AS ah ON ah.Id = minBalanceHolders.HolderId
    ORDER BY ah.LastName, ah.FirstName 
END

--Testing:
EXEC usp_GetHoldersWithBalanceHigherThan 4000;
EXEC usp_GetHoldersWithBalanceHigherThan 2000000;
EXEC usp_GetHoldersWithBalanceHigherThan 100000;

--11. Future Value Function
CREATE FUNCTION ufn_CalculateFutureValue (@sum MONEY, @yearlyInterestRate FLOAT, @numberOfYears INT)
RETURNS MONEY
AS
BEGIN
    DECLARE @futureValue FLOAT;
    SET @futureValue = @sum * (POWER((1 + @yearlyInterestRate), @numberOfYears));
    RETURN @futureValue;
END

--Testing:
SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5) AS Output

--12. Calculating Interest
CREATE PROC usp_CalculateFutureValueForAccount(@accountId INT, @interestRate FLOAT)
AS
BEGIN
    DECLARE @yearsPeriod INT = 5;

    SELECT a.Id AS [Account Id], 
	      ah.FirstName AS [First Name], 
		 ah.LastName AS [Last Name],
		 a.Balance AS [Current Balance],
		 dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, @yearsPeriod) AS [Balance in 5 years]
		 FROM Accounts AS a
      JOIN AccountHolders AS ah ON ah.Id = a.AccountHolderId
	WHERE a.Id = @accountId
END

--Testing:
EXEC usp_CalculateFutureValueForAccount 1, 0.1

--================
--For Exercises 13
--use Diablo
--================
--13. *Cash in User Games Odd Rows
CREATE FUNCTION ufn_CashInUsersGames (@gameName NVARCHAR(Max))
RETURNS TABLE 
AS
RETURN SELECT SUM(Cash) AS SumCash FROM (
	  SELECT ug.Cash, ROW_NUMBER() OVER(ORDER BY Cash DESC) AS RowNum 
	    FROM UsersGames AS ug
	    JOIN Games AS g ON g.Id = ug.GameId
	    WHERE g.Name = @gameName) AS CashList
	    WHERE RowNum % 2 != 0

--Testing:
SELECT * FROM dbo.ufn_CashInUsersGames('Love in a mist')