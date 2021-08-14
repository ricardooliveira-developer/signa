/*8 - Retorne o nome do Owner e a respectiva quantidade de animais total*/

SELECT 
	o.Name, 
	(select COUNT(id) from Cats c where c.OwnerId = o.Id) as Cats,
	(select COUNT(id) from Dogs c where c.OwnerId = o.Id) as Dogs,
	((select COUNT(id) from Cats c where c.OwnerId = o.Id) +
	(select COUNT(id) from Dogs c where c.OwnerId = o.Id)) as 'Total Animais'
FROM Owner o