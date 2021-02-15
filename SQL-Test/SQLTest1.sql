# 1. Write a query to list all of the orders placed by customers with the surname “Walker”
SELECT o.order_number #, o.customer_number, c.forename, c.surname 
FROM practicaltest.orders o
INNER JOIN 
	(SELECT customer_number, forename, surname 
    FROM practicaltest.customers
	WHERE surname = "Walker") c 
ON (c.customer_number = o.customer_number);