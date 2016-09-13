SET IDENTITY_INSERT account_types ON;

INSERT INTO account_types (id, number, canonical_id, name, normal_id, nominal)								VALUES (400000, '400-000-000', 400, 'Operating Income', 1, 1);
INSERT INTO account_types (id, parent_id, number, canonical_id, name)											VALUES (410000, 400000, '410-000-000', 400, 'Revenue');




SET IDENTITY_INSERT account_types OFF;
