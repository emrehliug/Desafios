Select a.name, b.name 
from providers b
join products a on a.id_providers = b.id
where id_categories = 6