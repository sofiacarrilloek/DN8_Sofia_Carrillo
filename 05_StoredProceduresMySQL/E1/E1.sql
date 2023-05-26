CREATE DEFINER=`root`@`localhost` PROCEDURE `MembersLastWeek`()
BEGIN
select m.idmembers, m.createon, ms.name from members m 
inner join membershiptypes ms on m.membershiptypes_idmembershiptypes=ms.idmembershiptypes
where m.createon between '2022-01-03' and '2022-01-09';
END