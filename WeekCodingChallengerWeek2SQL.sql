CREATE TABLE Products
(
	ID int NOT NULL PRIMARY KEY,
	Name VarChar (30),
	Price Money
);
GO

CREATE TABLE Customers
(
	ID int NOT NULL PRIMARY KEY,
	FirstName varchar(60),
	LastName varchar(60),
	CardNumber int
);
GO

CREATE TABLE ORDERS
(
	ID int NOT NULL PRIMARY KEY,
	ProductID int FOREIGN KEY REFERENCES Products(ID),
	CustomerID int FOREIGN KEY REFERENCES Customers(ID)
);
GO

INSERT INTO Products (ID,Name,Price)
	VALUES 
(1, 'Jewelry',100.88)
GO

INSERT INTO Products (ID,Name,Price)
	VALUES 
((SELECT Max(ID)+1 FROM Products), 'Electronic', 30.10)
GO

INSERT INTO Products (ID,Name,Price)
	VALUES 
((SELECT Max(ID)+1 FROM Products), 'Bed', 39.99)
GO

SELECT*
FROM Products;

INSERT INTO Customers (ID,FirstName,LastName,CardNumber)
	VALUES 
(1, 'Bob','Boodle',69)
GO

INSERT INTO Customers (ID,FirstName,LastName,CardNumber)
	VALUES 
((SELECT Max(ID)+1 FROM Customers), 'Sally','Seashells', (SELECT Max(CardNumber)+17 FROM Customers))
GO

INSERT INTO Customers (ID,FirstName,LastName,CardNumber)
	VALUES 
((SELECT Max(ID)+1 FROM Customers), 'George','Gungle', (SELECT Max(CardNumber)+7 FROM Customers))
GO

SELECT*
FROM Customers;

INSERT INTO Orders (ID,ProductID,CustomerID)
	VALUES 
(1, 1, 1)
GO

INSERT INTO Orders (ID,ProductID,CustomerID)
	VALUES 
((SELECT Max(ID)+1 FROM Orders), (SELECT Max(ProductID)+1 FROM Orders), (SELECT Max(CustomerID)+1 FROM Orders))
GO

INSERT INTO Orders (ID,ProductID,CustomerID)
	VALUES 
((SELECT Max(ID)+1 FROM Orders), (SELECT Max(ProductID)+1 FROM Orders), (SELECT Max(CustomerID)+1 FROM Orders))
GO

SELECT*
FROM Orders;


--
--


INSERT INTO Products (ID,Name,Price)
	VALUES 
((SELECT Max(ID)+1 FROM Products), 'iPhone', 200)
GO

INSERT INTO Customers (ID,FirstName,LastName,CardNumber)
	VALUES 
((SELECT Max(ID)+1 FROM Customers), 'Tina','Smith', (SELECT Max(CardNumber)+7 FROM Customers))
GO

INSERT INTO Orders (ID,ProductID,CustomerID)
	VALUES 
(4, 4, 4)
GO

SELECT FirstName, ProductID, Name
FROM (
Customers
INNER JOIN Orders
ON Customers.ID = Orders.CustomerID
INNER JOIN Products
ON Orders.ProductID = Products.ID
)
WHERE FirstName = 'Tina';


SELECT SUM(Price) as 'TotalRevenue'
FROM Products
INNER JOIN Orders
ON Products.ID = Orders.ProductID
WHERE Name='iPhone';

UPDATE Products
SET Price = 250
WHERE Name = 'iPhone';

SELECT*
FROM Products;