CREATE PROC pc_exp_contracte 
@ncontracte INT
as 
BEGIN

DELETE FROM contracte WHERE DATEDIFF(DAY, fecha_ultima_modificaio, GETDATE()) >= 365 AND cod_contracte = @ncontracte

 END
