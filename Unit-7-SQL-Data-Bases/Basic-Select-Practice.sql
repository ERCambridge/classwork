-- Practice Basic SQL
--
-- List all entries in the casino table
select * 
from casino
-- Show the location and name each casino
select location, casino_name 
from casino
-- List all Vegas casinos
select * 
from casino 
where location = 'Las Vegas'
-- List all casinos whose size is more than 30000
select * 
from casino
where size > 30000
-- Show the size of Vegas casinos if we double the size
select casino_name, size, size * 2 as 'double size'
from casino 
where location = 'Las Vegas'
--List Gamblers with oldest ones first
select *
from gambler 
order by birth_date 