-- ######################################################
-- Create the Product table
-- ######################################################

CREATE TABLE Products (
    ID INT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Description VARCHAR(255),
    Price FLOAT NOT NULL,
    PhotoUrl VARCHAR(255) NOT NULL
);


-- ######################################################
-- Create the Product table
-- ######################################################

-- adding Gaming consoles
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (1, 'Xbox One S', 'a powerful, 4k gaming console from Microsoft', 499.99, 'https://calicotgamingstore.blob.core.windows.net/products/Xbox-One-S.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (2, 'PlayStation 5', 'a powerful, 4k gaming console from Sony, Microsoft''s rival in the gaming world', 399.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation-5-ps5.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (3, 'Nintendo Switch', 'a versatile gaming console from Nintendo', 299.99, 'https://calicotgamingstore.blob.core.windows.net/products/nintendo-switch.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (4, 'Xbox Series X', 'the latest gaming console from Microsoft, offering powerful performance. Supports 4K display.', 599.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-series-x.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (5, 'PlayStation 4', 'a popular gaming console from Sony, predecessor to PlayStation 5', 299.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation4.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (6, 'Nintendo Switch Lite', 'a compact and lightweight version of Nintendo Switch', 199.99, 'https://calicotgamingstore.blob.core.windows.net/products/nintendo-switch-lite.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (7, 'Xbox One X', 'a previous generation gaming console from Microsoft, offering enhanced performance', 399.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-one-x.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (8, 'PlayStation 3', 'a classic gaming console from Sony, predecessor to PlayStation 4', 199.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation3.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (9, 'Nintendo 3DS', 'a portable gaming console from Nintendo, offering 3D gameplay', 149.99, 'https://calicotgamingstore.blob.core.windows.net/products/nintendo-3ds.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (10, 'Xbox 360', 'a classic gaming console from Microsoft, predecessor to Xbox One', 149.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-360.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (11, 'PlayStation 2', 'a legendary gaming console from Sony, predecessor to PlayStation 3', 99.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation2.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (12, 'Nintendo GameCube', 'a classic gaming console from Nintendo, offering unique game experiences', 99.99, 'https://calicotgamingstore.blob.core.windows.net/products/nintendo-gamecube.jpg');

-- adding games for Xbox One S.
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (13, 'Call of Duty: Modern Warfare', 'Experience the ultimate online multiplayer warfare with intense, realistic combat. Rated M for mature audiences. An Xbox One S game.', 59.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-one-s-cod-modern-warefare.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (14, 'Assassin''s Creed Valhalla', 'A game for the Xbox One S. Embark on a Viking adventure in this open-world action RPG. Rated M for mature audiences.', 49.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-one-s-assassins-creed-valhalla.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (15, 'FIFA 22', 'Take to the pitch and experience the thrill of soccer in this popular sports game. Rated E for everyone. Play it on your Xbox One S.', 39.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-one-s-fifa-22.jpg');

-- adding games for PlayStation 5. 
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (16, 'Demon''s Souls', 'A challenging action RPG set in a dark fantasy world. Rated M for mature audiences. Face formidable enemies and uncover the secrets of the cursed land. Only on PlayStation 5.', 69.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation5-demons-soul.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (17, 'Ratchet & Clank: Rift Apart', 'Embark on an interdimensional adventure with Ratchet and his robotic companion Clank. Rated E10+ for everyone 10 and older. Explore stunning worlds and wield powerful weapons. A perfect companion for your PlayStation 5.', 59.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation5-ratchet-clank-rift-apart.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (18, 'Returnal', 'A mind-bending third-person shooter on PlayStation 5 with roguelike elements. Rated M for mature audiences. Survive a hostile alien planet and unravel the mysteries of your own existence.', 69.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation5-returnal.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (19, 'Marvel''s Spider-Man: Miles Morales', 'Swing through the streets of New York City as Miles Morales, the new Spider-Man. Rated T for teen. Experience thrilling web-slinging action and a heartfelt story. Exclusively on PlayStation 5.', 49.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation5-spiderman-miles-morales.jpg');

-- adding games for XBox Series X.
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (20, 'Halo Infinite', 'An epic first-person shooter game for the Xbox Series X. Rated M for mature audiences. Join Master Chief in his latest adventure to save humanity from the forces of evil.', 59.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-series-x-halo-infinite.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (21, 'Forza Horizon 5', 'Experience the thrill of open-world racing in stunning 4K on the Xbox Series X. Rated E for everyone. Explore a vibrant world and compete in exhilarating races.', 49.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-series-x-forza-horizon-5.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (22, 'Resident Evil Village', 'A chilling survival horror game for the Xbox Series X. Rated M for mature audiences. Step into the shoes of Ethan Winters as he faces terrifying creatures and unravels a dark mystery.', 69.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-series-x-resident-evil-village.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (30, 'The Last of Us Part II', 'A gripping post-apocalyptic action-adventure game. Rated M for mature audiences. Experience a harrowing journey through a dangerous world. Optimized for the XBox Series X.', 59.99, 'https://calicotgamingstore.blob.core.windows.net/products/xbox-series-x-the-last-of-us-ii.jpg');

-- adding games for PlayStation 4.
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (23, 'The Last of Us Part II', 'A gripping post-apocalyptic action-adventure game. Rated M for mature audiences. Experience a harrowing journey through a dangerous world. Designed for the PlayStation 4.', 59.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation4-the-last-of-us-ii.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (24, 'Ghost of Tsushima', 'Embark on an epic samurai adventure set in feudal Japan. Rated M for mature audiences. Engage in intense sword fights and explore a stunning open world. Available exclusively on the PlayStation 4.', 49.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation4-ghost-of-tsushima.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (25, 'Bloodborne', 'A challenging action RPG set in a dark and gothic world. Rated M for mature audiences. Face nightmarish creatures and uncover the secrets of the city of Yharnam. Play it on the PlayStation 4.', 39.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation4-bloodborne.jpg');

-- adding games for PlayStation 2.
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (26, 'Grand Theft Auto: San Andreas', 'An open-world action-adventure game set in a fictionalized version of California. Rated M for mature audiences. Experience the criminal underworld and navigate the challenges of gang life. Designed for the PlayStation 2.', 19.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation2-grand-theft-auto-san-andreas.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (27, 'Metal Gear Solid 3: Snake Eater', 'A stealth action game set during the Cold War era. Rated M for mature audiences. Assume the role of Naked Snake and embark on a mission filled with espionage and political intrigue. Play it on the PlayStation 2.', 14.99, 'https://calicotgamingstore.blob.core.windows.net/products/playstation2-metal-gear-solid-3-snake-eater.jpg');

--  adding games for Nintendo GameCube.
INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (28, 'Super Smash Bros. Melee', 'A popular fighting game featuring Nintendo characters. Rated T for teen. Battle it out with friends in intense multiplayer matches. Designed for the GameCube.', 29.99, 'https://calicotgamingstore.blob.core.windows.net/products/nintendo-gamecube-super-smash-bros-melee.jpg');

INSERT INTO Products (ID, Name, Description, Price, PhotoUrl)
VALUES (29, 'The Legend of Zelda: The Wind Waker', 'Embark on a grand adventure as Link in this action-adventure game. Rated E for everyone. Explore a vast ocean and discover the secrets of the Great Sea. Play it on the GameCube.', 39.99, 'https://calicotgamingstore.blob.core.windows.net/products/nintendo-gamecube-legend-of-zelda-wind-waker.jpg');