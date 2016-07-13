CREATE PROCEDURE `pGetOrderDetails` (IN kdNr char(10))
BEGIN
	SELECT 
		a.Nummer,
		d.Positionszaehler, 
		d.Artikelnummer, 
		d.Bezeichnung1, 
		d.Bezeichnung2, 
		d.Menge / POWER(10, d.MengeNachkommastellen) AS Menge, 
		d.Mengeneinheit, 
		d.Einheitspreis, 
		d.Rabattsatz, 
		(d.Gesamtpreis /(d.Menge / POWER(10, d.MengeNachkommastellen))) AS Einzelpreis, 
		d.Gesamtpreis 
	FROM 
		auftraegepositionen d INNER JOIN auftraege a ON d.VorgangsnummerTemporaer = a.Nummer AND d.VorgangspresetTemporaer = a.Vorgang
	WHERE 
		((a.Kundennummer = kdNr) AND (d.Positionszaehler <> ''))
	;
END