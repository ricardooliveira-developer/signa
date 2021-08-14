/*4 Selecione o registro na tabela Dogs com menor age */

SELECT * FROM dogs WHERE age = (SELECT MIN(age) FROM dogs)