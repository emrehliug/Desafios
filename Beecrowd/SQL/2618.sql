select a.name, c.name, b.name 
from products a
join categories b on a.id_categories = b.id
join providers c on a.id_providers = c.id
where c.name = 'Sansul SA' and b.name = 'Imported'