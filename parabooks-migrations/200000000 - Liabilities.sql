SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, name, normal_id, nominal) VALUES (2, 'Liabilities', 1, 0);
	INSERT INTO account_types (id, parent_id, name) VALUES (21, 2, 'Current Liabilities');
		INSERT INTO account_types (id, parent_id, name) VALUES (211, 21, 'Notes Payable - Current');

		INSERT INTO account_types (id, parent_id, name) VALUES (212, 21, 'Taxes');
			INSERT INTO account_types (id, parent_id, name) VALUES (2121, 212, 'Sales Taxes');
			INSERT INTO account_types (id, parent_id, name) VALUES (2122, 212, 'Payroll Taxes');
				INSERT INTO account_types (id, parent_id, name) VALUES (21221, 2122, 'Income Taxes Withheld');
				INSERT INTO account_types (id, parent_id, name) VALUES (21222, 2122, 'Social Security Withheld');
				INSERT INTO account_types (id, parent_id, name) VALUES (21223, 2122, 'Medicare Withheld');
				INSERT INTO account_types (id, parent_id, name) VALUES (21224, 2122, 'SUTA');
				INSERT INTO account_types (id, parent_id, name) VALUES (21225, 2122, 'FUTA');

	INSERT INTO account_types (id, parent_id, name) VALUES (22, 2, 'Long-Term Liabilities');
		INSERT INTO account_types (id, parent_id, name) VALUES (221, 22, 'Notes Payable - Long-Term');

SET IDENTITY_INSERT account_types OFF;




