select trunc((sum(price) / count(price)),2) as price 
from products