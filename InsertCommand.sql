SET SQL_SAFE_UPDATES = 0;
DELETE FROM productcategory;
-- Insert parent categories with manually specified id
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('tv', '085f33ac-8700-11ef-82d7-089798dd3457', 'electronics', NULL, 'Y', now(), now()),
('couch', '17f6f4eb-8700-11ef-82d7-089798dd3457', 'home essentials', NULL, 'Y', now(), now()),
('tshirt', '25a71555-8700-11ef-82d7-089798dd3457', 'fashion', NULL, 'Y', now(), now()),
('appleAlt', '3c0e3fbc-8700-11ef-82d7-089798dd3457', 'dry food', NULL, 'Y', now(), now());

-- Insert subcategories for electronics
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('mobileAlt', '60be417e-8700-11ef-82d7-089798dd3457', 'smartphones', '085f33ac-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('laptop', 'c3af7e72-8700-11ef-82d7-089798dd3457', 'laptops', '085f33ac-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('tv', 'd99e7b08-8700-11ef-82d7-089798dd3457', 'televisions', '085f33ac-8700-11ef-82d7-089798dd3457', 'Y', now(), now());

-- Insert subcategories for home essentials
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('bed', 'eb0695f1-8700-11ef-82d7-089798dd3457', 'furniture', '17f6f4eb-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('blender', 'feb94c76-8700-11ef-82d7-089798dd3457', 'kitchen appliances', '17f6f4eb-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('paintBrush', '47078eb9-8701-11ef-82d7-089798dd3457', 'home decor', '17f6f4eb-8700-11ef-82d7-089798dd3457', 'Y', now(), now());

-- Insert subcategories for fashion
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('male', '5df4d58f-8701-11ef-82d7-089798dd3457', 'menswear', '25a71555-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('female', '89b663da-8701-11ef-82d7-089798dd3457', 'womenswear', '25a71555-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('hatCowboy', '9bd16c9b-8701-11ef-82d7-089798dd3457', 'accessories', '25a71555-8700-11ef-82d7-089798dd3457', 'Y', now(), now());

-- Insert subcategories for dry food
INSERT INTO productcategory (icon, id, name, ParentId, visible, CreationTime, LastModificationTime) VALUES
('wheat', 'a8120ea3-8701-11ef-82d7-089798dd3457', 'grains & cereals', '3c0e3fbc-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('cookie', 'b50b47f7-8701-11ef-82d7-089798dd3457', 'snacks', '3c0e3fbc-8700-11ef-82d7-089798dd3457', 'Y', now(), now()),
('pepperHot', 'c78cf498-8701-11ef-82d7-089798dd3457', 'spices & seasonings', '3c0e3fbc-8700-11ef-82d7-089798dd3457', 'Y', now(), now());

DELETE FROM product;
-- Insert 10 products for SMARTPHONES category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('5368d01a-8702-11ef-82d7-089798dd3457', '60be417e-8700-11ef-82d7-089798dd3457', 300.00, 'iPhone 13', 'IPH13', 800.00, 50, 'uuid()', 'Latest model', 'pcs', 0.2, now(), now()),
('63966101-8702-11ef-82d7-089798dd3457', '60be417e-8700-11ef-82d7-089798dd3457', 250.00, 'Samsung Galaxy S21', 'SGS21', 700.00, 40, 'uuid()', 'Flagship model', 'pcs', 0.25, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 200.00, 'Google Pixel 6', 'GPX6', 600.00, 30, 'uuid()', 'Newest Pixel phone', 'pcs', 0.23, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 150.00, 'OnePlus 9', 'OP9', 550.00, 25, 'uuid()', 'High-performance smartphone', 'pcs', 0.24, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 120.00, 'Xiaomi Mi 11', 'XM11', 500.00, 35, 'uuid()', 'Affordable flagship', 'pcs', 0.21, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 400.00, 'iPhone 14', 'IPH14', 900.00, 60, 'uuid()', 'Next-gen iPhone', 'pcs', 0.2, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 350.00, 'Samsung Galaxy Z Fold', 'SGZF', 1500.00, 20, 'uuid()', 'Foldable phone', 'pcs', 0.3, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 280.00, 'Sony Xperia 5', 'SX5', 750.00, 30, 'uuid()', 'High-res camera phone', 'pcs', 0.22, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 160.00, 'Motorola Edge 20', 'ME20', 600.00, 25, 'uuid()', 'Curved edge display', 'pcs', 0.23, now(), now()),
('uuid()', '60be417e-8700-11ef-82d7-089798dd3457', 180.00, 'Realme GT', 'RGT', 500.00, 45, 'uuid()', 'Flagship killer', 'pcs', 0.22, now(), now());

-- Insert 10 products for LAPTOPS category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('77f4baea-8702-11ef-82d7-089798dd3457', 'c3af7e72-8700-11ef-82d7-089798dd3457', 500.00, 'MacBook Air', 'MBAIR', 1200.00, 30, 'uuid()', 'Ultra-thin laptop', 'pcs', 1.2, now(), now()),
('99a4a35c-8702-11ef-82d7-089798dd3457', 'c3af7e72-8700-11ef-82d7-089798dd3457', 600.00, 'Dell XPS 13', 'DXPS13', 1400.00, 25, 'uuid()', 'Compact performance', 'pcs', 1.3, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 450.00, 'HP Spectre x360', 'HPSX360', 1300.00, 20, 'uuid()', 'Convertible laptop', 'pcs', 1.5, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 300.00, 'Lenovo ThinkPad X1', 'LTX1', 1000.00, 35, 'uuid()', 'Business laptop', 'pcs', 1.4, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 400.00, 'Asus ZenBook 14', 'AZB14', 1100.00, 40, 'uuid()', 'Lightweight ultrabook', 'pcs', 1.2, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 250.00, 'Acer Swift 3', 'ASF3', 800.00, 50, 'uuid()', 'Affordable ultrabook', 'pcs', 1.1, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 350.00, 'Microsoft Surface Laptop', 'MSL', 1300.00, 20, 'uuid()', 'Touchscreen laptop', 'pcs', 1.3, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 420.00, 'Razer Blade 15', 'RB15', 2000.00, 15, 'uuid()', 'Gaming laptop', 'pcs', 2.0, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 320.00, 'LG Gram 17', 'LGG17', 1500.00, 25, 'uuid()', 'Ultra-light laptop', 'pcs', 1.35, now(), now()),
('uuid()', 'c3af7e72-8700-11ef-82d7-089798dd3457', 270.00, 'Huawei MateBook X Pro', 'HMXP', 1400.00, 30, 'uuid()', 'Sleek premium laptop', 'pcs', 1.4, now(), now());

-- Insert 10 products for TELEVISIONS category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('c017ed18-8702-11ef-82d7-089798dd3457', 'd99e7b08-8700-11ef-82d7-089798dd3457', 800.00, 'Samsung QLED 65"', 'SQ65', 1600.00, 20, 'uuid()', '4K QLED Smart TV', 'pcs', 25, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 900.00, 'LG OLED 55"', 'LO55', 1800.00, 15, 'uuid()', '4K OLED Smart TV', 'pcs', 20, now(), now()),
('b26a5414-8702-11ef-82d7-089798dd3457', 'd99e7b08-8700-11ef-82d7-089798dd3457', 1200.00, 'Sony Bravia 75"', 'SB75', 2400.00, 10, 'uuid()', '75-inch 4K Ultra HD', 'pcs', 30, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 350.00, 'TCL Roku 50"', 'TR50', 700.00, 40, 'uuid()', '4K Roku TV', 'pcs', 15, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 700.00, 'Panasonic Viera 65"', 'PV65', 1500.00, 25, 'uuid()', '4K Smart TV', 'pcs', 22, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 1000.00, 'Vizio P-Series 75"', 'VPS75', 2200.00, 18, 'uuid()', '75-inch 4K HDR TV', 'pcs', 28, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 500.00, 'Hisense ULED 55"', 'HU55', 1000.00, 30, 'uuid()', '55-inch 4K ULED TV', 'pcs', 18, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 750.00, 'Philips Ambilight 65"', 'PA65', 1600.00, 12, 'uuid()', '65-inch 4K TV with Ambilight', 'pcs', 23, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 850.00, 'Sharp Aquos 70"', 'SA70', 1700.00, 14, 'uuid()', '70-inch 4K Smart TV', 'pcs', 27, now(), now()),
('uuid()', 'd99e7b08-8700-11ef-82d7-089798dd3457', 300.00, 'Toshiba Fire TV 50"', 'TFT50', 600.00, 50, 'uuid()', '50-inch Fire TV Edition', 'pcs', 15, now(), now());

-- Insert 10 products for FURNITURE category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('OFFICE_CHAIR', 'eb0695f1-8700-11ef-82d7-089798dd3457', 60.00, 'Office Chair', 'OC123', 150.00, 50, 'uuid()', 'Ergonomic office chair', 'pcs', 15, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 90.00, 'Bookshelf', 'BS123', 200.00, 30, 'uuid()', '5-shelf wooden unit', 'pcs', 40, now(), now()),
('e3a204e7-8702-11ef-82d7-089798dd3457', 'eb0695f1-8700-11ef-82d7-089798dd3457', 200.00, 'King Size Bed', 'KSB123', 400.00, 5, 'uuid()', 'Comfort mattress included', 'pcs', 70, now(), now()),
('d70d7801-8702-11ef-82d7-089798dd3457', 'eb0695f1-8700-11ef-82d7-089798dd3457', 50.00, 'Coffee Table', 'CT123', 120.00, 25, 'uuid()', 'Compact coffee table', 'pcs', 25, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 100.00, 'Armchair', 'AC123', 220.00, 15, 'uuid()', 'Stylish and comfortable armchair', 'pcs', 20, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 140.00, 'Wardrobe', 'W123', 300.00, 8, 'uuid()', '3-door wardrobe', 'pcs', 80, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 60.00, 'TV Stand', 'TVS123', 130.00, 18, 'uuid()', 'Modern TV unit', 'pcs', 30, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 110.00, 'Recliner', 'RC123', 250.00, 12, 'uuid()', 'Comfortable recliner', 'pcs', 45, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 180.00, 'Dining Table', 'DT123', 400.00, 10, 'uuid()', 'Wooden dining table', 'pcs', 50, now(), now()),
('uuid()', 'eb0695f1-8700-11ef-82d7-089798dd3457', 40.00, 'Nightstand', 'NS123', 80.00, 20, 'uuid()', 'Wooden nightstand', 'pcs', 15, now(), now());

-- Insert 10 products for KITCHEN_APPLIANCES category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('f2bec440-8702-11ef-82d7-089798dd3457', 'feb94c76-8700-11ef-82d7-089798dd3457', 30.00, 'Blender', 'BL123', 80.00, 40, 'uuid()', 'High-speed blender', 'pcs', 3, now(), now()),
('0946a213-8703-11ef-82d7-089798dd3457', 'feb94c76-8700-11ef-82d7-089798dd3457', 100.00, 'Microwave Oven', 'MO123', 200.00, 25, 'uuid()', '1000W microwave', 'pcs', 15, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 50.00, 'Air Fryer', 'AF123', 150.00, 35, 'uuid()', 'Healthy air fryer', 'pcs', 8, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 40.00, 'Rice Cooker', 'RC123', 90.00, 30, 'uuid()', 'Automatic rice cooker', 'pcs', 5, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 120.00, 'Coffee Machine', 'CM123', 250.00, 20, 'uuid()', 'Espresso coffee machine', 'pcs', 10, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 20.00, 'Toaster', 'TS123', 50.00, 50, 'uuid()', '2-slice toaster', 'pcs', 2, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 60.00, 'Juicer', 'JC123', 120.00, 25, 'uuid()', 'Cold press juicer', 'pcs', 6, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 300.00, 'Dishwasher', 'DW123', 600.00, 15, 'uuid()', 'Automatic dishwasher', 'pcs', 40, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 80.00, 'Induction Cooker', 'IC123', 180.00, 22, 'uuid()', 'Portable induction cooker', 'pcs', 10, now(), now()),
('uuid()', 'feb94c76-8700-11ef-82d7-089798dd3457', 25.00, 'Electric Kettle', 'EK123', 60.00, 45, 'uuid()', 'Stainless steel electric kettle', 'pcs', 3, now(), now());

-- Insert 10 products for HOME_DECOR category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 15.00, 'Wall Clock', 'WC123', 45.00, 30, 'uuid()', 'Modern wall clock', 'pcs', 2, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 20.00, 'Table Lamp', 'TL123', 60.00, 40, 'uuid()', 'Stylish table lamp', 'pcs', 3, now(), now()),
('1d41d12f-8703-11ef-82d7-089798dd3457', '47078eb9-8701-11ef-82d7-089798dd3457', 10.00, 'Vase', 'VS123', 30.00, 50, 'uuid()', 'Ceramic decorative vase', 'pcs', 5, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 5.00, 'Photo Frame', 'PF123', 20.00, 100, 'uuid()', 'Wooden photo frame', 'pcs', 1, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 25.00, 'Curtains', 'CR123', 80.00, 20, 'uuid()', 'Blackout curtains', 'pcs', 4, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 50.00, 'Wall Art', 'WA123', 150.00, 10, 'uuid()', 'Abstract wall art piece', 'pcs', 10, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 60.00, 'Area Rug', 'AR123', 200.00, 15, 'uuid()', 'Large living room rug', 'pcs', 25, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 8.00, 'Candle Holder', 'CH123', 25.00, 60, 'uuid()', 'Decorative candle holder', 'pcs', 2, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 30.00, 'Mirror', 'MR123', 100.00, 20, 'uuid()', 'Framed wall mirror', 'pcs', 12, now(), now()),
('uuid()', '47078eb9-8701-11ef-82d7-089798dd3457', 12.00, 'Planter', 'PL123', 40.00, 35, 'uuid()', 'Indoor plant holder', 'pcs', 5, now(), now());

-- Insert 10 products for MENSWEAR category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 10.00, 'Cotton T-Shirt', 'CTS123', 25.00, 100, 'uuid()', 'Basic cotton t-shirt', 'pcs', 0.3, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 20.00, 'Slim Fit Jeans', 'SFJ123', 50.00, 60, 'uuid()', 'Slim fit denim jeans', 'pcs', 0.7, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 25.00, 'Hoodie', 'HD123', 60.00, 80, 'uuid()', 'Comfortable hoodie', 'pcs', 0.8, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 30.00, 'Formal Shirt', 'FS123', 75.00, 40, 'uuid()', 'Slim fit formal shirt', 'pcs', 0.4, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 20.00, 'Chinos', 'CH123', 55.00, 50, 'uuid()', 'Casual chinos', 'pcs', 0.5, now(), now()),
('53ac8d15-8703-11ef-82d7-089798dd3457', '5df4d58f-8701-11ef-82d7-089798dd3457', 50.00, 'Blazer', 'BZ123', 120.00, 25, 'H&M', 'uuid()', 'pcs', 1.2, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 15.00, 'Joggers', 'JG123', 40.00, 70, 'uuid()', 'Comfortable joggers', 'pcs', 0.6, now(), now()),
('29ece2d5-8703-11ef-82d7-089798dd3457', '5df4d58f-8701-11ef-82d7-089798dd3457', 80.00, 'Winter Jacket', 'WJ123', 200.00, 15, 'uuid()', 'Warm winter jacket', 'pcs', 1.5, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 20.00, 'Polo Shirt', 'PS123', 50.00, 90, 'uuid()', 'Classic polo shirt', 'pcs', 0.4, now(), now()),
('uuid()', '5df4d58f-8701-11ef-82d7-089798dd3457', 35.00, 'Sneakers', 'SN123', 90.00, 100, 'uuid()', 'Stylish sneakers', 'prs', 0.8, now(), now());

-- Insert 10 products for WOMENSWEAR category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('4b800266-8703-11ef-82d7-089798dd3457', '89b663da-8701-11ef-82d7-089798dd3457', 40.00, 'Silk Dress', 'SD123', 100.00, 30, 'uuid()', 'Elegant silk dress', 'pcs', 0.5, now(), now()),
('354ab407-8703-11ef-82d7-089798dd3457', '89b663da-8701-11ef-82d7-089798dd3457', 30.00, 'Denim Jacket', 'DJ123', 80.00, 40, 'uuid()', 'Classic denim jacket', 'pcs', 0.7, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 25.00, 'High Waisted Jeans', 'HWJ123', 70.00, 50, 'uuid()', 'Stylish high waisted jeans', 'pcs', 0.6, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 15.00, 'Blouse', 'BL123', 40.00, 60, 'uuid()', 'Casual chiffon blouse', 'pcs', 0.3, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 60.00, 'Trench Coat', 'TC123', 150.00, 20, 'uuid()', 'Classic trench coat', 'pcs', 1.2, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 20.00, 'Pencil Skirt', 'PS123', 60.00, 50, 'uuid()', 'Elegant pencil skirt', 'pcs', 0.4, now(), now()),
('84a6ccc3-8703-11ef-82d7-089798dd3457', '89b663da-8701-11ef-82d7-089798dd3457', 50.00, 'Cashmere Sweater', 'CS123', 130.00, 30, 'uuid()', 'Soft cashmere sweater', 'pcs', 0.5, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 10.00, 'Leggings', 'LG123', 30.00, 100, 'uuid()', 'Stretchable leggings', 'pcs', 0.2, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 100.00, 'Floor Length Gown', 'FLG123', 250.00, 15, 'uuid()', 'Elegant floor-length gown', 'pcs', 1.5, now(), now()),
('uuid()', '89b663da-8701-11ef-82d7-089798dd3457', 60.00, 'Ankle Boots', 'AB123', 180.00, 25, 'uuid()', 'Leather ankle boots', 'prs', 1.0, now(), now());

-- Insert 10 products for ACCESSORIES category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('609d583b-8703-11ef-82d7-089798dd3457', '9bd16c9b-8701-11ef-82d7-089798dd3457', 15.00, 'Sunglasses', 'SG123', 50.00, 100, 'uuid()', 'Stylish sunglasses', 'pcs', 0.2, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 20.00, 'Leather Belt', 'LB123', 60.00, 80, 'uuid()', 'Premium leather belt', 'pcs', 0.3, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 100.00, 'Watch', 'WT123', 250.00, 40, 'uuid()', 'Classic wristwatch', 'pcs', 0.5, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 10.00, 'Scarf', 'SC123', 30.00, 60, 'uuid()', 'Wool scarf', 'pcs', 0.2, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 50.00, 'Handbag', 'HB123', 120.00, 35, 'uuid()', 'Designer handbag', 'pcs', 1.0, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 8.00, 'Cap', 'CP123', 25.00, 100, 'uuid()', 'Adjustable baseball cap', 'pcs', 0.2, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 5.00, 'Earrings', 'ER123', 20.00, 150, 'uuid()', 'Stylish earrings', 'prs', 0.1, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 40.00, 'Necklace', 'NK123', 100.00, 50, 'uuid()', 'Elegant gold necklace', 'pcs', 0.3, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 30.00, 'Bracelet', 'BR123', 80.00, 70, 'uuid()', 'Charm bracelet', 'pcs', 0.2, now(), now()),
('uuid()', '9bd16c9b-8701-11ef-82d7-089798dd3457', 25.00, 'Ring', 'RG123', 70.00, 90, 'uuid()', 'Diamond ring', 'pcs', 0.1, now(), now());

-- Insert 10 products for GRAINS_CEREALS category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('9c499182-8703-11ef-82d7-089798dd3457', 'a8120ea3-8701-11ef-82d7-089798dd3457', 1.50, 'Brown Rice', 'BR123', 3.00, 200, 'uuid()', 'Organic brown rice', 'kg', 1.0, now(), now()),
('931d417e-8703-11ef-82d7-089798dd3457', 'a8120ea3-8701-11ef-82d7-089798dd3457', 2.00, 'Oats', 'OT123', 4.50, 150, 'uuid()', 'Whole grain oats', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 1.20, 'Wheat Flour', 'WF123', 3.20, 300, 'uuid()', 'Premium wheat flour', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 1.00, 'Corn Meal', 'CM123', 2.80, 180, 'uuid()', 'Coarse corn meal', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 3.50, 'Quinoa', 'QN123', 7.50, 120, 'uuid()', 'Organic quinoa', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 1.80, 'Barley', 'BL123', 4.00, 200, 'uuid()', 'Pearl barley', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 2.50, 'Buckwheat', 'BW123', 5.00, 140, 'uuid()', 'Whole grain buckwheat', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 1.60, 'Millet', 'ML123', 3.80, 220, 'uuid()', 'Organic millet', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 1.10, 'Rice Flakes', 'RF123', 2.50, 250, 'uuid()', 'Gluten-free rice flakes', 'kg', 1.0, now(), now()),
('uuid()', 'a8120ea3-8701-11ef-82d7-089798dd3457', 2.20, 'Bulgur Wheat', 'BW123', 4.70, 170, 'uuid()', 'Cracked bulgur wheat', 'kg', 1.0, now(), now());

-- Insert 10 products for SNACKS category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('b7b731b0-8703-11ef-82d7-089798dd3457', 'b50b47f7-8701-11ef-82d7-089798dd3457', 1.00, 'Potato Chips', 'PC123', 2.50, 500, 'uuid()', 'Crispy potato chips', 'pcs', 0.2, now(), now()),
('acb11317-8703-11ef-82d7-089798dd3457', 'b50b47f7-8701-11ef-82d7-089798dd3457', 1.20, 'Corn Chips', 'CC123', 2.80, 400, 'uuid()', 'Crunchy corn chips', 'pcs', 0.2, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 1.50, 'Chocolate Bar', 'CB123', 3.00, 300, 'uuid()', 'Milk chocolate bar', 'pcs', 0.1, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 0.80, 'Granola Bar', 'GB123', 2.00, 350, 'uuid()', 'Crunchy granola bar', 'pcs', 0.1, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 2.00, 'Trail Mix', 'TM123', 5.00, 200, 'uuid()', 'Nut and dried fruit mix', 'kg', 0.5, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 1.10, 'Pretzels', 'PR123', 2.50, 250, 'uuid()', 'Salted pretzels', 'pcs', 0.3, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 0.90, 'Popcorn', 'PP123', 2.20, 400, 'uuid()', 'Butter-flavored popcorn', 'pcs', 0.2, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 1.30, 'Cookies', 'CK123', 3.20, 300, 'uuid()', 'Chocolate sandwich cookies', 'pcs', 0.2, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 3.00, 'Nuts', 'NT123', 6.50, 150, 'uuid()', 'Mixed roasted nuts', 'kg', 0.5, now(), now()),
('uuid()', 'b50b47f7-8701-11ef-82d7-089798dd3457', 0.60, 'Candy', 'CD123', 1.80, 500, 'uuid()', 'Gummy candy', 'pcs', 0.1, now(), now());

-- Insert 10 products for SPICES_SEASONINGS category
INSERT INTO product (id, categoryid, costprice, name, productcd, sellingprice, stock, supplierid, txdesc, unit, weight, CreationTime, LastModificationTime) VALUES
('c048026b-8703-11ef-82d7-089798dd3457', 'c78cf498-8701-11ef-82d7-089798dd3457', 3.00, 'Black Pepper', 'BP123', 7.00, 200, 'uuid()', 'Ground black pepper', 'kg', 0.5, now(), now()),
('ca38d0ca-8703-11ef-82d7-089798dd3457', 'c78cf498-8701-11ef-82d7-089798dd3457', 2.50, 'Cinnamon', 'CN123', 6.00, 150, 'uuid()', 'Ground cinnamon', 'kg', 0.4, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 2.00, 'Paprika', 'PP123', 5.50, 180, 'uuid()', 'Smoked paprika', 'kg', 0.4, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 2.20, 'Cumin', 'CM123', 6.00, 160, 'uuid()', 'Ground cumin', 'kg', 0.4, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 1.80, 'Turmeric', 'TM123', 4.50, 220, 'uuid()', 'Ground turmeric', 'kg', 0.5, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 2.50, 'Chili Powder', 'CP123', 6.20, 200, 'uuid()', 'Spicy chili powder', 'kg', 0.4, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 2.00, 'Basil', 'BS123', 5.00, 180, 'uuid()', 'Dried basil leaves', 'kg', 0.3, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 2.30, 'Oregano', 'OR123', 5.50, 190, 'uuid()', 'Dried oregano', 'kg', 0.3, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 1.70, 'Ginger', 'GN123', 4.20, 250, 'uuid()', 'Ground ginger', 'kg', 0.5, now(), now()),
('uuid()', 'c78cf498-8701-11ef-82d7-089798dd3457', 1.90, 'Garlic Powder', 'GP123', 4.80, 240, 'uuid()', 'Ground garlic powder', 'kg', 0.4, now(), now());

DELETE FROM producttag;
-- Insert tags for products across various categories with updated ID format
INSERT INTO producttag (id, productid, tagname, CreationTime, LastModificationTime) VALUES
('uuid()', '5368d01a-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '5368d01a-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '63966101-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '63966101-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '77f4baea-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '77f4baea-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '99a4a35c-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),

('uuid()', 'b26a5414-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'b26a5414-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', 'c017ed18-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'c017ed18-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', 'd70d7801-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'd70d7801-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', 'e3a204e7-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),

('uuid()', 'f2bec440-8702-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'f2bec440-8702-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '0946a213-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '0946a213-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '150e9ffb-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '150e9ffb-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '1d41d12f-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),

('uuid()', '29ece2d5-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '29ece2d5-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '354ab407-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),

('uuid()', '4b800266-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '4b800266-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '53ac8d15-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '53ac8d15-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '609d583b-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '609d583b-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '84a6ccc3-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),

('uuid()', '931d417e-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', '931d417e-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', '9c499182-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),

('uuid()', 'acb11317-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'acb11317-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', 'b7b731b0-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'b7b731b0-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', 'c048026b-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'c048026b-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now()),

('uuid()', 'ca38d0ca-8703-11ef-82d7-089798dd3457', 'NEW', now(), now()),
('uuid()', 'ca38d0ca-8703-11ef-82d7-089798dd3457', 'BEST SELLER', now(), now());