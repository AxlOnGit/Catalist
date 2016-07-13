CREATE PROCEDURE `pGetOrders` (IN kdNr CHAR(10))
BEGIN
	SELECT 
		Kundennummer, 
		Vorgang, 
		Nummer, 
		Auftrag, 
		Datum, 
		SummeZKD1_USt_1, Bruttosumme, 
		Gesamtrabatt 
	FROM 
		auftraege
	WHERE 
		(Kundennummer = kdNr)
	;
END
