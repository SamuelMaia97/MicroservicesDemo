-- Create ProductServiceDB and Products table
CREATE DATABASE ProductService;
GO

USE ProductService;
GO

CREATE TABLE Products (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(255) NOT NULL,
    [Price] DECIMAL(18,2) NOT NULL
);
GO

INSERT INTO Products (Name, Price)
VALUES 
    ('Laptop', 1200.50),
    ('Smartphone', 799.99),
    ('Headphones', 199.99);
GO

-- Create OrderServiceDB and Orders table
CREATE DATABASE OrderService;
GO

USE OrderService;
GO

CREATE TABLE Orders (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [ProductId] INT NOT NULL,       
    [ProductName] NVARCHAR(255),  
    [ProductPrice] DECIMAL(18,2), 
    [Quantity] INT NOT NULL,
    [TotalAmount] DECIMAL
);
GO

-- Insert initial data into the Orders table
INSERT INTO Orders (ProductId, ProductName, ProductPrice, Quantity, TotalAmount)
VALUES
    (1, 'Laptop', 1200.50, 2, 2401.00),  -- Order 2 Laptops
    (2, 'Smartphone', 799.99, 1, 799.99),  -- Order 1 Smartphone
    (3, 'Headphones', 199.99, 5, 999.95);  -- Order 5 Headphones
GO
