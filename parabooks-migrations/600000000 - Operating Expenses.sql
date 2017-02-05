SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id,  name, normal_id, nominal) VALUES (6, 'Operating Expenses', 0, 1);

	INSERT INTO account_types (id,  parent_id, name) VALUES (61, 6, 'General Expenses');
		INSERT INTO account_types (id,  parent_id, name) VALUES (611, 61, 'Payroll');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6111, 611, 'Gross Wages');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6112, 611, 'Fringe Benefits');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6113, 611, 'Workers Compensation');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6114, 611, 'Social Security Match');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6115, 611, 'Medicare Match');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6116, 611, 'FUTA');
			INSERT INTO account_types (id,  parent_id, name) VALUES (6117, 611, 'SUTA');
	INSERT INTO account_types (id,  parent_id, name) VALUES (68, 6, 'Depreciation Expense');
	INSERT INTO account_types (id,  parent_id, name) VALUES (69, 6, 'Amortization Expense');

SET IDENTITY_INSERT account_types OFF;

