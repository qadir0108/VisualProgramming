-- 1. Today's All Confirmed Orders
SELECT o.* FROM 
Orders o
WHERE 
CAST(o.OrderTime AS DATE) = '2023-11-23'
AND o.IsConfirmed = 1

-- 2. Customer Name with Bill Amount of Today's orders
SELECT c.Name, b.Amount FROM 
Orders o, Customers c, Bills b
WHERE o.CustomerID = c.ID
AND o.ID = b.OrderID
AND CAST(o.OrderTime AS DATE) = '2023-11-23'

-- 3. Customer Name whose bills are not paid with bill amount
SELECT c.Name, b.Amount FROM 
Orders o, Customers c, Bills b
WHERE o.CustomerID = c.ID
AND o.ID = b.OrderID
AND b.IsPaid = 0

-- 4. Which products sold today with quantity sold
SELECT p.Name, op.QuantityOrdered FROM 
Orders o, OrderProducts op, Products p
WHERE o.ID = op.OrderID
AND op.ProductID = p.ID
AND CAST(o.OrderTime AS DATE) = '2023-11-23'