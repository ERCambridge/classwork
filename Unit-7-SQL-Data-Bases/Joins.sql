--
-- This SQL uses the vegas database 
--
-- show the gambler_name, casino_name and  the type of room they stay in 

-- we need data from
--gambler table (gambler_name) 
--host table (casino_name, room_type )
--
-- Whenever data is required in the result from more than one table use a join
--
-- A join will return matching rows between tables
--
-- There must be a common value that can be used to match data between the tables
--    the names of the columns don't have to match, but content must match
--
-- if columns names are not unique between the tables, put tablename. front of the column name
--
-- The join-condition is what matches between the tables
--
-- The order of the tables for the join doesn't matter - data base managers figures out what to do
--
-- There are two formats for coding a join:
--
--      1. Classic syntax - code all tables for the join on the FROM
--                               and the join condition on the WHERE
--                          only an INNER JOIN may be done
--                          Works if you forget the join condition(s) - not correctly (not a join) but it runs
--                          if you forget the join condition result is a Cartersian Product
--                             (each row from one table is produced for every row in the other)
--                             (the number of rows in the results = #-rows-in-one-table * #-rows-in-other)
--                             (if you try to join a 1000 row table to a 1000 row table without
--                                 a join condition you will get 1000000 rows in the result)
--                             (since join is used to show matching data between tables, a Cartersian product is NOT a join)
--
--      2. Modern syntax - code the type of join bewteen the tables instead of a comma
--                              and the join conditionis coded on an ON statement not WHERE
--                         any type of join may be done
--                         error if you forget the join condition(s)
--
--
----------------------------------------------------------------------------------------
-- Classic Syntax join
----------------------------------------------------------------------------------------
select gambler_name
	,casino_name
	,room_type
from gambler, host
where gambler.id = host.id 
----------------------------------------------------------------------------------------
-- Modern Syntax join
----------------------------------------------------------------------------------------                                            
select gambler_name
	,casino_name
	,room_type
from gambler
inner join host on gambler.id = host.id 
                   
                   
 -- show the gambler_name, casino_name and  the type of room they stay in and location

-- we need data from
--gambler table (gambler_name) 
--host table (casino_name, room_type )  
-- casino table (location)

----------------------------------------------------------------------------------------
-- Classic Syntax join
----------------------------------------------------------------------------------------
select gambler_name
	,host.casino_name
	,location
	,room_type
from gambler, host, casino
where gambler.id = host.id 
and host.casino_name = casino.casino_name
----------------------------------------------------------------------------------------
-- Modern Syntax join
----------------------------------------------------------------------------------------                                            
select gambler_name
	,host.casino_name
	,location
	,room_type
from gambler
inner join host 
on gambler.id = host.id 
inner join casino 
on casino.casino_name = host.casino_name
              
		
-- a correlation name maybe be assigned to a table to make it easier to reference in the sql 
-- to code a correlation name add it after the table name and can be used to reference the table 
select gambler_name
	,h.casino_name
	,location
	,room_type
from gambler g -- correlation name
inner join host h
on g.id = h.id 
inner join casino 
on casino.casino_name = h.casino_name
                   
                                             
                                             