Select Distinct
	k.Kundennummer,
  k.Name1,
  k.Telefon,
  k.Telefax,
  k.Homepage,
  k.E_Mail,
  d.USt_IdNr
From 
	kunden k Inner Join debitoren d on k.Kundennummer = d.Kontonummer
WHERE
	((k.Homepage = '') OR (k.E_mail = '') OR (d.UST_IdNr = ''))
Order By 
	d.USt_IdNr DESC

