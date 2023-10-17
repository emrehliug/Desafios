select a.id, a.name 
from movies a 
join genres b on a.id_genres = b.id
where b.description in ('Action')