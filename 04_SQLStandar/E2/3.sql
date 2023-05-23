-- Crear una vista que devuelva el listado de productos en existencia con el tipo de producto al que pertenece.

create view pruductosexitencia_tipoproducto as 
	select pt.name, i.amountinstock as 'stock' from producttypes as pt 
		inner join inventory as i on pt.idproducttypes = i.producttypes_idproducttypes;