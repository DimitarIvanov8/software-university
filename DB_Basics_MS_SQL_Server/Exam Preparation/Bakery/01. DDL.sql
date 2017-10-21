CREATE TABLE Countries(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(50) UNIQUE
)

CREATE TABLE Customers(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(25),
	LastName NVARCHAR(25),
	Gender CHAR(1) CHECK(Gender = 'M' OR Gender= 'F'),
	Age INT,
	PhoneNumber CHAR(10),
	CountryId INT REFERENCES Countries(Id)
)

CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(25) UNIQUE,
	Description NVARCHAR(255),
	Recipe NVARCHAR(MAX),
	Price MONEY CHECK(Price>=0)
)

CREATE TABLE Feedbacks(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Description NVARCHAR(255),
	Rate DECIMAL(10,2) CHECK(Rate BETWEEN 0 AND 10),
	ProductId INT REFERENCES Products(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
)

CREATE TABLE Distributors(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(25) UNIQUE,
	AddressText NVARCHAR(30),
	Summary NVARCHAR(200),
	CountryId INT REFERENCES Countries(Id)
)

CREATE TABLE Ingredients(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(30),
	Description NVARCHAR(200),
	OriginCountryId INT REFERENCES Countries(Id),
	DistributorId INT REFERENCES Distributors(Id)
)

CREATE TABLE ProductsIngredients(
	ProductId INT,
	IngredientId INT 
	CONSTRAINT PK_ProductIDIngretientId PRIMARY KEY(ProductId, IngredientId),
	CONSTRAINT FK_IngredientId_Ingredients FOREIGN KEY (IngredientID) REFERENCES Ingredients(Id),
	CONSTRAINT FK_ProductId_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
)