CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`%` 
    SQL SECURITY DEFINER
VIEW `vkundenumsatzbasis` AS
    SELECT DISTINCT
        `vkundenartikelumsaetzeperiode`.`Jahr` AS `Jahr`,
        `vkundenartikelumsaetzeperiode`.`Kundennummer` AS `Kundennummer`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzJanuar`) AS `UmsatzJanuar`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeJanuar`) AS `MengeJanuar`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesJanuar`) AS `RohgewinnJanuarAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnJanuarProzent`) AS `RohgewinnJanuarProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzFebruar`) AS `UmsatzFebruar`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeFebruar`) AS `MengeFebruar`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesFebruar`) AS `RohgewinnFebruarAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnFebruarProzent`) AS `RohgewinnFebruarProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzMaerz`) AS `UmsatzMaerz`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeMaerz`) AS `MengeMaerz`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesMaerz`) AS `RohgewinnMaerzAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnMaerzProzent`) AS `RohgewinnMaerzProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzApril`) AS `UmsatzApril`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeApril`) AS `MengeApril`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesApril`) AS `RohgewinnAprilAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnAprilProzent`) AS `RohgewinnAprilProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzMai`) AS `UmsatzMai`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeMai`) AS `MengeMai`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesMai`) AS `RohgewinnMaiAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnMaiProzent`) AS `RohgewinnMaiProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzJuni`) AS `UmsatzJuni`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeJuni`) AS `MengeJuni`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesJuni`) AS `RohgewinnJuniAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnJuniProzent`) AS `RohgewinnJuniProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzJuli`) AS `UmsatzJuli`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeJuli`) AS `MengeJuli`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesJuli`) AS `RohgewinnJuliAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnJuliProzent`) AS `RohgewinnJuliProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzAugust`) AS `UmsatzAugust`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeAugust`) AS `MengeAugust`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesAugust`) AS `RohgewinnAugustAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnAugustProzent`) AS `RohgewinnAugustProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzSeptember`) AS `UmsatzSeptember`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeSeptember`) AS `MengeSeptember`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesSeptember`) AS `RohgewinnSeptemberAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnSeptemberProzent`) AS `RohgewinnSeptemberProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzOktober`) AS `UmsatzOktober`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeOktober`) AS `MengeOktober`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesOktober`) AS `RohgewinnOktoberAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnOktoberProzent`) AS `RohgewinnOktoberProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzNovember`) AS `UmsatzNovember`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeNovember`) AS `MengeNovember`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesNovember`) AS `RohgewinnNovemberAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnNovemberProzent`) AS `RohgewinnNovemberProzent`,
        SUM(`vkundenartikelumsaetzeperiode`.`UmsatzDezember`) AS `UmsatzDezember`,
        SUM(`vkundenartikelumsaetzeperiode`.`MengeDezember`) AS `MengeDezember`,
        SUM(`vkundenartikelumsaetzeperiode`.`RoherloesDezember`) AS `RohgewinnDezemberAbsolut`,
        SUM(`vkundenartikelumsaetzeperiode`.`RohgewinnDezemberProzent`) AS `RohgewinnDezemberProzent`
    FROM
        `vkundenartikelumsaetzeperiode`
    WHERE
        (`vkundenartikelumsaetzeperiode`.`Jahr` >= 2013)
    GROUP BY `vkundenartikelumsaetzeperiode`.`Jahr` , `vkundenartikelumsaetzeperiode`.`Kundennummer`
    ORDER BY `vkundenartikelumsaetzeperiode`.`Jahr` DESC , `vkundenartikelumsaetzeperiode`.`Kundennummer`