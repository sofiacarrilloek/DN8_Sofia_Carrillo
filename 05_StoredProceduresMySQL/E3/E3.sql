DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterSales`(IN _usersiduser INT, IN _producttypesidprodctypes INT)
BEGIN
    DECLARE _idsales INT;
    SELECT MAX(idsales)+1 INTO _idsales FROM sales;

    INSERT INTO sales(idsales, datesale, producttypes_idproducttypes, users_iduser)
    VALUES (_idsales, NOW(), _producttypesidprodctypes, _usersiduser);
END //
DELIMITER ;//
