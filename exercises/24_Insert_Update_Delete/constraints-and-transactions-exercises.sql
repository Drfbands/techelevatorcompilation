-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
   insert into actor (first_name, last_name) values ('hampton', 'avenue'), ('Lisa', 'Byway')
   select * from actor where first_name = 'hampton'
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
  insert into film (title, description, release_year, language_id, length) values('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 198)
  select * from film where title = 'Euclidean PI'
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
     select * from film where title = 'Euclidean PI' -- film_id 1002 
	 select * from actor where actor.first_name in ('Hampton', 'Lisa') and actor.last_name in ('Avenue', 'Byway') -- 201 = hampton, 202 = byway
	insert into film_actor (film_id, actor_id) values (1002, 201), (1002, 202)
	 select * from film_actor where film_id = 1002



-- 4. Add Mathmagical to the category table.
insert into category (name) values ( 'Mathmagical') 
select * from category


-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
    select * from film where title in ('Euclidean PI', 'EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE') 
	-- film_ids = 1002, 274, 494, 714, 996
	select * from category -- mathmagical = 17
	update film_category set category_id = 17 where film_id in (1002, 274, 494, 714, 996)
	insert into film_category(film_id, category_id) values (1002, 17)
	select * from film_category where category_id = 17

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
    select * from film
	select * from film_category where category_id = 17
	update film set film.rating = 'G' where film_id in (1002, 274, 494, 714, 996)
	select * from film  where film_id in (1002, 274, 494, 714, 996)



     

-- 7. Add a copy of "Euclidean PI" to all the stores.
    insert into inventory (film_id, store_id) values (1002, 1), (1002, 2) 
	select * from inventory where film_id = 1002


-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
  delete film where film_id = 1002
  -- It will not delete the film from the film table because it needs the film_id as a key. 

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

   delete category where name = 'Mathmagical'
  -- No Because it would breal your database design  

-- 10. Delete all links to Mathmagical in the film_category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE> 
   select * from film_category where film_id = 1002
   delete film_category where film_id in (1002, 274, 494, 714, 996)
   -- Yes because is in a join table. 

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
 delete category where category_id = 17
 -- Yes because we cut off the reference to the join table. 
 delete film where film_id = 1002
 -- The second one did not delete 


-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
   select * from film where film_id = 1002
   delete film where title = 'Euclidean PI' -- does not work at this point 
   delete film_actor where film_id = 1002 -- this deletes 
   delete film where title = 'Euclidean PI' -- This does not delete
   delete inventory where film_id = 1002  -- this deletes 
   delete film where title = 'Euclidean PI' -- this deletes 
   -- You have to delete all of the table keys that are referencing the film table because they all need to be deleted before you delete the film from the film table. 
