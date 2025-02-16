select
    t.id,
    t.visit_date,
    t.people
from
    (    
        select 
            row_number() over(order by s.id) as row_n,
            s.id,
            s.visit_date,
            s.people
        from
            Stadium s 
        where
            s.people >= 100
    ) as t
    join 
    (
        select
            tt.nn
        from
            (
                select
                    t.id,
                    t.id - row_n as nn
                from
                (    
                    select 
                        row_number() over(order by s.id) as row_n,
                        s.id
                    from
                        Stadium s 
                    where
                        s.people >= 100
                ) as t
            ) as tt
        group by
            tt.nn
        having 
            count(id) >= 3
    ) as ttt on (t.id - row_n) = ttt.nn