namespace MinimalAPI.Data
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int MetacriticScore { get; set; }
        public double UserMetacriticScore { get; set; }  
    }

    public class Data
    {
        public static List<Game> Games = new List<Game>
        {

        new Game {
        Id = 1,
        Title = "Metaphor: ReFantazio",
        Publisher = "Sega",
        MetacriticScore = 92 ,
        UserMetacriticScore = 8.9},
        new Game {
        Id = 2,
        Title = "Tekken 8",
        Publisher = "Bandai Namco Games",
        MetacriticScore = 90,
        UserMetacriticScore = 7.6},
        new Game {
        Id = 3,
        Title = "UFO 50",
        Publisher = "Mossmouth",
        MetacriticScore = 91,
        UserMetacriticScore = 7.9},
        new Game {
        Id = 4,
        Title = "Animal Well",
        Publisher = "Bigmode",
        MetacriticScore = 91 ,
        UserMetacriticScore = 8.0},
        new Game {
        Id = 5,
        Title = "Satisfactory",
        Publisher = "Coffee Stain Studios",
        MetacriticScore = 91 ,
        UserMetacriticScore = 8.1},
        new Game {
        Id = 6,
        Title = "Balatro",
        Publisher = "Playstack",
        MetacriticScore = 90,
        UserMetacriticScore = 8.3},
        new Game {
        Id = 7,
        Title = "Shin Megami Tensei V: Vengeance",
        Publisher = "Sega",
        MetacriticScore = 87,
        UserMetacriticScore = 8.1},
        new Game {
        Id = 8,
        Title = "Thank Godness You're Here!",
        Publisher = "Panic Inc.",
        MetacriticScore = 90,
        UserMetacriticScore = 7.8},
        new Game {
        Id = 9,
        Title = "Like a Dragon: Infinite Wealth",
        Publisher = "Sega",
        MetacriticScore = 89,
        UserMetacriticScore = 8.6},
        new Game {
        Id = 10,
        Title = "Kill Knight",
        Publisher = "PlaySide Studios",
        MetacriticScore = 89,
        UserMetacriticScore = 8.1},
        new Game {
        Id = 11,
        Title = "Lorelei and the Laser Eyes",
        Publisher = "Annapurna Interactive",
        MetacriticScore = 88,
        UserMetacriticScore = 8.0},
        new Game {
        Id = 12,
        Title = "Tactical Breach Wizards",
        Publisher = "Suspicious Developments",
        MetacriticScore = 88,
        UserMetacriticScore = 8.0},
        new Game {
        Id = 13,
        Title = "Dragon's Dogma 2",
        Publisher = "Capcom",
        MetacriticScore = 86,
        UserMetacriticScore = 6.4},
        new Game {
        Id = 14,
        Title = "Shogun Showdown",
        Publisher = "Goblinz Studio",
        MetacriticScore = 88,
        UserMetacriticScore = 8.2},
        new Game {
        Id = 15,
        Title = "The Crimson Diamond",
        Publisher = "Julia Minamata",
        MetacriticScore = 88,
        UserMetacriticScore = 5.7},
        new Game {
        Id = 16,
        Title = "Mullet Madjack",
        Publisher = "Hammer95",
        MetacriticScore = 88,
        UserMetacriticScore = 8.2},
        new Game {
        Id = 17,
        Title = "Five Nights at Freddy's: Into the Pit",
        Publisher = "Mega Cat Studios",
        MetacriticScore = 87,
        UserMetacriticScore = 7.8},
        new Game {
        Id = 18,
        Title = "Silent Hill 2",
        Publisher = "Konami",
        MetacriticScore = 86,
        UserMetacriticScore = 9.2},
        new Game {
        Id = 19,
        Title = "Halls of Torment",
        Publisher = "Chasing Carrots",
        MetacriticScore = 87,
        UserMetacriticScore = 7.9},
        new Game {
        Id = 20,
        Title = "Minishoot' Adventures",
        Publisher = "SoulGame Studio",
        MetacriticScore = 87,
        UserMetacriticScore = 8.5},
        new Game {
        Id = 21,
        Title = "Marvel vs. Capcom Fighting Collection: Arcade Classics",
        Publisher = "Capcom",
        MetacriticScore = 86,
        UserMetacriticScore = 8.9},
        new Game {
        Id = 22,
        Title = "Neva",
        Publisher = "Devolver Digital",
        MetacriticScore = 86,
        UserMetacriticScore = 8.3},
        new Game {
        Id = 23,
        Title = "Minds Beneath Us",
        Publisher = "BearBoneStudio",
        MetacriticScore = 86,
        UserMetacriticScore = 7.8},
        new Game {
        Id = 24,
        Title = "Riven",
        Publisher = "Cyan Worlds",
        MetacriticScore = 86,
        UserMetacriticScore = 7.8},
        new Game {
        Id = 25,
        Title = "Sons of the Forest",
        Publisher = "Newnight",
        MetacriticScore = 86,
        UserMetacriticScore = 7.3},
        new Game {
        Id = 26,
        Title = "Dragon Age: The Veilguard",
        Publisher = "Electronic Arts",
        MetacriticScore = 82,
        UserMetacriticScore = 3.8}
        };
    }

}