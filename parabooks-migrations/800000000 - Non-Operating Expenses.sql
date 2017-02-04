SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, name, normal_id, nominal) VALUES (8, 'Non-Operating Expenses', 0, 1);
	INSERT INTO account_types (id, parent_id, name) VALUES (89, 8, 'Start-Up Costs');


SET IDENTITY_INSERT account_types OFF;
