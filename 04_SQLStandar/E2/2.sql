-- Crear una vista que devuelva el listado de usuarios con los roles que tiene asignados.
create view usuarios_roles as select u.idusers, u.name AS 'nombre_usuario', r.name AS 'rol' from users as u
inner join usersinroles as ur on u.idusers = ur.users_idusers 
inner join roles as r on ur.roles_idroles = r.idroles;