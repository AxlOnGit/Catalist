CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`%` 
    SQL SECURITY DEFINER
VIEW `vkundenartikelumsaetzeperiode` AS

SELECT 
	u.Jahr,
  u.Kundennummer,
  u.Artikelnummer,
  SUM(u.UmsatzJanuar) AS UmsatzJanuar,
  SUM(u.MengeJanuar / POWER(10, a.Nachkommastellen)) AS MengeJanuar,
  SUM(u.RoherloesJanuar) AS RoherloesJanuar,
  100 * SUM(u.RoherloesJanuar) / SUM(u.UmsatzJanuar) AS RohgewinnJanuarProzent,

  SUM(u.UmsatzFebruar) AS UmsatzFebruar,
  SUM(u.MengeFebruar / POWER(10, a.Nachkommastellen)) AS MengeFebruar,
  SUM(u.RoherloesFebruar) AS RoherloesFebruar,
  100 * SUM(u.RoherloesFebruar) / SUM(u.UmsatzFebruar) AS RohgewinnFebruarProzent,

  SUM(u.UmsatzMaerz) AS UmsatzMaerz,
  SUM(u.MengeMaerz / POWER(10, a.Nachkommastellen)) AS MengeMaerz,
  SUM(u.RoherloesMaerz) AS RoherloesMaerz,
  100 * SUM(u.RoherloesMaerz) / SUM(u.UmsatzMaerz) AS RohgewinnMaerzProzent,

  SUM(u.UmsatzApril) AS UmsatzApril,
  SUM(u.MengeApril / POWER(10, a.Nachkommastellen)) AS MengeApril,
  SUM(u.RoherloesApril) AS RoherloesApril,
  100 * SUM(u.RoherloesApril) / SUM(u.UmsatzApril) AS RohgewinnAprilProzent,

  SUM(u.UmsatzMai) AS UmsatzMai,
  SUM(u.MengeMai / POWER(10, a.Nachkommastellen)) AS MengeMai,
  SUM(u.RoherloesMai) AS RoherloesMai,
  100 * SUM(u.RoherloesMai) / SUM(u.UmsatzMai) AS RohgewinnMaiProzent,

  SUM(u.UmsatzJuni) AS UmsatzJuni,
  SUM(u.MengeJuni / POWER(10, a.Nachkommastellen)) AS MengeJuni,
  SUM(u.RoherloesJuni) AS RoherloesJuni,
  100 * SUM(u.RoherloesJuni) / SUM(u.UmsatzJuni) AS RohgewinnJuniProzent,

  SUM(u.UmsatzJuli) AS UmsatzJuli,
  SUM(u.MengeJuli / POWER(10, a.Nachkommastellen)) AS MengeJuli,
  SUM(u.RoherloesJuli) AS RoherloesJuli,
  100 * SUM(u.RoherloesJuli) / SUM(u.UmsatzJuli) AS RohgewinnJuliProzent,

  SUM(u.UmsatzAugust) AS UmsatzAugust,
  SUM(u.MengeAugust / POWER(10, a.Nachkommastellen)) AS MengeAugust,
  SUM(u.RoherloesAugust) AS RoherloesAugust,
  100 * SUM(u.RoherloesAugust) / SUM(u.UmsatzAugust) AS RohgewinnAugustProzent,

  SUM(u.UmsatzSeptember) AS UmsatzSeptember,
  SUM(u.MengeSeptember / POWER(10, a.Nachkommastellen)) AS MengeSeptember,
  SUM(u.RoherloesSeptember) AS RoherloesSeptember,
  100 * SUM(u.RoherloesSeptember) / SUM(u.UmsatzSeptember) AS RohgewinnSeptemberProzent,

  SUM(u.UmsatzOktober) AS UmsatzOktober,
  SUM(u.MengeOktober / POWER(10, a.Nachkommastellen)) AS MengeOktober,
  SUM(u.RoherloesOktober) AS RoherloesOktober,
  100 * SUM(u.RoherloesOktober) / SUM(u.UmsatzOktober) AS RohgewinnOktoberProzent,

  SUM(u.UmsatzNovember) AS UmsatzNovember,
  SUM(u.MengeNovember / POWER(10, a.Nachkommastellen)) AS MengeNovember,
  SUM(u.RoherloesNovember) AS RoherloesNovember,
  100 * SUM(u.RoherloesNovember) / SUM(u.UmsatzNovember) AS RohgewinnNovemberProzent,

  SUM(u.UmsatzDezember) AS UmsatzDezember,
  SUM(u.MengeDezember / POWER(10, a.Nachkommastellen)) AS MengeDezember,
  SUM(u.RoherloesDezember) AS RoherloesDezember,
  100 * SUM(u.RoherloesDezember) / SUM(u.UmsatzDezember) AS RohgewinnDezemberProzent

FROM 
	kundenartikelumsaetzeperiode u INNER JOIN artikel a ON u.Artikelnummer = a.Artikel
-- WHERE
	-- u.Artikelnummer = '3640G-14' AND u.Kundennummer = '4828300000'
GROUP BY Jahr, Kundennummer, Artikelnummer
;