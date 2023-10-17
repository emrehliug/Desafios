SELECT a.name, round((((b.math*2) + (b.specific*3) + (b.project_plan*5))/10),2) as avg
FROM candidate a
JOIN score b ON a.id = b.candidate_id
ORDER BY avg desc