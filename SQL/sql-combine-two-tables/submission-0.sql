-- Write your query below
select person.first_name, person.last_name, address.city, address.state
from address right join person on address.person_id = person.person_id