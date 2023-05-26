CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterSales`(in _usersiduser int, _producttypesidprodctypes int)
BEGIN
declare _idsales int;

select max(idsales)+1 into _idsales from sales;

	INSERT INTO sales(idsales,datesale,producttypes_idproducttypes,users_iduser)
VALUES(_idsales,now(),_producttypesidprodctypes,_usersiduser);

END