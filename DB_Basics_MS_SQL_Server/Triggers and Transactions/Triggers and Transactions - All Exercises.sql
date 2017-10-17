--===================
--For Exercises 1 - 5
USE Bank
--===================
--1. Create Table Logs
CREATE TABLE Logs (
    LogId INT IDENTITY PRIMARY KEY,
    AccountId INT NOT NULL,
    OldSum DECIMAL (15, 2),
    NewSum DECIMAL (15, 2)
)

CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
BEGIN
    DECLARE @accountId INT = (SELECT Id FROM inserted);
    DECLARE @oldSum DECIMAL(15, 2) = (SELECT Balance FROM deleted);
    DECLARE @newSum DECIMAL(15,2) = (SELECT Balance FROM inserted);

    IF(@oldSum != @newSum)
    BEGIN
	   INSERT INTO Logs (AccountId, OldSum, NewSum) 
	   VALUES
	   (@accountId, @oldSum, @newSum)
    END
END

--Testing:
UPDATE Accounts
SET Balance += 10
WHERE Id = 1

SELECT * FROM Logs

--2. Create Table Emails
CREATE TABLE NotificationEmails (
    Id INT PRIMARY KEY IDENTITY,
    Recipient INT,
    [Subject] NVARCHAR(MAX),
    Body NVARCHAR(MAX)
)

CREATE TRIGGER tr_LogsUpdate ON Logs FOR INSERT
AS
BEGIN
    DECLARE @oldBalance DECIMAL(15, 2) = (SELECT OldSum FROM inserted);
    DECLARE @newBalance DECIMAL(15, 2) = (SELECT NewSum FROM inserted);
    DECLARE @recipient INT = (SELECT AccountId FROM inserted);
    DECLARE @subject NVARCHAR(MAX) = CONCAT('Balance change for account: ', @recipient);
    DECLARE @body NVARCHAR(MAX) = CONCAT('On ', GETDATE(), ' your balance was changed from ',
    @oldBalance, ' to ', @newBalance, '.');

    INSERT INTO NotificationEmails (Recipient, [Subject], Body) 
    VALUES 
    (@recipient, @subject, @body)
END

--Testing:
UPDATE Accounts
SET Balance += 10
WHERE Id = 1

SELECT * FROM NotificationEmails

--3. Deposit Money
CREATE PROC usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(15, 4))
AS
BEGIN
    BEGIN TRANSACTION
    UPDATE Accounts
    SET Balance += @MoneyAmount
    WHERE Id = @AccountId
    
    IF @@ROWCOUNT <> 1
    BEGIN
	   ROLLBACK;
	   RAISERROR('Invalid Account', 16, 1);
	   RETURN;
    END
    COMMIT;
END

--Testing:
EXEC usp_DepositMoney 1, 7
SELECT * FROM Accounts

--4. Withdraw Money Procedure
CREATE PROC usp_WithdrawMoney (@AccountId INT, @MoneyAmount DECIMAL(15, 4))
AS
BEGIN
    BEGIN TRANSACTION
    UPDATE Accounts
    SET Balance -= @MoneyAmount
    WHERE Id = @AccountId

    IF (@@ROWCOUNT <> 1)
      BEGIN
	   ROLLBACK;
	   RAISERROR('Invalid account!', 16, 1);
	   RETURN;
      END

    IF (@MoneyAmount < 0)
      BEGIN
	   ROLLBACK;
	   RAISERROR('Amount should not be negative.', 16, 2)
	   RETURN;
	 END
    COMMIT;
END

--Testing:
EXEC usp_WithdrawMoney 1, 2
SELECT * FROM Accounts

--5. Money Transfer
CREATE OR ALTER PROC usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(15,4))
AS
BEGIN
    BEGIN TRANSACTION
    EXEC dbo.usp_WithdrawMoney @SenderId, @Amount;
    IF (@@ERROR <> 0)
    BEGIN
	   ROLLBACK;
	   RETURN;
    END;
    EXEC dbo.usp_DepositMoney @ReceiverId, @Amount;
    IF (@@ERROR <> 0)
    BEGIN
	   ROLLBACK;
	   RETURN;
    END;
    COMMIT;
END

--Testing:
EXEC usp_TransferMoney 1, 2, -5
SELECT * FROM Accounts

--===================
--For Exercise 7
USE Diablo
--For Exercises 8 - 9
USE SoftUni
--===================
--7. *Massive Shopping
DECLARE @userId INT = (SELECT Id FROM Users WHERE Username = 'Stamat') 
DECLARE @gameId INT = (SELECT Id FROM Games WHERE [Name] = 'Safflower')
DECLARE @userGameId INT = (SELECT Id FROM UsersGames WHERE UserId = @userId AND GameId = @gameId)

BEGIN TRY
BEGIN TRANSACTION
    UPDATE UsersGames
    SET Cash -= (SELECT SUM(Price) FROM Items WHERE MinLevel IN (11, 12))
    WHERE Id = @userGameId;
    DECLARE @userBalance DECIMAL(15,4) = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)
    IF (@userBalance < 0)
    BEGIN
	   ROLLBACK;
    END
    INSERT INTO UserGameItems
    SELECT Id, @userGameId FROM Items WHERE MinLevel IN (11, 12)
COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
END CATCH

BEGIN TRY
BEGIN TRANSACTION
    UPDATE UsersGames
    SET Cash -= (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN 19 AND 21)
    WHERE Id = @userGameId;
    SET @userBalance = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)
    IF (@userBalance < 0)
    BEGIN
	   ROLLBACK;
    END
    INSERT INTO UserGameItems
    SELECT Id, @userGameId FROM Items WHERE MinLevel BETWEEN 19 AND 21
COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
END CATCH

SELECT i.[Name] AS [Item Name]
FROM Items AS i
JOIN UserGameItems AS u ON i.Id = u.ItemId 
WHERE u.UserGameId = @userGameId
ORDER BY [Item Name]

--8. Employees with Three Projects
CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN
  BEGIN TRANSACTION
    INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
    VALUES
    (@emloyeeId, @projectID)
        
    DECLARE @projectNumber INT = (SELECT COUNT(*) FROM EmployeesProjects
    WHERE EmployeeID = @emloyeeId);

    IF (@projectNumber > 3)
    BEGIN
      RAISERROR('The employee has too many projects!', 16, 1);
	 ROLLBACK;
	 RETURN;
    END
  COMMIT;
END

--Testing:
EXEC usp_AssignProject 263, 41

SELECT * FROM EmployeesProjects
WHERE EmployeeID = 263

--9. Delete Employees
CREATE TABLE Deleted_Employees
(
EmployeeId INT PRIMARY KEY IDENTITY, 
FirstName VARCHAR(50) NOT NULL, 
LastName VARCHAR(50) NOT NULL, 
MiddleName VARCHAR(50), 
JobTitle VARCHAR(50) NOT NULL, 
DepartmentId INT FOREIGN KEY
    REFERENCES Departments(DepartmentID),
Salary DECIMAL(15, 4) 
) 

CREATE TRIGGER tr_FireEmployee ON Employees AFTER DELETE
AS
BEGIN
    INSERT INTO Deleted_Employees
    SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentID, Salary 
    FROM deleted
END

--Testing:
INSERT INTO Employees (FirstName, LastName, MiddleName, JobTitle, DepartmentID, ManagerID, HireDate, Salary, AddressID)
SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentID, ManagerID, HireDate, Salary, AddressID
FROM Employees
WHERE EmployeeID = 1

DELETE FROM Employees
WHERE EmployeeId = 295

SELECT * FROM Deleted_Employees
		