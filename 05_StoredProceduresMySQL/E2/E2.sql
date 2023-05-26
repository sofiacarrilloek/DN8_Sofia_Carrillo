
CREATE DEFINER=`root`@`localhost` PROCEDURE `ProductsInStock`(in _idproducttype int)
BEGIN
SELECT producttypes_idproducttypes, amountinstock from inventory where producttypes_idproducttypes = _idproducttype;

END

-- Ejecucion
call ProductsInStock(3);