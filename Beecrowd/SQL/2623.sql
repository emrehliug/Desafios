select a.name, b.name 
from products a 
join categories b on a.id_categories = b.id
and a.amount > 100
and b.id in (1,2,3,6,9)
order by b.id asc