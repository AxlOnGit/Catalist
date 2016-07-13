SELECT 
	s.*,
  99 AS VK,
  ((100 - Rabatt) * 103.95) / 100 AS AlterPreis,
  (((100 - Rabatt) * 103.95) / 100) + 3.50 AS NeuerPreis,
  100 - (((((100 - Rabatt) * 103.95) / 100) + 3.50) * 100 / 99) AS NeuerRabatt
FROM 
	kundenartikelsonderpreise s Inner Join (SELECT Artikelgruppe, MAX(Verkaufspreis1) AS VK FROM artikel GROUP BY Artikelgruppe) a On s.Artikelgruppe = a.Artikelgruppe
Where 
	s.Artikelgruppe = '650';

UPDATE kundenartikelsonderpreise
SET Rabatt = 100 - (((((100 - Rabatt) * 103.95) / 100) + 3.50) * 100 / 99)
WHERE
	Artikelgruppe = '650' AND Rabatt >= 0.01
;