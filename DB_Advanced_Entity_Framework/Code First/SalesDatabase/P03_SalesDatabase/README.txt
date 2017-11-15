Sales Database

Create a database for storing data about sales using the Code First approach. 

Your namespaces should be:
•	P03_SalesDatabase
•	P03_SalesDatabase.Data
•	P03_SalesDatabase.Data.Models

Your classes should be:
•	SalesContext – your DbContext
•	Product:
ProductId
Name (up to 50 characters, unicode)
Quantity (real number)
Price
Sales

•	Customer:
CustomerId
Name (up to 100 characters, unicode)
Email (up to 80 characters, not unicode)
CreaditCardNumber (string)
Sales

•	Store:
StoreId
Name (up to 80 characters, unicode)

Sales
•	Sale:
SaleId
Date
Product
Customer
Store

*Products Migration
For table Products add string column Description, up to 250 symbols. Use migrations. The migration should be named: "ProductsAddColumnDescription". Add a default value for the description property: "No description".

*Sales Migration
For table Sales make Date column with default value GETDATE() function, called from the database, not the application. Use explicit migration. Do not use DateTime.Now! Name the migration “SalesAddDateDefault”.
After that, open your table data and see if the default value is applied or not.
Keep your namespaces from Task 3 and do both Task 4 and Task 5 before testing your project in Judge. Make sure to upload your migrations too!


