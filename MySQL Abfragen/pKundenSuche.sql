CREATE DEFINER=`root`@`%` PROCEDURE `pKundenSuche`(IN searchFor VARCHAR(255))
SELECT 'Kunde' AS Typ, Name1 AS Fund, Kundennummer, Kundennummer AS PK, Name1 AS Firma, Postleitzahl AS PLZ, Ort
	FROM   kunden
	WHERE  (Kundennummer LIKE CONCAT('%', (searchFor), '%')) OR
         (LOWER(Name1) LIKE CONCAT('%', LOWER(searchFor), '%') OR
         (LOWER(Name2) LIKE CONCAT('%', LOWER(searchFor), '%')) OR
         (Postleitzahl LIKE CONCAT('%', searchFor, '%')) OR
         (LOWER(Ort) LIKE CONCAT('%', LOWER(searchFor), '%')) OR
         (Telefon LIKE CONCAT('%', searchFor, '%')) OR
         (Telefax LIKE CONCAT('%', searchFor, '%')))
UNION
	SELECT 'Kontakt' AS Ergebnistyp, ko.Name AS Gefunden, ko.Kundennummer, ko.Nummer AS PK, ku.Name1 AS Firma, ku.Postleitzahl AS PLZ, ku.Ort
	FROM  kundenkontakt ko INNER JOIN kunden ku ON ko.Kundennummer = ku.Kundennummer
	WHERE (LOWER(ko.Name) LIKE CONCAT('%', LOWER(searchFor), '%')) OR
				(ko.Telefon LIKE CONCAT('%', searchFor, '%')) OR
				(ko.Telefax LIKE CONCAT('%', searchFor, '%')) OR
				(LOWER(ko.E_Mail) LIKE CONCAT('%', LOWER(searchFor), '%')) OR
				(ko.Handy LIKE CONCAT('%', searchFor, '%'))
UNION
	(SELECT 'Maschine' AS Typ, CONCAT(o.Modellbezeichnung, ': ', m.Seriennummer) AS Fund, m.Kundennummer, m.UID AS PK, k.Name1 AS Firma, k.Postleitzahl AS PLZ, k.Ort
	 FROM   cpm_kundenmaschine m INNER JOIN kunden k ON m.Kundennummer = k.Kundennummer 
				 INNER JOIN cpm_maschinenmodell o ON m.MaschinenmodellId = o.UID
WHERE		 
	(m.Seriennummer LIKE CONCAT('%', searchFor, '%')))