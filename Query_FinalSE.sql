use FinalProjectDB

go

CREATE TABLE Login_Management (
    username varchar(20),
    password varchar(20),
    role varchar(10),
);

go

INSERT INTO Login_Management (username, password, role)
					  VALUES ('admin', 'admin', 'admin'),
							 ('agent', 'agent', 'agent');

