select b.name, SUM(a.amount)
from products a
inner join categories b on a.id_categories = b.id
group by b.name