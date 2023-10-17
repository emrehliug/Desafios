select a.name, c.name, a.price 
from products a
join categories b on a.id_categories = b.id
join providers c on a.id_providers = c.id
where a.price > 1000 and b.name = 'Super Luxury'