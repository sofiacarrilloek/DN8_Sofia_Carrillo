---------------equipmenttype---------------
insert into equipmenttype (idequipmenttype, name, units) values (1, 'Mancuerdas', '10');
insert into equipmenttype (idequipmenttype, name, units) values (2, 'Caminadora', '5');
insert into equipmenttype (idequipmenttype, name, units) values (3, 'Bicicleta estática', '5');
insert into equipmenttype (idequipmenttype, name, units) values (4, 'Pesas', '8');
insert into equipmenttype (idequipmenttype, name, units) values (5, 'Ligas de resistencia', '15');

---------------measuretype---------------
insert into measuretype (idmeasuretype, name, typeunit) values (1, 'Gram','Mass');
insert into measuretype (idmeasuretype, name, typeunit) values (2, 'Liters','Volume');
insert into measuretype (idmeasuretype, name, typeunit) values (3, 'Meter','Lenght');
insert into measuretype (idmeasuretype, name, typeunit) values (4, 'Calories','Heat');
insert into measuretype (idmeasuretype, name, typeunit) values (5, 'Kilogram','Mass');
insert into measuretype (idmeasuretype, name, typeunit) values (6, 'Miniliters','Volume');
insert into measuretype (idmeasuretype, name, typeunit) values (7, 'Ounce','Volume');

---------------producttypes---------------
insert into producttypes (idproducttypes,name, measuretype_idmeasuretype, quantity, price) values (1,'Botella de agua Bonafont',6, 500, '12.00');
insert into producttypes (idproducttypes,name, measuretype_idmeasuretype, quantity, price) values (2,'Botella de agua Bonafont',2, 1, '17.00');
insert into producttypes (idproducttypes,name, measuretype_idmeasuretype, quantity, price) values (3,'Bolsa de proteina High Level',1, 750, '55.00');
insert into producttypes (idproducttypes,name, measuretype_idmeasuretype, quantity, price) values (4,'Barras de proteinas PRO-POWER',4, 175, '12.00');
insert into producttypes (idproducttypes,name, measuretype_idmeasuretype, quantity, price) values (5,'Jugo energetico POWER',6, 225, '14.00');

---------------inventory---------------
insert into inventory (idinventory, producttypes_idproducttypes, amountinstock, reorderpoint, restockdate)
values (1, 1, 22, '2022-01-01', '2022-04-22');
insert into inventory (idinventory, producttypes_idproducttypes, amountinstock, reorderpoint, restockdate)
values (2, 2, 22, '2021-12-28', '2022-03-30');
insert into inventory (idinventory, producttypes_idproducttypes, amountinstock, reorderpoint, restockdate)
values (3, 3, 10, '2022-01-01', '2022-04-22');
insert into inventory (idinventory, producttypes_idproducttypes, amountinstock, reorderpoint, restockdate)
values (4, 4, 8, '2022-01-01', '2022-02-22');
insert into inventory (idinventory, producttypes_idproducttypes, amountinstock, reorderpoint, restockdate)
values (5, 5, 3, '2022-01-01', '2022-03-22');

---------------Sales---------------
insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (1, '2022-01-01  08:11:03', 1, 2);
insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (2, '2022-04-01', 2, 1);
insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (3, '2022-04-01 10:33:00', 2, 1);
insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (4, '2022-04-01 10:40:05', 2, 3);
 insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (5, '2022-01-05 10:00:00', 3, 2);
     insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (6, '2022-01-05 12:00:00', 3, 1);
     insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (7, '2022-01-05 13:11:01', 4, 1);
     insert into sales (idsales, datesale, producttypes_idproducttypes, units) 
	values (8, '2022-01-05 15:00:03', 5, 1);


---------------membershiptypes---------------
insert into membershiptypes (idmembershiptypes, name, cost, createon, duration)
	values(1, 'Basic', 250.00, '2022-01-01 12:00:00', 2);
insert into membershiptypes (idmembershiptypes, name, cost, createon, duration)
	values(2, 'Ultra basic', 200.00, '2022-01-01 12:00:00', 1);
insert into membershiptypes (idmembershiptypes, name, cost, createon, duration)
	values(3, 'Medium', 500.00, '2022-01-01 12:10:00', 3);
insert into membershiptypes (idmembershiptypes, name, cost, createon, duration)
	values(4, 'High level', 750.00, '2022-01-01 12:20:00', 6);    
insert into membershiptypes (idmembershiptypes, name, cost, createon, duration)
	values(5, 'Premium', 1000.00, '2022-01-01 12:13:00', 12);
  
 --------------cities--------------
