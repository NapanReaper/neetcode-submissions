select customers.customer_id, customers.customer_name
from orders join customers on orders.customer_id = customers.customer_id
group by customers.customer_id
having count(*) filter (where orders.product_name ='A') > 0
and count(*) filter (where orders.product_name ='B') > 0
and count(*) filter (where orders.product_name ='C') =0
order by customers.customer_name