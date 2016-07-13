CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`%` 
    SQL SECURITY DEFINER
VIEW `vkundenumsatz` AS
SELECT Kundennummer, CONCAT(Jahr, '-01-
31') AS Datum, SUM(UmsatzJanuar) AS Umsatz, SUM(MengeJanuar) AS Menge, SUM(RoherloesJanuar) AS RohgewinnAbsolut, (SUM(RoherloesJanuar) / SUM(UmsatzJanuar) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-02-28') AS Datum, SUM(UmsatzFebruar) AS Umsatz, SUM(MengeFebruar) AS Menge, SUM(RoherloesFebruar) AS RohgewinnAbsolut, (SUM(RoherloesFebruar) / SUM(UmsatzFebruar) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-03-31') AS Datum, SUM(UmsatzMaerz) AS Umsatz, SUM(MengeMaerz) AS Menge, SUM(RoherloesMaerz) AS RohgewinnAbsolut, (SUM(RoherloesMaerz) / SUM(UmsatzMaerz) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-04-30') AS Datum, SUM(UmsatzApril) AS Umsatz, SUM(MengeApril) AS Menge, SUM(RoherloesApril) AS RohgewinnAbsolut, (SUM(RoherloesApril) / SUM(UmsatzApril) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-05-31') AS Datum, SUM(UmsatzMai) AS Umsatz, SUM(MengeMai) AS Menge, SUM(RoherloesMai) AS RohgewinnAbsolut, (SUM(RoherloesMai) / SUM(UmsatzMai) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-06-28') AS Datum, SUM(UmsatzJuni) AS Umsatz, SUM(MengeJuni) AS Menge, SUM(RoherloesJuni) AS RohgewinnAbsolut, (SUM(RoherloesJuni) / SUM(UmsatzJuni) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-07-28') AS Datum, SUM(UmsatzJuli) AS Umsatz, SUM(MengeJuli) AS Menge, SUM(RoherloesJuli) AS RohgewinnAbsolut, (SUM(RoherloesJuli) / SUM(UmsatzJuli) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-08-31') AS Datum, SUM(UmsatzAugust) AS Umsatz, SUM(MengeAugust) AS Menge, SUM(RoherloesAugust) AS RohgewinnAbsolut, (SUM(RoherloesAugust) / SUM(UmsatzAugust) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-09-30') AS Datum, SUM(UmsatzSeptember) AS Umsatz, SUM(MengeSeptember) AS Menge, SUM(RoherloesSeptember) AS RohgewinnAbsolut, (SUM(RoherloesSeptember) / SUM(UmsatzSeptember) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-10-31') AS Datum, SUM(UmsatzOktober) AS Umsatz, SUM(MengeOktober) AS Menge, SUM(RoherloesOktober) AS RohgewinnAbsolut, (SUM(RoherloesOktober) / SUM(UmsatzOktober) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-11-30') AS Datum, SUM(UmsatzNovember) AS Umsatz, SUM(MengeNovember) AS Menge, SUM(RoherloesNovember) AS RohgewinnAbsolut, (SUM(RoherloesNovember) / SUM(UmsatzNovember) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

UNION

SELECT Kundennummer, CONCAT(Jahr, '-12-31') AS Datum, SUM(UmsatzDezember) AS Umsatz, SUM(MengeDezember) AS Menge, SUM(RoherloesDezember) AS RohgewinnAbsolut, (SUM(RoherloesDezember) / SUM(UmsatzDezember) * 100) AS RohgewinnProzent
FROM vkundenartikelumsaetzeperiode
GROUP BY Kundennummer

ORDER BY Kundennummer ASC, Datum DESC

