DELETE FROM account_types;

SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, number, canonical_id, name, normal_id)								VALUES (100000, '100-000-000', 100, 'Assets', 0);
INSERT INTO account_types (id, parent_id, number, canonical_id, name)									VALUES (110000, 100000, '110-000-000', 110, 'Tangible Assets');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)										VALUES (111000, 110000, '111-000-000', 111, 'Current Assets');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (111100, 111000, '111-100-000', 1111, 'Checking');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (111110, 111100, '111-110-000', 'General');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (111120, 111100, '111-120-000', 'Payroll');
INSERT INTO account_types (id, parent_id, number, canonical_id,name)											VALUES (111200, 111000, '111-200-000', 1112, 'Saving');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (111300, 111000, '111-300-000', 1113, 'Accounts Receivable');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (111400, 111000, '111-400-000', 1114, 'Employee Advances');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (111500, 111000, '111-500-000', 1115, 'Notes Receivable');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (111510, 111500, '111-510-000', 'Loans to Equity Holders');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (111600, 111000, '111-600-000', 1116, 'Cash');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)										VALUES (112000, 110000, '112-000-000', 112, 'Fixed Assets');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (112100, 112000, '112-100-000', 'Equipment');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (112110, 112100, '112-110-000', 'Information Technology');
INSERT INTO account_types (id, parent_id, number, name)																	VALUES (101, 112110, '112-110-010', 'Hardware');
INSERT INTO account_types (id, parent_id, number, name)																	VALUES (102, 112110, '112-110-020', 'Software');
INSERT INTO account_types (id, parent_id, number, canonical_id, name, normal_id, contra)					VALUES (113000, 110000, '113-000-000', 113, 'Accumulated Depreciation', 1, 1);
INSERT INTO account_types (id, parent_id, number, canonical_id, name, normal_id, contra)					VALUES (114000, 110000, '114-000-000', 114, 'Accumulated Amortization', 1, 1);
INSERT INTO account_types (id, parent_id, number, canonical_id, name)										VALUES (115000, 110000, '115-000-000', 115, 'Other Assets');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (115100, 115000, '115-100-000', 1151, 'Notes Receivable');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)									VALUES (120000, 100000, '120-000-000', 120, 'Intangible Assets');




SET IDENTITY_INSERT account_types OFF;
