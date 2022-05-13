CREATE PROC pc_buscarEmpresa 
@condicion VARCHAR(max)
as 
BEGIN
DECLARE @query NVARCHAR(4000)
SET @query = 'SELECT  e.cif, e.nom, e.adreca, e.cp, e.ciutat, e.regio, e.pais, e.telf, e.email, c.descripcio AS categoria, 
COUNT(at.num_albara) AS total_tests,(SELECT COUNT(at2.num_albara) AS Expr1 
From albara_test As at2 INNER JOIN albara AS a2 ON a2.num_albara = at2.num_albara 
WHERE (a2.cif = e.cif) And (at2.realitzat = 1)) AS tests_realitzats,
(SELECT COUNT(at2.num_albara) AS Expr1 From albara_test As at2 INNER JOIN albara AS a2 ON
 a2.num_albara = at2.num_albara WHERE (a2.cif = e.cif) And (at2.realitzat = 0)) AS tests_disponibles,
 SUM(ct.preu) AS preu_total From empresa As e LEFT JOIN albara AS a ON a.cif = e.cif LEFT JOIN
 albara_test AS at ON at.num_albara = a.num_albara LEFT JOIN
 test AS t ON t.codi_test = at.codi_test LEFT JOIN categoria_test AS ct ON ct.cod_categoria = t.cod_categoria
  INNER JOIN categoria AS c ON e.cod_categoria = c.cod_categoria
 ' + @condicion + 'GROUP BY e.cif, e.nom, e.adreca,e.cp, e.ciutat, e.regio, e.pais, e.telf, e.email, c.descripcio'
 exec sp_executesql  @query
 END

