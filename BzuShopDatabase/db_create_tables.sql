DROP TABLE Bills
DROP TABLE OrderProducts
DROP TABLE Orders
DROP TABLE Products
DROP TABLE Customers

CREATE TABLE Customers (
    [ID] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[Phone] [nchar](10) NULL,
	[Address] [varchar](max) NULL,
	[Gender] [int] NULL,
    PRIMARY KEY (ID),
);

CREATE TABLE Products (
    [ID] [int] NOT NULL,
	[Name] [nchar](100) NULL,
	[UnitPrice] [decimal](18, 0) NULL,
	[StockQuantity] [int] NULL,
    PRIMARY KEY (ID),
);

CREATE TABLE Orders (
    ID int NOT NULL,
    CustomerID INT,
	OrderTime DATETIME,
	IsConfirmed INT
    PRIMARY KEY (ID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(ID)
);


CREATE TABLE OrderProducts (
	ID int NOT NULL,
    OrderID int NOT NULL,
    ProductID INT NOT NULL,
	QuantityOrdered INT
    PRIMARY KEY (ID),
	FOREIGN KEY (OrderID) REFERENCES Orders(ID),
    FOREIGN KEY (ProductID) REFERENCES Products(ID),
);


CREATE TABLE Bills (
	ID int NOT NULL,
    OrderID int NOT NULL,
    Amount INT NOT NULL,
    BillTime DATETIME,
	IsPaid INT
	PRIMARY KEY (ID),
	FOREIGN KEY (OrderID) REFERENCES Orders(ID),
);

