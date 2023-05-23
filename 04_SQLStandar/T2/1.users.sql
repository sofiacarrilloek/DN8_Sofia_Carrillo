CREATE TABLE users (
  iduser int NOT NULL,
  username varchar(100) NOT NULL,
  email varchar(500) DEFAULT NULL,
  PRIMARY KEY (iduser)
);

alter TABLE users
add column
(
	idcompany int not null
);

alter TABLE users
ADD CONSTRAINT company_users
	FOREIGN KEY (idcompany)
    REFERENCES company (idcompany);

alter TABLE users
ADD INDEX company_users_idx (idcompany ASC) VISIBLE;