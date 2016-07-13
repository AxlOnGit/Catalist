Select 
  'Kunde' As Typ,
  Name1 As Fund,
	Kundennummer, 
  Kundennummer As PK, 
  Name1 As Firma, 
  Postleitzahl As PLZ, 
  Ort
From 
	kunden
WHERE
	(
				(Kundennummer Like '%T547%')
    OR 	(Name1 Like '%T547%')
    OR	(Name2 Like '%T547%')
    OR	(Postleitzahl Like '%T547%')
    OR	(Ort Like '%T547%')
    OR	(Telefon Like '%T547%')
    OR	(Telefax Like '%T547%')
  )

UNION

Select
  'Ansprechpartner' As Ergebnistyp,
  ko.Name As Gefunden,
	ko.Kundennummer,
	ko.Nummer As PK,
  ku.Name1 As Firma,
  ku.Postleitzahl,
  ku.Ort
From
	kundenkontakt ko Inner Join kunden ku On ko.Kundennummer = ku.Kundennummer
WHERE
	(
				(ko.Name Like '%T547%')
		OR	(ko.Telefon Like '%T547%')
    OR  (ko.Telefax Like '%T547%')
    OR	(ko.E_Mail Like '%T547%')
    OR	(ko.Handy Like '%T547%')
  )
  
UNION

Select 
	'Maschine' As Ergebnistyp,
  concat(o.Modellbezeichnung, ': ', m.Seriennummer) As Gefunden,
  m.Kundennummer,
	m.UID As PK,
  k.Name1,
  k.Postleitzahl,
  k.Ort
From 
	cpm_kundenmaschine m Inner Join kunden k On m.Kundennummer = k.Kundennummer
  Inner Join cpm_maschinenmodell o On m.MaschinenmodellId = o.UID
Where
	(m.Seriennummer Like '%t547%')
ORDER BY
	Kundennummer