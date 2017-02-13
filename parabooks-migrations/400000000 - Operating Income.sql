SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, name, normal_id, nominal) VALUES (4, 'Operating Income', 1, 1); --credit normal
	INSERT INTO account_types (id, parent_id, name) VALUES (41, 4, 'Revenue');


SET IDENTITY_INSERT account_types OFF;
