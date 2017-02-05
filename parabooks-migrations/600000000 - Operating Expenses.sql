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

SET IDENTITY_INSERT accounts ON;
--Operating Expenses/General Expenses
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (60100, 61, 1, 'Services'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60110, 61, 60100, 1, 'Information Technology'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60111, 61, 60110, 1, 'Domains'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60112, 61, 60110, 1, 'Servers'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60113, 61, 60110, 1, 'Email'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60114, 61, 60110, 1, 'Online Services'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60120, 61, 60100, 1, 'Payroll Fees'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60130, 61, 60100, 1, 'Financial'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60131, 61, 60130, 1, 'Bank Fees'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60132, 61, 60130, 1, 'Wire Transfer Fees'); 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60133, 61, 60130, 1, 'Credit Card Processing Fees'); 
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (60200, 61, 1, 'Rent'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60210, 61, 60200, 1, 'Mail Boxes'); 
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (60300, 61, 1, 'Telephone'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60310, 61, 60300, 1, 'Cell Phones'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60320, 61, 60300, 1, 'PBX Service'); 
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (60400, 61, 1, 'Advertising'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60410, 61, 60400, 1, 'Business Cards'); 
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (60500, 61, 1, 'Office Supplies'); 
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (60600, 61, 1, 'Permits And Licenses'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60610, 61, 60600, 1, 'Federal'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60620, 61, 60600, 1, 'State'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60630, 61, 60600, 1, 'County'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (60640, 61, 60600, 1, 'City'); 
SET IDENTITY_INSERT accounts OFF;
