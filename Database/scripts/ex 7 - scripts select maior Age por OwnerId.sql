/*7 - Selecione os registros da tabela Dogs com maior Age separados por OwnerId*/

SELECT MAX(Age) as Age, OwnerId FROM Dogs group by OwnerId