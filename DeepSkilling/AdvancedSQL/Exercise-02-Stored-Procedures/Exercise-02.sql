CREATE TABLE Employee
(
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
INSERT INTO Employee
(FirstName, LastName, DepartmentID, Salary, JoinDate)

VALUES
('John','Smith',101,55000,'2022-01-15'),
('Emma','Wilson',101,62000,'2021-05-20'),
('David','Brown',102,48000,'2023-02-10'),
('Sophia','Taylor',103,70000,'2020-08-18'),
('Michael','Johnson',102,51000,'2022-11-05');
DELIMITER $$

CREATE PROCEDURE sp_GetEmployeeByDepartment(
    IN p_DepartmentID INT
)
BEGIN
    SELECT
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employee
    WHERE DepartmentID = p_DepartmentID;
END $$

DELIMITER ;
CALL sp_GetEmployeeByDepartment(101);
DELIMITER $$

CREATE PROCEDURE sp_InsertEmployee
(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        p_FirstName,
        p_LastName,
        p_DepartmentID,
        p_Salary,
        p_JoinDate
    );
END $$

DELIMITER ;
CALL sp_InsertEmployee
(
    'Robert',
    'Anderson',
    103,
    65000,
    '2025-08-10'
);
SELECT * FROM Employees;