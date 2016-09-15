SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, number, canonical_id, name, normal_id, nominal)								VALUES (600000, '600-000-000', 600, 'Operating Expenses', 0, 1);

INSERT INTO account_types (id, parent_id, number, canonical_id, name)										VALUES (610000, 600000, '610-000-000', 610, 'General Expenses');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (610110, 610000, '610-110-000', 'Services');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610111, 610110, '610-111-000', 'Information Technology');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (601, 610111, '610-110-010', 'Domains');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (602, 610111, '610-110-020', 'Servers');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (603, 610111, '610-110-030', 'Email');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (604, 610111, '610-110-040', 'Online Services');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610112, 610110, '610-112-000', 'Payroll Fees');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610113, 610110, '610-113-000', 'Financial');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (605, 610113, '610-113-010', 'Bank Fees');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (606, 610113, '610-113-010', 'Wire Transfer Fees');
INSERT INTO account_types (id, parent_id, number, name)																		VALUES (607, 610113, '610-113-010', 'Credit Card Processing Fees');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (610120, 610000, '610-120-000', 'Rent');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610121, 610120, '610-121-000', 'Mail Boxes');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (610130, 610000, '610-130-000', 'Telephone');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610131, 610130, '610-131-000', 'Cell Phones');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610132, 610130, '610-132-000', 'PBX Service');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (610140, 610000, '610-140-000', 'Advertising');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610141, 610140, '610-141-000', 'Business Cards');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (610150, 610000, '610-150-000', 'Office Supplies');
INSERT INTO account_types (id, parent_id, number, name)															VALUES (610160, 610000, '610-160-000', 'Permits And Licenses');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610161, 610160, '610-161-000', 'Federal');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610162, 610160, '610-162-000', 'State');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610163, 610160, '610-163-000', 'County');
INSERT INTO account_types (id, parent_id, number, name)																VALUES (610164, 610160, '610-164-000', 'City');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (610170, 610000, '610-170-000', 61017, 'Payroll');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610171, 610170, '610-171-000', 610171, 'Gross Wages');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610172, 610170, '610-172-000', 610172, 'Fringe Benefits');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610173, 610170, '610-173-000', 610173, 'Workers Compensation');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610174, 610170, '610-174-000', 610174, 'Social Security Match');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610175, 610170, '610-175-000', 610175, 'Medicare Match');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610176, 610170, '610-176-000', 610176, 'FUTA');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)												VALUES (610177, 610170, '610-177-000', 610177, 'SUTA');


INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (680000, 600000, '680-000-000', 680, 'Depreciation Expense');
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (690000, 600000, '690-000-000', 690, 'Amortization Expense');




SET IDENTITY_INSERT account_types OFF;
