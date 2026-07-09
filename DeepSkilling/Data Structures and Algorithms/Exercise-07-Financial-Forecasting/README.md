# Exercise 07 - Financial Forecasting using Recursion

## Objective

Develop a financial forecasting application using recursion to predict future investment values based on annual growth rates.

## Scenario

A financial organization wants to estimate the future value of an investment using historical growth rates. The solution demonstrates recursion as an approach to solving repetitive calculations.

## Concepts Covered

* Recursion
* Base Case
* Recursive Calls
* Time Complexity Analysis
* Space Complexity
* Optimization Techniques

## Files

* FinancialForecast.cs
* Program.cs

## Algorithm

1. Accept the current investment value.
2. Accept the annual growth rate.
3. Accept the number of forecast years.
4. Recursively calculate the future value by applying the growth rate each year.
5. Display the predicted value.

## Complexity Analysis

### Time Complexity

O(n)

The recursive function executes once for each year.

### Space Complexity

O(n)

The recursive call stack grows with the number of years.

## Optimization

* Use Memoization when overlapping subproblems exist.
* Use an iterative approach to eliminate recursion overhead.

## Sample Output

Current Value : ₹10000

Growth Rate : 10%

Years : 5

Predicted Future Value : ₹16105.10

Time Complexity : O(n)

Space Complexity : O(n)
