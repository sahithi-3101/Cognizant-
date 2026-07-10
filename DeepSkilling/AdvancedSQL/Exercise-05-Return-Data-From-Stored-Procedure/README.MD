# Exercise 05 - Return Data from a Stored Procedure

## Objective

Create a stored procedure that returns the total number of employees in a specified department.

## Concepts Covered

* Stored Procedures
* Parameters
* COUNT() Aggregate Function
* GROUP BY
* SQL Server (T-SQL)

## Scenario

A company's HR department needs a reusable database object that quickly returns the number of employees working in any department.

## Stored Procedure

**sp_GetEmployeeCountByDepartment**

### Input Parameter

* DepartmentID

### Output

Returns:

* Department ID
* Total Number of Employees

## SQL Features Used

* CREATE PROCEDURE
* SELECT
* COUNT()
* WHERE
* GROUP BY
* EXEC

## Benefits

* Reusable SQL code
* Improved performance
* Easy maintenance
* Better security
* Simplified reporting

## Sample Output

DepartmentID : 101

TotalEmployees : 2

## Learning Outcome

This exercise demonstrates how stored procedures can be used to encapsulate business logic and return summarized information efficiently.
