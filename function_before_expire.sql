CREATE FUNCTION before_expire( 
@ncontracte INT)

RETURNS INT
AS

BEGIN
	RETURN (SELECT c.cod_contracte
			FROM contracte c
			WHERE c.cod_contracte = @ncontracte AND
			DATEDIFF(DAY, c.fecha_ultima_modificaio, GETDATE()) >= 360)
END


