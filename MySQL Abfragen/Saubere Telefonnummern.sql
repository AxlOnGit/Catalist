SELECT 
  Kundennummer, 
  replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(trim(Telefon), '/', ''), '-', ''), ' ', ''), '+49', '0'), '(', ''), ')', ''), '+31', '0031'), '+34', '0034'), '+38', '0038'), '+39', '0039'), '+41', '0041'), '+43', '0043') AS Telefon,
  replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(trim(Handy), '/', ''), '-', ''), ' ', ''), '+49', '0'), '(', ''), ')', ''), '+31', '0031'), '+34', '0034'), '+38', '0038'), '+39', '0039'), '+41', '0041'), '+43', '0043') AS Handy, 
  replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(trim(Autotelefon), '/', ''), '-', ''), ' ', ''), '+49', '0'), '(', ''), ')', ''), '+31', '0031'), '+34', '0034'), '+38', '0038'), '+39', '0039'), '+41', '0041'), '+43', '0043') AS Autotelefon 
FROM 
  kundenkontakt 

UNION 

SELECT
  Kundennummer, 
  replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(trim(Telefon), '/', ''), '-', ''), ' ', ''), '+49', '0'), '(', ''), ')', ''), '+31', '0031'), '+34', '0034'), '+38', '0038'), '+39', '0039'), '+41', '0041'), '+43', '0043') AS Telefon,
  '', 
  '' 
FROM 
  kunden
