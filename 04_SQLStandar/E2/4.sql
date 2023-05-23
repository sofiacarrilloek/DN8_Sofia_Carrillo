-- Seleccionar el producto más vendido
select pt.name as 'mas_vendido' from producttypes pt 
inner join sales s on s.producttypes_idproducttypes = pt.idproducttypes
inner join (select max(units)max_units from sales ) r on r.max_units=s.units;
