CREATE VIEW `vpivotkundenartikelumsatzperiode` 
AS
SELECT 
	k.Jahr,
    k.Kundennummer,
    e.Gruppe,
    SUM(UmsatzJanuar) AS JAN,
    SUM(UmsatzFebruar) AS FEB,
    SUM(UmsatzMaerz) AS MRZ,
    SUM(UmsatzApril) AS APR,
    SUM(UmsatzMai) AS MAI,
    SUM(UmsatzJuni) AS JUN,
    SUM(UmsatzJuli) AS JUL,
    SUM(UmsatzAugust) AS AUG,
    SUM(UmsatzSeptember) AS SEP,
    SUM(UmsatzOktober) AS OKT,
    SUM(UmsatzNovember) AS NOV,
    SUM(UmsatzDezember) AS DEZ
FROM
				kundenartikelumsaetzeperiode k 
    INNER JOIN 	artikel a ON k.Artikelnummer = a.Artikel
    INNER JOIN	cpm_erloescodexref e ON a.Erloescode = e.Erloescode
GROUP BY
	k.Jahr,
    k.Kundennummer,
    e.Gruppe