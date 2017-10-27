3. Shopping Spree

Create two classes: class Person and class Product. Each person should have a name, money and a bag of products. Each product should have name and price. The name cannot be an empty string. The price cannot be negative or zero. 
Create a program in which each command corresponds to a person buying a product. If the person can afford a product, add it to his bag. If a person doesn’t have enough money, print an appropriate message ("[Person name] can't afford [Product name]").
On the first two lines, you are given all people and all products. After all purchases print every person in the order of appearance and all products that he has bought also in order of appearance. If nothing is bought, print the name of the person followed by "Nothing bought". 
In case of invalid input (negative money exception message: "Money cannot be negative"), empty name (empty name exception message: "Name cannot be empty") or an invalid price (invalid price exception message: "Price cannot be zero or negative") break the program with an appropriate message. See the examples below:

Examples
Input:
Pesho=11;Gosho=4
Bread=10;Milk=2;
Pesho Bread
Gosho Milk
Gosho Milk
Pesho Milk
END

Output:
Pesho bought Bread
Gosho bought Milk
Gosho bought Milk
Pesho can't afford Milk
Pesho - Bread
Gosho - Milk, Milk

Input:
Mimi=0
Kafence=2
Mimi Kafence
END

Output:
Mimi can't afford Kafence
Mimi – Nothing bought

Input:
Jeko=-3
Chushki=1;
Jeko Chushki
END

Output:
Money cannot be negative
