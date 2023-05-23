SELECT ci.city_id, ci.country_id, ci.last_update 
FROM country co 
inner join city ci on co.country_id = ci.country_id;

SELECT ci.city_id, ci.country_id, ci.last_update 
FROM country co 
inner join city ci on co.country_id = ci.country_id
where ci.country_id=2;