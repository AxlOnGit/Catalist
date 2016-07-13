CREATE PROCEDURE `pGetProductCustomers` (In artikelnummer varchar(20))
BEGIN
	Select
		a.Kundennummer,
	  k.Name1,
	  k.Name2,
	  k.Kurzbezeichnung,
	  k.Postleitzahl,
	  k.Ort,
		Count(a.Nummer) As Rechnungen,
		Sum(p.Menge) As Menge,
	  Max(a.Datum) As LetzterKauf
	From
		auftraege a Inner Join auftraegepositionen p On (a.Nummer = p.VorgangsnummerTemporaer) And (a.Vorgang = p.VorgangspresetTemporaer)
	  Inner Join kunden k On a.Kundennummer = k.Kundennummer
	Where
		((a.Vorgang = 'R' Or a.Vorgang = 'D') And (p.Artikelnummer = artikelnummer))
	Group By
		a.Kundennummer
	Order By
		Menge DESC
	;
END
