# Exercise 01 - Ranking and Window Functions

## Objective

Learn and implement SQL Window Functions to rank products within each category based on price.

## Concepts Covered

* ROW_NUMBER()
* RANK()
* DENSE_RANK()
* OVER()
* PARTITION BY
* ORDER BY

## Scenario

An e-commerce company wants to identify the top three most expensive products in each category.

## Implementation

The solution demonstrates:

* Assigning unique row numbers using ROW_NUMBER().
* Ranking products while handling ties using RANK().
* Ranking products without gaps using DENSE_RANK().
* Partitioning records by Category.
* Sorting each category by Price in descending order.

## Time Complexity

Sorting dominates the execution.

Overall Complexity: O(n log n)

## Learning Outcome

This exercise demonstrates how SQL Window Functions simplify ranking, reporting, and analytical queries without requiring complex subqueries.

## Files

* Exercise-01.sql
* README.md
* Output.png (Optional)
