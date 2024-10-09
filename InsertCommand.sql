SET SQL_SAFE_UPDATES = 0;
DELETE FROM productcategory;

-- Insert parent categories with ULID-specified id
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('tv', '01F8RQC8KPB8X3KPSF7K9W9XYF', 'electronics', NULL, 'Y', now(), now()),
('couch', '01F8RR4GJRZRX5YJ1JEC1R91CX', 'home essentials', NULL, 'Y', now(), now()),
('tshirt', '01F8RR5TXXGGNADQRAEZSPJF6M', 'fashion', NULL, 'Y', now(), now()),
('appleAlt', '01F8RR7ZJYHC3Z6FYXYN2S0H5K', 'dry food', NULL, 'Y', now(), now());

-- Insert subcategories for electronics
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('mobileAlt', '01F8RR9BZ0VX1KP7NRD42RXC93', 'smartphones', '01F8RQC8KPB8X3KPSF7K9W9XYF', 'Y', now(), now()),
('laptop', '01F8RRBGHJKB8Z7H29QVEFY5PV', 'laptops', '01F8RQC8KPB8X3KPSF7K9W9XYF', 'Y', now(), now()),
('tv', '01F8RRCCYG6HPGB9MQ9XXKVCBZ', 'televisions', '01F8RQC8KPB8X3KPSF7K9W9XYF', 'Y', now(), now());

-- Insert subcategories for home essentials
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('bed', '01F8RRDD2BF1Z0MXJBJX8V75CM', 'furniture', '01F8RR4GJRZRX5YJ1JEC1R91CX', 'Y', now(), now()),
('blender', '01F8RREHHJXB5YZ99FSKGVVM0B', 'kitchen appliances', '01F8RR4GJRZRX5YJ1JEC1R91CX', 'Y', now(), now()),
('paintBrush', '01F8RRG1ACF9CWSJ8B1J3F48F2', 'home decor', '01F8RR4GJRZRX5YJ1JEC1R91CX', 'Y', now(), now());

-- Insert subcategories for fashion
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('male', '01F8RRHFV7GN2R7VHPJMGV1N8X', 'menswear', '01F8RR5TXXGGNADQRAEZSPJF6M', 'Y', now(), now()),
('female', '01F8RRJJTVPRBN5EX7P6RQE9GK', 'womenswear', '01F8RR5TXXGGNADQRAEZSPJF6M', 'Y', now(), now()),
('hatCowboy', '01F8RRKTZBJR41DZPW8FSVVRCZ', 'accessories', '01F8RR5TXXGGNADQRAEZSPJF6M', 'Y', now(), now());

-- Insert subcategories for dry food
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('wheat', '01F8RRLTVVZ0SND7Q1R3E1BP7D', 'grains & cereals', '01F8RR7ZJYHC3Z6FYXYN2S0H5K', 'Y', now(), now()),
('cookie', '01F8RRMYSGND5NZDC3G8M8PXEJ', 'snacks', '01F8RR7ZJYHC3Z6FYXYN2S0H5K', 'Y', now(), now()),
('pepperHot', '01F8RRNHCHND4FN19XM0PCD9X2', 'spices & seasonings', '01F8RR7ZJYHC3Z6FYXYN2S0H5K', 'Y', now(), now());
