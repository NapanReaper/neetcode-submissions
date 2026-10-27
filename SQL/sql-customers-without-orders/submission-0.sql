select customers.name
from customers LEFT JOIN orders ON customers.id = orders.customer_id
where orders.customer_id is null