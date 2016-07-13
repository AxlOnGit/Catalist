SELECT 
	b.Datum,
	p.VorgangsnummerTemporaer AS Bestellnummer,
    b.Name1,
	p.Artikelnummer,
	p.Artikelbezeichnung1,
	p.Artikelbezeichnung2,
	p.Bestellmenge / POWER(10, p.MengeNachkommastellen) AS Bestellmenge,
	p.MengeGeliefert / POWER(10, p.MengeNachkommastellen) AS Liefermenge,
	p.Lieferwoche,
    b.E_Mail
FROM 
	bestellungen AS b INNER JOIN bestellungenpositionen AS p ON b.Bestellung = p.VorgangsnummerTemporaer
WHERE
	p.Bestellmenge > p.MengeGeliefert
ORDER BY
	b.Datum
;