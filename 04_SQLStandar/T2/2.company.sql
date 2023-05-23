CREATE TABLE company 
(
	idcompany int not null, 
    companyname varchar(100) not null,
    createdon datetime,
    primary key(idcompany)
);

alter TABLE company
add column
(
	location char(2)
);

alter TABLE company
drop column createdon;

