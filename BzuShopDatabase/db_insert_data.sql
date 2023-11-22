DELETE FROM Bills
DELETE FROM OrderProducts
DELETE FROM Orders
DELETE FROM Customers
DELETE FROM Products

--------------------------------
INSERT INTO Products(ID, Name, UnitPrice, StockQuantity)
VALUES(1, 'Sugar', 200, 20)

INSERT INTO Products(ID, Name, UnitPrice, StockQuantity)
VALUES(2, 'Rice', 300, 10)

INSERT INTO Products(ID, Name, UnitPrice, StockQuantity)
VALUES(3, 'Biskat', 20, 100)

SELECT * FROM Products

--------------------------------
INSERT INTO Customers(ID, Name, Phone, Address, Gender)
VALUES(1, 'Kamran Qadir', '0321', 'BZU Lodhran', 1)

SELECT * FROM Customers

--------------------------------
INSERT INTO Orders(ID, CustomerID, OrderTime, IsConfirmed)
VALUES(1, 1, CURRENT_TIMESTAMP, 1)

SELECT * FROM Orders

--------------------------------
DELETE FROM OrderProducts

INSERT INTO OrderProducts(ID, OrderID, ProductID, QuantityOrdered)
VALUES(1, 1, 1, 2)

INSERT INTO OrderProducts(ID, OrderID, ProductID, QuantityOrdered)
VALUES(2, 1, 2, 3)

INSERT INTO OrderProducts(ID, OrderID, ProductID, QuantityOrdered)
VALUES(3, 1, 3, 1)

SELECT * FROM OrderProducts

--------------------------------
DELETE FROM Bills

INSERT INTO Bills(ID, OrderID, Amount, BillTime, IsPaid)
VALUES(1, 1, 200, CURRENT_TIMESTAMP, 0)

SELECT * FROM Bills
