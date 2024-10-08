SET SQL_SAFE_UPDATES = 0;
DELETE FROM productcategory;
-- Insert parent categories with manually specified id
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('tv', 'ELECTRONICS', 'electronics', NULL, 'Y', now(), now()),
('couch', 'HOME_ESSENTIALS', 'home essentials', NULL, 'Y', now(), now()),
('tshirt', 'FASHION', 'fashion', NULL, 'Y', now(), now()),
('appleAlt', 'DRY_FOOD', 'dry food', NULL, 'Y', now(), now());

-- Insert subcategories for electronics
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('mobileAlt', 'SMARTPHONES', 'smartphones', 'ELECTRONICS', 'Y', now(), now()),
('laptop', 'LAPTOPS', 'laptops', 'ELECTRONICS', 'Y', now(), now()),
('tv', 'TELEVISIONS', 'televisions', 'ELECTRONICS', 'Y', now(), now());

-- Insert subcategories for home essentials
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('bed', 'FURNITURE', 'furniture', 'HOME_ESSENTIALS', 'Y', now(), now()),
('blender', 'KITCHEN_APPLIANCES', 'kitchen appliances', 'HOME_ESSENTIALS', 'Y', now(), now()),
('paintBrush', 'HOME_DECOR', 'home decor', 'HOME_ESSENTIALS', 'Y', now(), now());

-- Insert subcategories for fashion
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('male', 'MENSWEAR', 'menswear', 'FASHION', 'Y', now(), now()),
('female', 'WOMENSWEAR', 'womenswear', 'FASHION', 'Y', now(), now()),
('hatCowboy', 'ACCESSORIES', 'accessories', 'FASHION', 'Y', now(), now());

-- Insert subcategories for dry food
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('wheat', 'GRAINS_CEREALS', 'grains & cereals', 'DRY_FOOD', 'Y', now(), now()),
('cookie', 'SNACKS', 'snacks', 'DRY_FOOD', 'Y', now(), now()),
('pepperHot', 'SPICES_SEASONINGS', 'spices & seasonings', 'DRY_FOOD', 'Y', now(), now());
