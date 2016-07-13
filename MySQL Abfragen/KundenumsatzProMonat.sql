CREATE VIEW vkundenumsaetzeperiode
AS

SELECT Kundennummer, CONCAT(Jahr, '-01-31') As Datum, UmsatzJanuar As Umsatz
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-02-28'), UmsatzFebruar
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-03-31'), UmsatzMaerz
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-04-30'), UmsatzApril
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-05-31'), UmsatzMai
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-06-30'), UmsatzJuni
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-07-31'), UmsatzJuli
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-08-31'), UmsatzAugust
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-09-30'), UmsatzSeptember
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-10-31'), UmsatzOktober
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-11-30'), UmsatzNovember
FROM kundenumsaetzeperioden

UNION

SELECT Kundennummer, CONCAT(Jahr, '-12-31'), UmsatzDezember
FROM kundenumsaetzeperioden

ORDER BY Kundennummer ASC, Datum DESC
;