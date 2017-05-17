
CREATE FUNCTION ifn_get_persons2()
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * from Person
)