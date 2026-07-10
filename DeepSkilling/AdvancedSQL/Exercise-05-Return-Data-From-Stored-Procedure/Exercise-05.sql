DROP TABLE IF EXISTS Employee;

CREATE TABLE Employee
(
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
INSERT INTO Employees
(FirstName, LastName, DepartmentID, Salary, JoinDate)

VALUES
('John','Smith',101,55000,'2022-01-15'),
('Emma','Wilson',101,62000,'2021-05-20'),
('David','Brown',102,48000,'2023-02-10'),
('Sophia','Taylor',103,70000,'2020-08-18'),
('Michael','Johnson',102,51000,'2022-11-05'),
('Robert','Anderson',103,65000,'2025-08-10');

DELIMITER $$

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
(
    IN p_DepartmentID INT
)
BEGIN

    SELECT
        DepartmentID,
        COUNT(*) AS TotalEmployees

    FROM Employees

    WHERE DepartmentID = p_DepartmentID

    GROUP BY DepartmentID;

END $$

DELIMITER ;
CALL sp_GetEmployeeCountByDepartment(101);
CALL sp_GetEmployeeCountByDepartment(102);
CALL sp_GetEmployeeCountByDepartment(103);
SELECT * FROM Employees;