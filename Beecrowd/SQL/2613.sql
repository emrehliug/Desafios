select a.id, a.name 
from movies a
join prices b on a.id_prices = b.id
and b.value < 2.00