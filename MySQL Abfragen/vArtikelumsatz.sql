CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`%` 
    SQL SECURITY DEFINER
VIEW `vartikelumsatz` AS
    select 
        `a`.`Auftrag` AS `Auftrag`,
        `p`.`VorgangsnummerTemporaer` AS `Rechnung`,
        `a`.`Datum` AS `Datum`,
        `a`.`Kundennummer` AS `Kundennummer`,
        `a`.`Kurzbezeichung` AS `Kurzbezeichung`,
        `a`.`Postleitzahl` AS `Postleitzahl`,
        `a`.`Ort` AS `Ort`,
        (select 
                (case `p`.`Positionstyp`
                        when 1 then 'A'
                        else 'S'
                    end)
            ) AS `Typ`,
        (select 
                (case `p`.`Positionstyp`
                        when 1 then `p`.`Artikelnummer`
                        else `p`.`Stuecklistennummer`
                    end)
            ) AS `Artikel`,
        `p`.`Bezeichnung1` AS `Artikelname`,
        (`p`.`Menge` / pow(10, `p`.`MengeNachkommastellen`)) AS `Menge`,
        `p`.`Einheitspreis` AS `Standardpreis`,
        `p`.`Gesamtpreis` AS `Kundenpreis`,
        `p`.`Positionsnettopreis` AS `Positionsnettopreis`
    from
        (`auftraege` `a`
        join `auftraegepositionen` `p` ON (((`a`.`Nummer` = `p`.`VorgangsnummerTemporaer`)
            and (`a`.`Vorgang` = `p`.`VorgangspresetTemporaer`))))
    where
        (((`a`.`Vorgang` = 'D')
            or (`a`.`Vorgang` = 'R'))
            and ((`p`.`Positionstyp` = 1)
            or (`p`.`Positionstyp` = 2))
            and ((`p`.`Artikelnummer` <> '')
            or (`p`.`Stuecklistennummer` <> '')))