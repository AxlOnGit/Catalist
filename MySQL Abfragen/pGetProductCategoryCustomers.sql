CREATE DEFINER=`root`@`%` PROCEDURE `pGetProductCategoryCustomers`(In artikelgruppe varchar(20), In abDatum datetime)
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
		Inner Join	artikel art On art.Artikel = p.Artikelnummer
		Inner Join	kunden k On a.Kundennummer = k.Kundennummer
	Where
		((a.Datum >= abDatum) And (a.Vorgang = 'R' Or a.Vorgang = 'D') And (art.Artikelgruppe = artikelgruppe))
	Group By
		a.Kundennummer
	Order By
		Menge DESC
	;
END