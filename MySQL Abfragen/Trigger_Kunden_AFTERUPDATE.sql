CREATE DEFINER = CURRENT_USER TRIGGER `sagecl_mandant004`.`kunden_AFTER_UPDATE` AFTER UPDATE ON `kunden` FOR EACH ROW
BEGIN
  SELECT NEW.Kundennummer INTO OUTFILE 'E:/Sage/Sage New Classic/catalist/trigger_dateien/kundenupdate.txt'
  FIELDS TERMINATED BY ','
  ENCLOSED BY '"'
  ESCAPED BY '\\'
  LINES TERMINATED BY '\r\n';
END
