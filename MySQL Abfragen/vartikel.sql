CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`%` 
    SQL SECURITY DEFINER
VIEW `vartikel` AS
    select 
        `a`.`Statuskennzeichen` AS `Inaktiv`,
        `a`.`USER_Katalogartikel` AS `Katalog`,
        `a`.`USER_WebshopArtikel` AS `Webshop`,
        `a`.`Bestellkennzeichen` AS `Bestellkennzeichen`,
        `a`.`Artikelgruppe` AS `Artikelgruppe`,
        `a`.`Artikel` AS `Artikelnummer`,
        `a`.`Matchcode` AS `Matchcode`,
        `a`.`Bezeichnung1` AS `Artikelname`,
        `a`.`Bezeichnung2` AS `Artikelzusatz`,
        `a`.`Mengeneinheit` AS `Mengeneinheit`,
        (`a`.`BestandAktuell` / pow(10, `a`.`Nachkommastellen`)) AS `Bestand`,
        `a`.`Mindest_Meldebestand` AS `Meldebestand`,
        `a`.`Verkaufspreis1` AS `VK1`,
        `a`.`Verkaufspreis2` AS `VK2`,
        `a`.`MittlererEinkaufspreis` AS `EK_gemittelt`,
        `a`.`KalkulatorischerEinkaufspreis` AS `EK_kalkuliert`,
        `a`.`UmsatzPeriode` AS `UmsatzPeriode`,
        `a`.`UmsatzKumuliert` AS `UmsatzKumuliert`,
        `a`.`RoherloesPeriode` AS `GewinnPeriode`,
        `a`.`RoherloesKumuliert` AS `GewinnKumuliert`,
        `a`.`Timestamp_Datum` AS `BearbeitetAm`,
        `a`.`Timestamp_Zeit` AS `BearbeitetUm`,
        `a`.`Timestamp_Benutzer` AS `BearbeitetVon`,
        `a`.`Sperrvermerk1` AS `Auslaufartikel`,
        `a`.`Sperrvermerk2` AS `Saisonartikel`,
        `a`.`Sperrvermerk3` AS `Austauschartikel`,
        `a`.`Sperrvermerk4` AS `GGVS`,
        `a`.`Sperrvermerk5` AS `Reduziert`,
        `s`.`Content` AS `Zusatztext`
    from
        (`artikel` `a`
        left join `systemmemo` `s` ON (((`a`.`ArtikelzusatztextAnker` = `s`.`ID`)
            and (`s`.`Dateiname` = 'A10212.VDT'))))