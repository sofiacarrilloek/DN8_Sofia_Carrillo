-- Seleccionar el último miembro registrado con el tipo de membresía adquirida.
select m.name, m.lastname as 'ultimo_miembro' from members m 
inner join membershiptypes ms on ms.idmembershiptypes = m.membershiptypes_idmembershiptypes
inner join (select max(createon)ultimoregistro from members ) mb on mb.ultimoregistro=m.createon;

