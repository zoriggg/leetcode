-- Write your PostgreSQL query statement below
select
    d.name as Department,
    e.name as Employee,
    e.salary
from
    Employee e
    left join Department d on e.departmentId = d.id
where
    e.salary in
    (
        select distinct
            ee.salary 
        from 
            Employee ee
        where
            ee.departmentId = e.departmentId
        order by
            ee.salary desc
        limit 3
    )

