DELETE FROM account_types;

SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, name, normal_id, nominal) VALUES (1, 'Assets', 0, 0);
	INSERT INTO account_types (id, parent_id, name) VALUES (11, 1, 'Tangible Assets');
		INSERT INTO account_types (id, parent_id, name) VALUES (111, 11, 'Current Assets');
			INSERT INTO account_types (id, parent_id, name) VALUES (1111, 111, 'Checking');
			INSERT INTO account_types (id, parent_id, name) VALUES (1112, 111, 'Saving');
			INSERT INTO account_types (id, parent_id, name) VALUES (1113, 111, 'Accounts Receivable');
			INSERT INTO account_types (id, parent_id, name) VALUES (1114, 111, 'Employee Advances');
			INSERT INTO account_types (id, parent_id, name) VALUES (1115, 111, 'Notes Receivable');
			INSERT INTO account_types (id, parent_id, name) VALUES (1116, 111, 'Cash');
		INSERT INTO account_types (id, parent_id, name) VALUES (112, 11, 'Fixed Assets');
			INSERT INTO account_types (id, parent_id, name) VALUES (1121, 112, 'Equipment');
		INSERT INTO account_types (id, parent_id, name, normal_id, contra) VALUES (113, 11, 'Accumulated Depreciation', 1, 1);
		INSERT INTO account_types (id, parent_id, name, normal_id, contra) VALUES (114, 11, 'Accumulated Amortization', 1, 1);
		INSERT INTO account_types (id, parent_id, name) VALUES (115, 11, 'Long-Term Assets');
			INSERT INTO account_types (id, parent_id, name) VALUES (1151, 115, 'Notes Receivable');
		INSERT INTO account_types (id, parent_id, name) VALUES (116, 11, 'Other Assets');
	INSERT INTO account_types (id, parent_id, name) VALUES (12, 1, 'Intangible Assets');

SET IDENTITY_INSERT account_types OFF;


SET IDENTITY_INSERT accounts ON;
--Assets/Tangible/Current/Checking
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (10100, 1111, 1, 'General'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (10110, 1111, 10100, 0, 'First Tennessee'); --non-virtual test
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (10200, 1111, 1, 'Payroll');

--Assets/Tangible/Current/Notes Receivable
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (10300, 1115, 1, 'Loans to Equity Holders'); 
	INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (10310, 113, 10300, 0, 'Accumulated Loan'); --link test 
		INSERT INTO accounts (id, account_type_id, parent_id, virtual, name) VALUES (10311, 113, 10310, 0, 'Accumulated Loan2'); --link test 

--Assets/Tangible/Fixed/Equipment
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (10400, 1121, 1, 'Hardware'); 
INSERT INTO accounts (id, account_type_id, virtual, name) VALUES (10500, 1121, 1, 'Software'); 

SET IDENTITY_INSERT accounts OFF;




