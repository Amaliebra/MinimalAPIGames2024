var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var games = new List<Game>
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
        Title = "Kill Knight",
        Publisher = "PlaySide Studios",
        MetacriticScore = 89,
        UserMetacriticScore = 8.1},
    new Game {
        Id = 12,
        Title = "Kill Knight",
        Publisher = "PlaySide Studios",
        MetacriticScore = 89,
        UserMetacriticScore = 8.1},
    new Game {
        Id = 13,
        Title = "Kill Knight",
        Publisher = "PlaySide Studios",
        MetacriticScore = 89,
        UserMetacriticScore = 8.1},
};

app.UseHttpsRedirection();

app.MapGet("/game", () =>
{
    return games;
});

app.MapGet("/game/{id}", (int id) =>
{
    var game = games.Find(g => g.Id == id);
    if (game is null)
        return Results.NotFound("Game was not found");

    return Results.Ok(game);
});

app.MapPost("/game", (Game game) =>
{
    games.Add(game);
    return games;
});

app.MapPut("/game/{id}", (Game updatedGame,int id) =>
{
    var game = games.Find(g => g.Id == id);
    if (game is null)
        return Results.NotFound("Game was not found");

    game.Title = updatedGame.Title;
    game.Publisher = updatedGame.Publisher;

    return Results.Ok(game);
});

app.MapDelete("/game/{id}", (int id) =>
{
    var game = games.Find(g => g.Id == id);
    if (game is null)
        return Results.NotFound("Game was not found");

    games.Remove(game);

    return Results.Ok(game);
});

app.Run();

class Game
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public int MetacriticScore { get; set; }
    public double UserMetacriticScore { get; set; }
}
