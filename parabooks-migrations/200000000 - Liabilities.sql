SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, number, canonical, name, normal_id)								VALUES (200000, '200-000-000', 1, 'Liabilities', 1);

INSERT INTO account_types (id, parent_id, number, canonical, name)									VALUES (210000, 200000, '210-000-000', 1, 'Current Liabilities');
INSERT INTO account_types (id, parent_id, number, name)													VALUES (211000, 210000, '211-000-000', 'Notes Payable');
INSERT INTO account_types (id, parent_id, number, name)														VALUES (211100, 210000, '211-100-000', 'Loans to Officers');

INSERT INTO account_types (id, parent_id, number, canonical, name)									VALUES (220000, 200000, '220-000-000', 1, 'Long-Term Liabilities');
INSERT INTO account_types (id, parent_id, number, name)													VALUES (221000, 220000, '221-000-000', 'Notes Payable');
INSERT INTO account_types (id, parent_id, number, name)														VALUES (221100, 210000, '221-100-000', 'Loans to Officers');




SET IDENTITY_INSERT account_types OFF;
