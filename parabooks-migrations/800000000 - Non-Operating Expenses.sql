SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, number, canonical_id, name, normal_id, nominal)								VALUES (800000, '800-000-000', 800, 'Non-Operating Expenses', 0, 1);
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (890000, 800000, '890-000-000', 890, 'Start-Up Costs');




SET IDENTITY_INSERT account_types OFF;
