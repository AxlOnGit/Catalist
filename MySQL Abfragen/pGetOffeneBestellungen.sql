CREATE DEFINER=`root`@`%` PROCEDURE `pGetOffeneBestellungen`(IN artikelNbr varchar(20))
BEGIN
	SELECT
		b.Datum,
		b.Nummer AS Bestellnummer,
	  SUM(p.Bestellmenge / POWER(10, p.MengeNachkommastellen)) As Bestellmenge,
	  SUM(p.MengeGeliefert / POWER(10, p.MengeNachkommastellen)) As Liefermenge,
	  SUM(p.MengeBerechnet / POWER(10, p.MengeNachkommastellen)) As Rechnungsmenge,
	  p.Lieferdatum,
	  l.Kurzbezeichnung AS Lieferant
	From
		bestellungen b INNER JOIN bestellungenpositionen p ON (b.Nummer = p.VorgangsnummerTemporaer) INNER JOIN lieferanten l ON (p.Hersteller = l.Lieferantennummer)
	WHERE
		(		(p.Artikelnummer = artikelNbr) 
			AND (p.Positionstyp = 1) 
            AND (b.Druck_Auswert_sperre = '')
		)
	GROUP BY
		b.Datum, 
        b.Nummer, 
        p.Lieferdatum
	HAVING
			(SUM(p.Bestellmenge / POWER(10, p.MengeNachkommastellen)) > SUM(p.MengeGeliefert / POWER(10, p.MengeNachkommastellen)))
	ORDER BY
		b.Datum DESC
	;
END