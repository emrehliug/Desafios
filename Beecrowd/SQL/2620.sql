select a.name, b.id 
from customers a
join orders b on a.id = b.id_customers
and b.orders_date between '2016-01-01' and '2016/06/30'