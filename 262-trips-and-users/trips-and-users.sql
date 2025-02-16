-- Write your PostgreSQL query statement below
select
    t.request_at as Day,
    round(count(case when t.status='cancelled_by_driver' then t.id
                 when t.status='cancelled_by_client' then t.id end)::numeric / count(t.id), 2) as "Cancellation Rate"
from
    trips t
    left join users d on t.driver_id = d.users_id
    left join users c on t.client_id = c.users_id
where
    d.banned = 'No'
    and c.banned = 'No'
    and t.request_at between '2013-10-01' and '2013-10-03'
group by
    t.request_at