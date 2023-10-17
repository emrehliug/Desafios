select a.name, round(sum((b.hours*150)+((b.hours*150)*(w.bonus*0.01))),1) as salary 
from doctors a
join attendances b on a.id = b.id_doctor
join work_shifts w on b.id_work_shift = w.id 
    group by a.name
    order by salary desc
