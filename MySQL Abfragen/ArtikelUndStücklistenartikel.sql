SELECT
	'Artikel' AS Typ,
	k.Kundennummer, 
	a.USER_Katalogartikel, 
	a.Artikel, 
	a.Artikelgruppe, 
	a.FesterLieferant, 
	a.Matchcode, 
	a. ArtikelzusatztextAnker, 
	a.Hersteller, 
	a.Bezeichnung1, 
	a.Bezeichnung2, 
	a.Mengeneinheit, 
	a.MittlererEinkaufspreis AS EK, 
	a.Verkaufspreis1, 
	a.Verkaufspreis1 * ((100 - s.Rabatt) / 100) AS Kundenpreis, 
	s.Rabatt AS Prozent, 
	a.BestandAktuell AS Bestand 
FROM 
	artikel a 
	INNER JOIN kundenartikelsonderpreise s ON a.Artikelgruppe = s.Artikelgruppe 
	INNER JOIN kunden k ON s.Kundennummer = k.Kundennummer 
	LEFT OUTER JOIN (SELECT Artikel, MAX(Einkaufspreis) AS EK 
		FROM artikellieferanten 
    GROUP BY Artikel) l ON a.Artikel = l.Artikel
WHERE (k.Kundennummer = '4810500000') AND (a.Statuskennzeichen <> 'Ja')

UNION

SELECT
'Artikel' AS Typ,
s_1.Kundennummer,
a.USER_Katalogartikel,
a.Artikel,
a.Artikelgruppe,
a.FesterLieferant,
a.Matchcode,
a.ArtikelzusatztextAnker,
a.Hersteller,
a.Bezeichnung1,
a.Bezeichnung2,
a.Mengeneinheit,
a.MittlererEinkaufspreis ,
a.Verkaufspreis1,
a.Verkaufspreis1 AS Kundenpreis,
'0.00' AS Prozent,
a.BestandAktuell
FROM artikel a
	LEFT OUTER JOIN ( SELECT Kundennummer, Artikelgruppe
	FROM kundenartikelsonderpreise
	WHERE (Kundennummer = '4810500000')) s_1 ON a.Artikelgruppe = s_1.Artikelgruppe
-- LEFT OUTER JOIN ( SELECT Artikel, MAX(Einkaufspreis) AS EK
-- FROM artikellieferanten artikellieferanten_1
-- GROUP BY Artikel) l_1 ON a.Artikel = l_1.Artikel
WHERE
	(s_1.Artikelgruppe IS NULL) AND (a.Statuskennzeichen <> 'Ja')

UNION

SELECT
'Stückliste' AS Typ,
s_2.Kundennummer,
'' AS USER_Katalogartikel,
st.Stuecklistennummer AS Artikel,
'' AS Artikelgruppe,
'' AS FesterLieferant,
st.Matchcode,
st.ZusatztextDeutsch AS ArtikelzusatztextAnker,
'' AS Hersteller,
st.Bezeichnung1,
st.Bezeichnung2,
st.Mengeneinheit,
0.00 AS MittlererEinkaufspreis,
st.Verkaufspreis1,
st.Verkaufspreis1 AS Kundenpreis,
'0.00' AS Prozent,
0 AS BestandAktuell
FROM stuecklisten st
	LEFT OUTER JOIN (SELECT Kundennummer, Stuecklistennummer
	FROM kundenstuecklistensonderpreise
	WHERE (Kundennummer = '4810500000')) s_2 ON st.Stuecklistennummer = s_2.Stuecklistennummer
-- LEFT OUTER JOIN ( SELECT Artikel, MAX(Einkaufspreis) AS EK
-- FROM artikellieferanten artikellieferanten_1
-- GROUP BY Artikel) l_1 ON a.Artikel = l_1.Artikel
WHERE
	(s_2.Stuecklistennummer IS NULL) AND (st.Statuskennzeichen <> 'Ja')
