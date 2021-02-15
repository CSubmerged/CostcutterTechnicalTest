#2. The total value of all invoices settled in April 2020
SELECT SUM(invoice_value)
FROM practicaltest.invoices
WHERE settlement_date BETWEEN '2020/04/01' AND '2020/05/01';
# BETWEEN is inclusive for the first date, but exclusive for the second