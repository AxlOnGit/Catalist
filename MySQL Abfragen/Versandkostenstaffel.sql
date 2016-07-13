SELECT 
	Kundennummer, 
  AbWert1,
  VKosten1,
  AbWert2,
  VKosten2,
  AbWert3,
  VKosten3,
  AbWert4,
  VKosten4
AS 
	Kosten
FROM 
	(
		SELECT
			Nummer AS Kundennummer,
      MAX(AbVergleichswert1 /100) AS AbWert1,
      MAX(ZuBerechnenderPreis1) AS VKosten1,
      MAX(AbVergleichswert2 /100) AS AbWert2,
      MAX(ZuBerechnenderPreis2) AS VKosten2,
      MAX(AbVergleichswert3 /100) AS AbWert3,
      MAX(ZuBerechnenderPreis3) AS VKosten3,
      MAX(AbVergleichswert4 /100) AS AbWert4,
      MAX(ZuBerechnenderPreis4) AS VKosten4
		FROM
			kundenversandkostenstaffeln
		GROUP BY
			Nummer WITH ROLLUP
  )
  AS Versandkosten
;
