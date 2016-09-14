SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, number, canonical_id, name, normal_id)								VALUES (200000, '200-000-000', 200, 'Liabilities', 1);

INSERT INTO account_types (id, parent_id, number, canonical_id, name)									VALUES (210000, 200000, '210-000-000', 210, 'Current Liabilities');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)										VALUES (211000, 210000, '211-000-000', 211, 'Notes Payable - Current');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (211100, 211000, '211-100-000', 'Loans from Equity Holders');
INSERT INTO account_types (id, parent_id, number, name)													VALUES (212000, 210000, '212-000-000', 'Taxes');
INSERT INTO account_types (id, parent_id, number, name)														VALUES (212100, 212000, '212-100-000', 'Sales Taxes');
INSERT INTO account_types (id, parent_id, number, name)														VALUES (212200, 212000, '212-200-000', 'Payroll Taxes');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (212210, 212200, '212-210-000', 'Income Taxes Withheld');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (212220, 212200, '212-220-000', 'Social Security Withheld');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (212230, 212200, '212-230-000', 'Medicare Withheld');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (212240, 212200, '212-240-000', 'SUTA');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (212250, 212200, '212-250-000', 'FUTA');

INSERT INTO account_types (id, parent_id, number, canonical_id, name)									VALUES (220000, 200000, '220-000-000', 220, 'Long-Term Liabilities');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)										VALUES (221000, 220000, '221-000-000', 221, 'Notes Payable - Long-Term');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (221100, 221000, '221-100-000', 'Loans from Equity Holders');




SET IDENTITY_INSERT account_types OFF;
