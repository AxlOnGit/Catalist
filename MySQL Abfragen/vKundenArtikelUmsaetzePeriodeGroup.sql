CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`%` 
    SQL SECURITY DEFINER
VIEW `vkundenartikelumsaetzeperiodegroup` AS
    SELECT 
        `kundenartikelumsaetzeperiode`.`Jahr` AS `Jahr`,
        `kundenartikelumsaetzeperiode`.`Kundennummer` AS `Kundennummer`,
        `kundenartikelumsaetzeperiode`.`Artikelnummer` AS `Artikelnummer`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzJanuar`) AS `UmsatzJanuar`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzFebruar`) AS `UmsatzFebruar`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzMaerz`) AS `UmsatzMaerz`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzApril`) AS `UmsatzApril`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzMai`) AS `UmsatzMai`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzJuni`) AS `UmsatzJuni`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzJuli`) AS `UmsatzJuli`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzAugust`) AS `UmsatzAugust`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzSeptember`) AS `UmsatzSeptember`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzOktober`) AS `UmsatzOktober`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzNovember`) AS `UmsatzNovember`,
        SUM(`kundenartikelumsaetzeperiode`.`UmsatzDezember`) AS `UmsatzDezember`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeJanuar`) AS `MengeJanuar`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeFebruar`) AS `MengeFebruar`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeMaerz`) AS `MengeMaerz`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeApril`) AS `MengeApril`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeMai`) AS `MengeMai`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeJuni`) AS `MengeJuni`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeJuli`) AS `MengeJuli`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeAugust`) AS `MengeAugust`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeSeptember`) AS `MengeSeptember`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeOktober`) AS `MengeOktober`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeNovember`) AS `MengeNovember`,
        SUM(`kundenartikelumsaetzeperiode`.`MengeDezember`) AS `MengeDezember`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesJanuar`) AS `RoherloesJanuar`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesFebruar`) AS `RoherloesFebruar`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesMaerz`) AS `RoherloesMaerz`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesApril`) AS `RoherloesApril`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesMai`) AS `RoherloesMai`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesJuni`) AS `RoherloesJuni`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesJuli`) AS `RoherloesJuli`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesAugust`) AS `RoherloesAugust`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesSeptember`) AS `RoherloesSeptember`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesOktober`) AS `RoherloesOktober`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesNovember`) AS `RoherloesNovember`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesDezember`) AS `RoherloesDezember`,
        SUM(`kundenartikelumsaetzeperiode`.`RoherloesKumuliert`) AS `RoherloesKumuliert`
    FROM
        `kundenartikelumsaetzeperiode`
    GROUP BY `kundenartikelumsaetzeperiode`.`Jahr` , `kundenartikelumsaetzeperiode`.`Kundennummer` , `kundenartikelumsaetzeperiode`.`Artikelnummer`