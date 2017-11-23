0.	Book Shop Database
 
Constraints
Your namespaces should be:
•	BookShop.StartUp – for your StartUp class
•	BookShop.Data – for your DbContext
•	BookShop.Models – for your models

Your models should be:
•	BookShopContext – your DbContext
•	Author:
	AuthorId
	FirstName (up to 50 characters, unicode, not required)
	LastName (up to 50 characters, unicode)
	
•	Book:
	BookId
	Title (up to 50 characters, unicode)
	Description (up to 1000 characters, unicode)
	ReleaseDate (not required)
	Copies (an integer)
	Price
	EditionType – enum (Normal, Promo, Gold)
	AgeRestriction – enum (Minor, Teen, Adult)
	Author
	BookCategories
	
•	Category:
	CategoryId
	Name (up to 50 characters, unicode)
	CategoryBooks
	
•	BookCategory – mapping class
For the following tasks, you will be creating methods that accept a BookShopContext as a parameter and use it to run some queries. Create those methods inside your StartUp class and upload your whole solution to Judge.
