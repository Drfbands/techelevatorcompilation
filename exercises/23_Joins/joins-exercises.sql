-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
    select film.title, actor.first_name, actor.last_name
	from film 
	join film_actor on film.film_id = film_actor.film_id
	join actor on film_actor.actor_id = actor.actor_id
	where actor.first_name = 'Nick' and actor.last_name = 'Stallone' 

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
    select film.title, actor.first_name, actor.last_name
	from film 
	join film_actor on film.film_id = film_actor.film_id
	join actor on film_actor.actor_id = actor.actor_id
	where actor.first_name = 'Rita' and actor.last_name = 'Reynolds' 

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
    select film.title, actor.first_name, actor.last_name
	from film 
	join film_actor on film.film_id = film_actor.film_id
	join actor on film_actor.actor_id = actor.actor_id
	where actor.first_name in ('Judy', 'River') and actor.last_name = 'Dean'
-- 4. All of the the ‘Documentary’ films
-- (68 rows)
      select film.title, category.name
	  from film
	  join film_category on film.film_id =  film_category.film_id
	  join category on film_category.category_id = category.category_id
      where category.name = 'Documentary'
-- 5. All of the ‘Comedy’ films
-- (58 rows)
      select film.title, category.name
	  from film
	  join film_category on film.film_id =  film_category.film_id
	  join category on film_category.category_id = category.category_id
      where category.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
     select film.title, category.name, film.rating
	  from film
	  join film_category on film.film_id =  film_category.film_id
	  join category on film_category.category_id = category.category_id
      where category.name = 'Children' and film.rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
  select film.title, category.name, film.rating, film.length
	  from film
	  join film_category on film.film_id =  film_category.film_id
	  join category on film_category.category_id = category.category_id
      where category.name = 'Family' and film.rating = 'G' and film.length < 120
	  
	  
-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
    select film.title, actor.first_name, actor.last_name, film.rating
	from film 
	join film_actor on film.film_id = film_actor.film_id
	join actor on film_actor.actor_id = actor.actor_id
	where actor.first_name = 'Matthew' and actor.last_name = 'Leigh' and film.rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
     select film.title, category.name, film.release_year
	  from film
	  join film_category on film.film_id =  film_category.film_id
	  join category on film_category.category_id = category.category_id
      where category.name = 'Sci-Fi' and film.release_year = '2006'

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
    select film.title, actor.first_name, actor.last_name
	from film 
	join film_actor on film.film_id = film_actor.film_id
	join actor on film_actor.actor_id = actor.actor_id
	 join film_category on film.film_id =  film_category.film_id
	 join category on film_category.category_id = category.category_id
	 where actor.first_name = 'Nick' and actor.last_name = 'Stallone' and category.name = 'Action'

-- 11. The address of all stores, including street address, city, district, and country
 --(2 rows)
     select address.address, address.district, city.city, country.country
	 from store
	 join address on store.address_id = address.address_id 
	 join city on address.city_id = city.city_id 
	 join country on city.country_id = country.country_id


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
  select store.store_id, address.address_id, staff.first_name, staff.last_name
  from store 
  join staff on store.manager_staff_id = staff.staff_id 
  join address on staff.address_id = address.address_id 


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
     select top 10 count(rental.rental_id) as 'Rented Movies', customer.first_name, customer.last_name
	 from rental
	 join customer on rental.customer_id = customer.customer_id
	 group by customer.last_name, customer.first_name
	 order by 'Rented Movies' desc



-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
    select top 10 sum(payment.amount) as 'Total Paid', customer.first_name, customer.last_name
	 from customer
	 join payment on customer.customer_id  = payment.customer_id
	 group by customer.last_name, customer.first_name
	 order by 'total Paid' desc

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
      select top 10 film.title, count(rental.rental_date) as 'Number Rented' 
	  from rental 
	  join inventory on rental.inventory_id = inventory.inventory_id
	  join film on inventory.film_id = film.film_id
	  group by film.title 
	  order by 'Number Rented' desc
-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
      select top 5 category.name, category.name, count(rental.rental_date) as 'Number Rented' 
	  from rental
	  join inventory on rental.inventory_id = inventory.inventory_id
	  join film on inventory.film_id = film.film_id
	  join film_category on film.film_id = film_category.film_id
	  join category on film_category.category_id = category.category_id
	  group by category.name, film.title
	  order by 'Number Rented' desc

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
     select top 5 film.title, category.name, count(rental.rental_date) as 'Number Rented' 
	  from film 
	  join film_category on film.film_id = film_category.film_id 
	  join category on film_category.category_id = category.category_id
	  join inventory on film.film_id = inventory.film_id
	  join rental on inventory.inventory_id = rental.inventory_id
	  where category.name = 'Action'
	  group by category.name, film.title
	  order by 'Number Rented' desc

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
-- select * from actor where first_name in ('Gina', 'Sean') and last_name in ('DEGENERES', 'GUINESS;')  gina = 107 
select top 10 count(rental.rental_id) as total_rented, film_actor.actor_id from rental 
-- rental to inventory, to film , to film actor, get there ids first
left join inventory on rental.inventory_id = inventory.inventory_id
right join film on inventory.film_id = film.film_id
right join film_actor on film.film_id = film_actor.film_id
where actor_id = 107 
group by film_actor.actor_id
order by total_rented




-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
    select top 5 count(rental.rental_id) as total_rented, film_category.category_id, actor.first_name, actor.last_name from rental -- comedy = 5 
	-- need rental, inventory, film, film actor, to actor 
	left join inventory on rental.inventory_id = inventory.inventory_id
	right join film on inventory.film_id = film.film_id
	right join film_actor on film.film_id = film_actor.film_id
	right join actor on film_actor.actor_id = actor.actor_id 
	right join film_category on film.film_id = film_category.film_id
	where film_category.category_id = 5
	group by film_category.category_id, actor.last_name, actor.first_name 
	order by total_rented desc 


	

    

