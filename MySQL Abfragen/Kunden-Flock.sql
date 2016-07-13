SELECT 
 COUNT(h.Datum) AS Anzahl,
 a.Artikelgruppe,
 h.Kunde,
 k.Name1,
 k.Postleitzahl,
 k.Ort,
 SUM(h.Roherloes) AS Roherloese 
FROM 
 artikelhistorie h 
 INNER JOIN artikel a ON h.Header_Artikel = a.Artikel
 INNER JOIN kunden k ON h.Kunde = k.Kundennummer
WHERE
 (h.Datum > '2013-12-31') AND (a.Artikelgruppe = '700') AND (h.Roherloes > 0)
GROUP BY
 h.Kunde, a.Artikelgruppe
ORDER BY 
 Anzahl DESC