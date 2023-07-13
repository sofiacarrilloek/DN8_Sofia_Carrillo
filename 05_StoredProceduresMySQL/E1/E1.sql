DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `MembersLastWeek`()
BEGIN
    SELECT m.idmembers, m.createon, ms.name 
    FROM members m 
    INNER JOIN membershiptypes ms ON m.membershiptypes_idmembershiptypes=ms.idmembershiptypes
    WHERE m.createon BETWEEN '2022-06-03' AND '2022-06-05';
END //
DELIMITER ;

