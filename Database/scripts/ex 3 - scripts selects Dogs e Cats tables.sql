
/*3) Monte uma query que selecione apenas os nomes da tabela Cats que comecem com 'c', 
e os nomes da tabela Dogs que terminem com 'e'.*/

SELECT name FROM Cats 
WHERE name like 'c%'

	union

SELECT name FROM Dogs 
WHERE name like '%e'