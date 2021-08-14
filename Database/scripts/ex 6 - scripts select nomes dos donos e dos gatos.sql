/*6 Selecione os nomes dos Owner e seus respectivos Cats */

SELECT o.Name, c.Name as Cats FROM Owner o
	JOIN Cats c
on o.Id = c.OwnerId