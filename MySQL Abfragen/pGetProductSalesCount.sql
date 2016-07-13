CREATE DEFINER=`root`@`%` PROCEDURE `pGetProductSalesCount`(IN artikelnummer varchar(20))
BEGIN
	SELECT 
		DATE_FORMAT(a.Datum, '%Y-%m') As Zeitraum,
		SUM(p.Menge / POWER(10, p.MengeNachkommastellen)) As Menge
	FROM 
		auftraegepositionen p Inner Join auftraege a On p.VorgangspresetTemporaer = a.Vorgang And p.VorgangsnummerTemporaer = a.Nummer
	Where
		((p.Artikelnummer = artikelnummer) And (p.VorgangspresetTemporaer = 'D' Or p.VorgangspresetTemporaer = 'R'))
	Group By
		Zeitraum
	Order By
		Zeitraum Desc
;
END