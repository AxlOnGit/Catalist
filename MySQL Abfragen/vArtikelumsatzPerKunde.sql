CREATE VIEW `vartikelumsatzperkunde` AS
SELECT 
  a.Nummer,
  a.Auftrag,
  a.Datum,
	p.*
FROM 
	auftraege a INNER JOIN auftraegepositionen p ON (a.Nummer = p.VorgangsnummerTemporaer) AND (a.Vorgang = p.VorgangspresetTemporaer)
WHERE 
				(a.Kundennummer = 2572000000)
		AND (a.Nummer <> a.Auftrag)
		AND	(p.VorgangspresetTemporaer = 'D' 
		OR 	 p.VorgangspresetTemporaer = 'R')
    AND	(p.Positionstyp = 1
		OR	 p.Positionstyp = 2)
ORDER BY
	a.Auftrag DESC