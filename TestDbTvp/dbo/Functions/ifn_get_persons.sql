
CREATE FUNCTION ifn_get_persons
(	
	@ids ListOfLong READONLY
    
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * from Person
	where Id in (select item from @ids)
)