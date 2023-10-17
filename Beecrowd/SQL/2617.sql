select a.name, b.name from products a
join providers b on a.id_providers = b.id
where b.name = 'Ajax SA'