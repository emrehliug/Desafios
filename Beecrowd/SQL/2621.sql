select a.name
from products a
join providers b on a.id_providers = b.id
where a.amount between 10 and 20
and b.name like 'P%'