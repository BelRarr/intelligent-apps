using CalicotGaming.Web.Models;

public static class Helpers
{
    // seeding your product catalog
    public static void SeedDbContext(CalicotGamingDbContext dbContext)
    {
        // adding Gaming consoles
        dbContext?.Products?.Add(new Product{ Id = 1, Name = "Xbox One S", Description = "a powerful, 4k gaming console from Microsoft", Price = 499.99m, PhotoUrl = "https://m.media-amazon.com/images/I/619Bmcg-EIL._AC_UF1000,1000_QL80_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 2, Name = "PlayStation 5", Description = "a powerful, 4k gaming console from Sony, Microsoft's rival in the gaming world", Price = 399.99m, PhotoUrl = "https://cdn.wccftech.com/wp-content/uploads/2022/11/playstation-5-ps5.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 3, Name = "Nintendo Switch", Description = "a versatile gaming console from Nintendo", Price = 299.99m, PhotoUrl = "https://i.ebayimg.com/images/g/eF8AAOSw-F9h2E0y/s-l1600.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 4, Name = "Xbox Series X", Description = "the latest gaming console from Microsoft, offering powerful performance. Supports 4K display.", Price = 599.99m, PhotoUrl = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/149/14964/14964951.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 5, Name = "PlayStation 4", Description = "a popular gaming console from Sony, predecessor to PlayStation 5", Price = 299.99m, PhotoUrl = "https://m.media-amazon.com/images/I/51ROi4d4puL.__AC_SY300_SX300_QL70_ML2_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 6, Name = "Nintendo Switch Lite", Description = "a compact and lightweight version of Nintendo Switch", Price = 199.99m, PhotoUrl = "https://m.media-amazon.com/images/I/61JhOrXMQYL.__AC_SY300_SX300_QL70_ML2_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 7, Name = "Xbox One X", Description = "a previous generation gaming console from Microsoft, offering enhanced performance", Price = 399.99m, PhotoUrl = "https://imageio.forbes.com/blogs-images/erikkain/files/2017/11/xbox-one-x.jpg?height=399&width=711&fit=bounds" });
        dbContext?.Products?.Add(new Product{ Id = 8, Name = "PlayStation 3", Description = "a classic gaming console from Sony, predecessor to PlayStation 4", Price = 199.99m, PhotoUrl = "https://m.media-amazon.com/images/I/91ep+mWIPYL._AC_UF1000,1000_QL80_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 9, Name = "Nintendo 3DS", Description = "a portable gaming console from Nintendo, offering 3D gameplay", Price = 149.99m, PhotoUrl = "https://i5.walmartimages.com/asr/9162188e-60bf-400f-b528-a3db85a746af.7b05c5064e73e6f7dcb364e6d0267779.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        dbContext?.Products?.Add(new Product{ Id = 10, Name = "Xbox 360", Description = "a classic gaming console from Microsoft, predecessor to Xbox One", Price = 149.99m, PhotoUrl = "https://i.ebayimg.com/images/g/PE8AAOSw6LRgL94D/s-l1600.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 11, Name = "PlayStation 2", Description = "a legendary gaming console from Sony, predecessor to PlayStation 3", Price = 99.99m, PhotoUrl = "https://i5.walmartimages.com/asr/2e0712fa-74d7-447c-a04b-abe066228c01.4b877404e5bb054d293c364d9c9fe2ad.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        dbContext?.Products?.Add(new Product{ Id = 12, Name = "Nintendo GameCube", Description = "a classic gaming console from Nintendo, offering unique game experiences", Price = 99.99m, PhotoUrl = "https://m.media-amazon.com/images/I/61cc-278k0L._AC_UF1000,1000_QL80_.jpg" });
        
        // adding games for Xbox One S.
        dbContext?.Products?.Add(new Product{ Id = 13, Name = "Call of Duty: Modern Warfare", Description = "Experience the ultimate online multiplayer warfare with intense, realistic combat. Rated M for mature audiences. An Xbox One S game.", Price = 59.99m, PhotoUrl = "https://m.media-amazon.com/images/I/81p00zN-nYL._AC_SY879_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 14, Name = "Assassin's Creed Valhalla", Description = "A game for the Xbox One S. Embark on a Viking adventure in this open-world action RPG. Rated M for mature audiences.", Price = 49.99m, PhotoUrl = "https://m.media-amazon.com/images/I/814XgM5nDGL.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 15, Name = "FIFA 22", Description = "Take to the pitch and experience the thrill of soccer in this popular sports game. Rated E for everyone. Play it on your Xbox One S.", Price = 39.99m, PhotoUrl = "https://i5.walmartimages.ca/images/Enlarge/188/431/6000204188431.jpg" });

        // adding games for PlayStation 5.                
        dbContext?.Products?.Add(new Product{ Id = 16, Name = "Demon's Souls", Description = "A challenging action RPG set in a dark fantasy world. Rated M for mature audiences. Face formidable enemies and uncover the secrets of the cursed land. Only on PlayStation 5.", Price = 69.99m, PhotoUrl = "https://m.media-amazon.com/images/I/81AiCw88X3L.__AC_SX300_SY300_QL70_ML2_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 17, Name = "Ratchet & Clank: Rift Apart", Description = "Embark on an interdimensional adventure with Ratchet and his robotic companion Clank. Rated E10+ for everyone 10 and older. Explore stunning worlds and wield powerful weapons. A perfect companion for your PlayStation 5.", Price = 59.99m, PhotoUrl = "https://m.media-amazon.com/images/I/71k2AZCH11L.__AC_SX300_SY300_QL70_ML2_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 18, Name = "Returnal", Description = "A mind-bending third-person shooter on PlayStation 5 with roguelike elements. Rated M for mature audiences. Survive a hostile alien planet and unravel the mysteries of your own existence.", Price = 69.99m, PhotoUrl = "https://i5.walmartimages.ca/images/Enlarge/830/793/6000202830793.jpg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        dbContext?.Products?.Add(new Product{ Id = 19, Name = "Marvel's Spider-Man: Miles Morales", Description = "Swing through the streets of New York City as Miles Morales, the new Spider-Man. Rated T for teen. Experience thrilling web-slinging action and a heartfelt story. Exclusively on PlayStation 5.", Price = 49.99m, PhotoUrl = "https://m.media-amazon.com/images/I/6168UK7hfEL.__AC_SX300_SY300_QL70_ML2_.jpg" });
        
        // adding games for XBox Series X.
        dbContext?.Products?.Add(new Product{ Id = 20, Name = "Halo Infinite", Description = "An epic first-person shooter game for the Xbox Series X. Rated M for mature audiences. Join Master Chief in his latest adventure to save humanity from the forces of evil.", Price = 59.99m, PhotoUrl = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/156/15684/15684618.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 21, Name = "Forza Horizon 5", Description = "Experience the thrill of open-world racing in stunning 4K on the Xbox Series X. Rated E for everyone. Explore a vibrant world and compete in exhilarating races.", Price = 49.99m, PhotoUrl = "https://i5.walmartimages.com/asr/bc4fca4b-ade5-45ef-a0f3-f40fcf44455c.657c970fb2b622be970e7b56f8597e21.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        dbContext?.Products?.Add(new Product{ Id = 22, Name = "Resident Evil Village", Description = "A chilling survival horror game for the Xbox Series X. Rated M for mature audiences. Step into the shoes of Ethan Winters as he faces terrifying creatures and unravels a dark mystery.", Price = 69.99m, PhotoUrl = "https://i5.walmartimages.com/asr/cee98471-2f73-41b3-bd82-5f40b6422862.c50fe188d8624b4590eb65f2e8709815.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        dbContext?.Products?.Add(new Product{ Id = 30, Name = "The Last of Us Part II", Description = "A gripping post-apocalyptic action-adventure game. Rated M for mature audiences. Experience a harrowing journey through a dangerous world. Optimized for the XBox Series X.", Price = 59.99m, PhotoUrl = "https://m.media-amazon.com/images/I/81kDA28Z7aS.__AC_SX300_SY300_QL70_ML2_.jpg" });


        // adding games for PlayStation 4.
        dbContext?.Products?.Add(new Product{ Id = 23, Name = "The Last of Us Part II", Description = "A gripping post-apocalyptic action-adventure game. Rated M for mature audiences. Experience a harrowing journey through a dangerous world. Designed for the PlayStation 4.", Price = 59.99m, PhotoUrl = "https://m.media-amazon.com/images/I/81kDA28Z7aS.__AC_SX300_SY300_QL70_ML2_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 24, Name = "Ghost of Tsushima", Description = "Embark on an epic samurai adventure set in feudal Japan. Rated M for mature audiences. Engage in intense sword fights and explore a stunning open world. Available exclusively on the PlayStation 4.", Price = 49.99m, PhotoUrl = "https://m.media-amazon.com/images/I/81KTDwaaeyS.__AC_SX300_SY300_QL70_ML2_.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 25, Name = "Bloodborne", Description = "A challenging action RPG set in a dark and gothic world. Rated M for mature audiences. Face nightmarish creatures and uncover the secrets of the city of Yharnam. Play it on the PlayStation 4.", Price = 39.99m, PhotoUrl = "https://m.media-amazon.com/images/I/61N9424oThL.__AC_SX300_SY300_QL70_ML2_.jpg" });
        
        // adding games for PlayStation 2.
        dbContext?.Products?.Add(new Product{ Id = 26, Name = "Grand Theft Auto: San Andreas", Description = "An open-world action-adventure game set in a fictionalized version of California. Rated M for mature audiences. Experience the criminal underworld and navigate the challenges of gang life. Designed for the PlayStation 2.", Price = 19.99m, PhotoUrl = "https://i5.walmartimages.com/asr/8fcae68d-971b-44e2-a832-6f2a4cf073d1.3441dd6ddb8a4def0af08fd9853b53f4.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        dbContext?.Products?.Add(new Product{ Id = 27, Name = "Metal Gear Solid 3: Snake Eater", Description = "A stealth action game set during the Cold War era. Rated M for mature audiences. Assume the role of Naked Snake and embark on a mission filled with espionage and political intrigue. Play it on the PlayStation 2.", Price = 14.99m, PhotoUrl = "https://i5.walmartimages.com/asr/1717ee3a-52cd-4e5a-a3d5-5c982a1dbce5.cadefcea7e133d3b55d08e5012f01fc0.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" });
        
        // adding games for Nintendo GameCube.
        dbContext?.Products?.Add(new Product{ Id = 28, Name = "Super Smash Bros. Melee", Description = "A popular fighting game featuring Nintendo characters. Rated T for teen. Battle it out with friends in intense multiplayer matches. Designed for the GameCube.", Price = 29.99m, PhotoUrl = "https://i.ebayimg.com/images/g/zSIAAOSwnbNluwYQ/s-l1600.jpg" });
        dbContext?.Products?.Add(new Product{ Id = 29, Name = "The Legend of Zelda: The Wind Waker", Description = "Embark on a grand adventure as Link in this action-adventure game. Rated E for everyone. Explore a vast ocean and discover the secrets of the Great Sea. Play it on the GameCube.", Price = 39.99m, PhotoUrl = "https://m.media-amazon.com/images/I/51gGRy9AJzL._US1100_.jpg" });
        

        dbContext?.SaveChanges();
    }
}

// NOTE:
// our catalog doesn't include games for the Nintendo 3DS. Hence, a grounded AI model should respond "sorry, but we don't have these in our catalog" rather than making up an answer.

// Here's the prompt we used:
// give me a list of 3 games for the xbox series X. One of them should be rated M and its description should clearly mention that and should mention for which console the game is designed.
