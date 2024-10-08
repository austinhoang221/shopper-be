DELETE FROM CATEGORY;
-- Insert parent categories with manually specified id
INSERT INTO CATEGORY (icon, id, name, parent_id, visible) VALUES
('icon-electronics.png', 'ELECTRONICS', 'electronics', NULL, 'Y'),
('icon-home.png', 'HOME_ESSENTIALS', 'home essentials', NULL, 'Y'),
('icon-fashion.png', 'FASHION', 'fashion', NULL, 'Y'),
('icon-food.png', 'DRY_FOOD', 'dry food', NULL, 'Y');

-- Insert subcategories for electronics
INSERT INTO CATEGORY (icon, id, name, parent_id, visible) VALUES
('icon-phone.png', 'SMARTPHONES', 'smartphones', 'ELECTRONICS', 'Y'),
('icon-laptop.png', 'LAPTOPS', 'laptops', 'ELECTRONICS', 'Y'),
('icon-tv.png', 'TELEVISIONS', 'televisions', 'ELECTRONICS', 'Y');

-- Insert subcategories for home essentials
INSERT INTO CATEGORY (icon, id, name, parent_id, visible) VALUES
('icon-furniture.png', 'FURNITURE', 'furniture', 'HOME_ESSENTIALS', 'Y'),
('icon-kitchen.png', 'KITCHEN_APPLIANCES', 'kitchen appliances', 'HOME_ESSENTIALS', 'Y'),
('icon-decor.png', 'HOME_DECOR', 'home decor', 'HOME_ESSENTIALS', 'Y');

-- Insert subcategories for fashion
INSERT INTO CATEGORY (icon, id, name, parent_id, visible) VALUES
('icon-menswear.png', 'MENSWEAR', 'menswear', 'FASHION', 'Y'),
('icon-womenswear.png', 'WOMENSWEAR', 'womenswear', 'FASHION', 'Y'),
('icon-accessories.png', 'ACCESSORIES', 'accessories', 'FASHION', 'Y');

-- Insert subcategories for dry food
INSERT INTO CATEGORY (icon, id, name, parent_id, visible) VALUES
('icon-grains.png', 'GRAINS_CEREALS', 'grains & cereals', 'DRY_FOOD', 'Y'),
('icon-snacks.png', 'SNACKS', 'snacks', 'DRY_FOOD', 'Y'),
('icon-spices.png', 'SPICES_SEASONINGS', 'spices & seasonings', 'DRY_FOOD', 'Y');
