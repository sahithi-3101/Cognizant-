-- ===========================================
-- Exercise 1 : Ranking and Window Functions
-- ===========================================

-- Create Products Table

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Insert Sample Data

INSERT INTO Products VALUES
(1,'Laptop','Electronics',85000),
(2,'Smartphone','Electronics',60000),
(3,'Tablet','Electronics',60000),
(4,'Headphones','Electronics',5000),
(5,'Office Chair','Furniture',12000),
(6,'Dining Table','Furniture',30000),
(7,'Sofa','Furniture',30000),
(8,'Bookshelf','Furniture',9000),
(9,'Mixer','Appliances',4500),
(10,'Refrigerator','Appliances',35000),
(11,'Microwave','Appliances',15000),
(12,'Washing Machine','Appliances',35000);

-------------------------------------------------------
-- ROW_NUMBER()
-------------------------------------------------------

SELECT
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Row_Num
FROM Products;

-------------------------------------------------------
-- RANK()
-------------------------------------------------------

SELECT
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Rank_Num
FROM Products;

-------------------------------------------------------
-- DENSE_RANK()
-------------------------------------------------------

SELECT
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Dense_Rank
FROM Products;

-------------------------------------------------------
-- Top 3 Most Expensive Products
-------------------------------------------------------

SELECT *
FROM
(
    SELECT
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RN
    FROM Products
) RankedProducts
WHERE RN <= 3;