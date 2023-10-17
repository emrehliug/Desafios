select a.id, a.name from products a
join categories b on a.id_categories = b.id
where b.name like 'super%'