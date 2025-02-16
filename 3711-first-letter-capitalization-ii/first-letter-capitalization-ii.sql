-- Write your PostgreSQL query statement below
select
    uc.content_id,
    uc.content_text as original_text,
    string_agg(coalesce(ttt.id, tt.id), ' ') as converted_text
from 
    user_content as uc
    left join lateral
    (
        select UPPER(SUBSTRING(id FROM 1 FOR 1)) || lower(SUBSTRING(id FROM 2 FOR LENGTH(id))) as id from unnest(string_to_array(uc.content_text, ' ')) as id
    ) as tt on true
    left join lateral
    (
        select 
            case when tt.id ilike '%-%' 
                then SUBSTRING(tt.id FROM 1 FOR position('-' in tt.id)) 
                    || UPPER(SUBSTRING(tt.id FROM position('-' in tt.id) + 1 FOR 1))
                    || SUBSTRING(tt.id FROM position('-' in tt.id) + 2 FOR LENGTH(id))
            end as id
    ) as ttt on true
group by
    uc.content_id,
    uc.content_text
order by
    uc.content_id