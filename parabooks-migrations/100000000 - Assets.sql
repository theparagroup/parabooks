﻿DELETE FROM account_types;

SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, name, normal_id, nominal) VALUES (1, 'Assets', 0, 0); --debit normal
	INSERT INTO account_types (id, parent_id, name) VALUES (11, 1, 'Tangible Assets');
		INSERT INTO account_types (id, parent_id, name) VALUES (111, 11, 'Current Assets');
			INSERT INTO account_types (id, parent_id, name) VALUES (1111, 111, 'Checking');
			INSERT INTO account_types (id, parent_id, name) VALUES (1112, 111, 'Saving');
			INSERT INTO account_types (id, parent_id, name) VALUES (1113, 111, 'Accounts Receivable');
			INSERT INTO account_types (id, parent_id, name) VALUES (1114, 111, 'Employee Advances');
			INSERT INTO account_types (id, parent_id, name) VALUES (1115, 111, 'Notes Receivable - Current');
			INSERT INTO account_types (id, parent_id, name) VALUES (1116, 111, 'Cash');
		INSERT INTO account_types (id, parent_id, name) VALUES (112, 11, 'Fixed Assets');
		INSERT INTO account_types (id, parent_id, name, contra) VALUES (113, 11, 'Accumulated Depreciation', 1); --debit normal but contra (always has a negative or zero balance)
			INSERT INTO account_types (id, parent_id, name, contra) VALUES (1131, 113, 'Section 179 Accumulated Depreciation', 1); -- section 179
		INSERT INTO account_types (id, parent_id, name, contra) VALUES (114, 11, 'Accumulated Amortization', 1); -- section 197 intangibles, spread over 15 years
		INSERT INTO account_types (id, parent_id, name) VALUES (115, 11, 'Long-Term Assets');
			INSERT INTO account_types (id, parent_id, name) VALUES (1151, 115, 'Notes Receivable - Long-Term');
		INSERT INTO account_types (id, parent_id, name) VALUES (116, 11, 'Other Assets');
	INSERT INTO account_types (id, parent_id, name) VALUES (12, 1, 'Intangible Assets');

SET IDENTITY_INSERT account_types OFF;
