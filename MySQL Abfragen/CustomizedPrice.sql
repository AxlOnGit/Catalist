SELECT 
 k.Kundennummer, 
 a.USER_Katalogartikel, 
 a.Artikel, 
 a.Artikelgruppe, 
 a.FesterLieferant, 
 a.Matchcode, 
 a.Hersteller, 
 a.Bezeichnung1, 
 a.Bezeichnung2, 
 a.Mengeneinheit, 
 l.EK, 
 a.Verkaufspreis1, 
 a.Verkaufspreis1 * ((100 - s.Rabatt) / 100) AS Kundenpreis, 
 s.Rabatt AS Prozent, 
 s.Menge1, 
 s.Rabatt1,
 s.Menge2,
 s.Rabatt2,
 s.Menge3, 
 s.Rabatt3,
 s.Menge4,
 s.Rabatt4,
 cpm_katalog.SectionName AS Katalog, 
 artikel_cpm.CheckedFlag, 
 artikel_cpm.ChangeUser, 
 a.StandardlagerEinkauf
FROM 
 artikel a 
 LEFT OUTER JOIN kundenartikelsonderpreise s ON a.Artikelgruppe = s.Artikelgruppe 
 LEFT OUTER JOIN kunden k ON s.Kundennummer = k.Kundennummer 
 LEFT OUTER JOIN artikel_cpm ON a.Artikel = artikel_cpm.Artikel 
 LEFT OUTER JOIN cpm_katalog ON artikel_cpm.Category = cpm_katalog.Numbering 
 LEFT OUTER JOIN (SELECT Artikel, AVG(Einkaufspreis) AS EK
                  FROM artikellieferanten
                  WHERE (FesterLieferant_Kz = '*')
                  GROUP BY Artikel) l ON a.Artikel = l.Artikel
WHERE 
 (k.Kundennummer = @Kunde) AND (a.USER_Katalogartikel = '1') AND (a.Statuskennzeichen <> 'Ja') AND (a.Sperrvermerk1 = 0)

UNION

SELECT 
 s_1.Kundennummer, 
 a.USER_Katalogartikel, 
 a.Artikel, 
 a.Artikelgruppe, 
 a.FesterLieferant, 
 a.Matchcode, 
 a.Hersteller, 
 a.Bezeichnung1, 
 a.Bezeichnung2, 
 a.Mengeneinheit, 
 l_1.EK, 
 a.Verkaufspreis1, 
 a.Verkaufspreis1 AS Kundenpreis, 
 0.00 AS Prozent, 
 0.00 AS Menge1, 
 0.00 AS Rabatt1,
 0.00 AS Menge2,
 0.00 AS Rabatt2,
 0.00 AS Menge3, 
 0.00 AS Rabatt3,
 0.00 AS Menge4,
 0.00 AS Rabatt4,
 cpm_katalog_1.SectionName AS Katalog, 
 artikel_cpm_1.CheckedFlag, 
 artikel_cpm_1.ChangeUser, 
 a.StandardlagerEinkauf
FROM 
 artikel a 
 LEFT OUTER JOIN kundenartikelsonderpreise s ON a.Artikelgruppe = s.Artikelgruppe 
 LEFT OUTER JOIN kunden k ON s.Kundennummer = k.Kundennummer 
 LEFT OUTER JOIN artikel_cpm artikel_cpm_1 ON a.Artikel = artikel_cpm_1.Artikel 
 LEFT OUTER JOIN cpm_katalog cpm_katalog_1 ON artikel_cpm_1.Category = cpm_katalog_1.Numbering 
 LEFT OUTER JOIN (SELECT Kundennummer, Artikelgruppe
                  FROM kundenartikelsonderpreise
                  WHERE (Kundennummer = @Kunde)) s_1 ON a.Artikelgruppe = s_1.Artikelgruppe 
 LEFT OUTER JOIN (SELECT Artikel, AVG(Einkaufspreis) AS EK
                  FROM artikellieferanten artikellieferanten_1
                  WHERE (FesterLieferant_Kz = '*')
				  GROUP BY Artikel) l_1 ON a.Artikel = l_1.Artikel
WHERE 
 (s_1.Artikelgruppe IS NULL) AND (a.Statuskennzeichen <> 'Ja') AND (a.USER_Katalogartikel = '1') AND (a.Sperrvermerk1 = 0)
