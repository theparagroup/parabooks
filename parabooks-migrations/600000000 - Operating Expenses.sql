SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, name, normal_id, nominal) VALUES (6, 'Operating Expenses', 0, 1);

	INSERT INTO account_types (id, parent_id, name) VALUES (61, 6, 'General Expenses');
		INSERT INTO account_types (id, parent_id, name) VALUES (611, 61, 'Payroll');
			INSERT INTO account_types (id, parent_id, name) VALUES (6111, 611, 'Gross Wages');
			INSERT INTO account_types (id, parent_id, name) VALUES (6112, 611, 'Fringe Benefits');
			INSERT INTO account_types (id, parent_id, name) VALUES (6113, 611, 'Workers Compensation');
			INSERT INTO account_types (id, parent_id, name) VALUES (6114, 611, 'Social Security Match');
			INSERT INTO account_types (id, parent_id, name) VALUES (6115, 611, 'Medicare Match');
			INSERT INTO account_types (id, parent_id, name) VALUES (6116, 611, 'FUTA');
			INSERT INTO account_types (id, parent_id, name) VALUES (6117, 611, 'SUTA');
	INSERT INTO account_types (id, parent_id, name) VALUES (68, 6, 'Depreciation Expense');
	INSERT INTO account_types (id, parent_id, name) VALUES (69, 6, 'Amortization Expense');

SET IDENTITY_INSERT account_types OFF;

SET IDENTITY_INSERT accounts ON;
--Operating Expenses/General Expenses
INSERT INTO accounts (account_type_id, account_id, virtual, name) VALUES (61, 100, 1, 'Services'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 110, 61, 100, 1, 'Information Technology'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 111, 61, 110, 1, 'Domains'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 112, 61, 110, 1, 'Servers'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 113, 61, 110, 1, 'Email'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 114, 61, 110, 1, 'Online Services'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 120, 61, 100, 1, 'Payroll Fees'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 130, 61, 100, 1, 'Financial'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 131, 61, 130, 1, 'Bank Fees'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 132, 61, 130, 1, 'Wire Transfer Fees'); 
		INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 133, 61, 130, 1, 'Credit Card Processing Fees'); 
INSERT INTO accounts (account_type_id, account_id, virtual, name) VALUES (61, 200, 1, 'Rent'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 210, 61, 200, 1, 'Mail Boxes'); 
INSERT INTO accounts (account_type_id, account_id, virtual, name) VALUES (61, 300, 1, 'Telephone'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 310, 61, 300, 1, 'Cell Phones'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 320, 61, 300, 1, 'PBX Service'); 
INSERT INTO accounts (account_type_id, account_id, virtual, name) VALUES (61, 400, 1, 'Advertising'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 410, 61, 400, 1, 'Business Cards'); 
INSERT INTO accounts (account_type_id, account_id, virtual, name) VALUES (61, 500, 1, 'Office Supplies'); 
INSERT INTO accounts (account_type_id, account_id, virtual, name) VALUES (61, 600, 1, 'Permits And Licenses'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 610, 61, 600, 1, 'Federal'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 620, 61, 600, 1, 'State'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 630, 61, 600, 1, 'County'); 
	INSERT INTO accounts (account_type_id, account_id, parent_account_type_id, parent_account_id, virtual, name) VALUES (61, 640, 61, 600, 1, 'City'); 
SET IDENTITY_INSERT accounts OFF;