insert into cities (idcities, name) values (1, 'Alabama');
insert into cities (idcities, name) values (2, 'Alaska');
insert into cities (idcities, name) values (3, 'Arizona');
insert into cities (idcities, name) values (4, 'Arkansas');
insert into cities (idcities, name) values (5, 'California');
insert into cities (idcities, name) values (6, 'Colorado');
insert into cities (idcities, name) values (7, 'Connecticut');
insert into cities (idcities, name) values (8, 'Delaware');
insert into cities (idcities, name) values (9, 'District Of Columbia');
insert into cities (idcities, name) values (10, 'Florida');
insert into cities (idcities, name) values (11, 'Georgia');
insert into cities (idcities, name) values (12, 'Hawaii');
insert into cities (idcities, name) values (13, 'Idaho');
insert into cities (idcities, name) values (14, 'Illinois');
insert into cities (idcities, name) values (15, 'Indiana');
insert into cities (idcities, name) values (16, 'Iowa');
insert into cities (idcities, name) values (17, 'Kansas');

-- --------------Members------------
	INSERT INTO `gymmanager2`.`members`(`idmembers`,`name`,`lastname`,`birthday`,`email`,`allownewsletter`,`cities_idcities`,`membershiptypes_idmembershiptypes`)
VALUES
(1,'Sofia','Carrillo','2001-04-22','sofia@gmail.com',1,2,2);
INSERT INTO `gymmanager2`.`members`(`idmembers`,`name`,`lastname`,`birthday`,`email`,`allownewsletter`,`cities_idcities`,`membershiptypes_idmembershiptypes`)
VALUES
(2,'Ángel','May','1999-05-12','angelmay@gmail.com',1,3,1);
INSERT INTO `gymmanager2`.`members`(`idmembers`,`name`,`lastname`,`birthday`,`email`,`allownewsletter`,`cities_idcities`,`membershiptypes_idmembershiptypes`)
VALUES
(3,'César','Smith','2001-04-22','cesarsmith@gmail.com',1,3,3);
INSERT INTO `gymmanager2`.`members`(`idmembers`,`name`,`lastname`,`birthday`,`email`,`allownewsletter`,`cities_idcities`,
`membershiptypes_idmembershiptypes`)
VALUES
(4,'Ariatne','Moo','2001-01-18','ariatnemoo@gmail.com',0,6,4);
INSERT INTO `gymmanager2`.`members`(`idmembers`,`name`,`lastname`,`birthday`,`email`,`allownewsletter`,`cities_idcities`,`membershiptypes_idmembershiptypes`)
VALUES
(5,'Ruben','Martínez','1998-11-30','rubenmartinez@gmail.com',0,11,5);

-- ----------Roles------------------
insert into roles (idroles, name) values (1, 'Administrador');
insert into roles (idroles, name) values (2, 'Instructor');
insert into roles (idroles, name) values (3, 'Cajero');
insert into roles (idroles, name) values (4, 'Otro');
insert into roles (idroles, name) values (5, 'Promotor');

---users----
INSERT INTO `gymmanager2`.`users`
(`idusers`,`name`,`lastname`,`birthday`,`email`,`cities_idcities`)
VALUES
(1,'Abigail','Ek','2001-04-22','abigail@gmail.com','5');
INSERT INTO `gymmanager2`.`users`
(`idusers`,`name`,`lastname`,`birthday`,`email`,`cities_idcities`)
VALUES
(2,'Armando','Santos','2000-02-22','armandosantos@gmail.com','6');
INSERT INTO `gymmanager2`.`users`
(`idusers`,`name`,`lastname`,`birthday`,`email`,`cities_idcities`)
VALUES
(3,'Teresa','Balam','1997-07-18','teresabalam@gmail.com','7');
INSERT INTO `gymmanager2`.`users`
(`idusers`,`name`,`lastname`,`birthday`,`email`,`cities_idcities`)
VALUES
(4,'Beatriz','Cardoza','1980-09-10','beatrizcardoza@gmail.com','8');
INSERT INTO `gymmanager2`.`users`
(`idusers`,`name`,`lastname`,`birthday`,`email`,`cities_idcities`)
VALUES
(5,'Maria','Calderón','1988-05-22','maria22@gmail.com','9');


-----users in roles---
insert into usersinroles (idusersinroles, users_idusers, roles_idroles) values (1, 1, 5);
insert into usersinroles (idusersinroles, users_idusers, roles_idroles) values (2, 2, 4);
insert into usersinroles (idusersinroles, users_idusers, roles_idroles) values (3, 3, 3);
insert into usersinroles (idusersinroles, users_idusers, roles_idroles) values (4, 4, 2);
insert into usersinroles (idusersinroles, users_idusers, roles_idroles) values (5, 5, 1);
