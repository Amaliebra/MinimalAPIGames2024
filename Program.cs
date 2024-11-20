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
        Title = "Metaphor", 
        Publisher = "", 
        MetacriticScore = 92 , 
        UserMetacriticScore = 0},
    new Game {
        Id = 2,
        Title = "Tekken 8",
        Publisher = "",
        MetacriticScore = 91 ,
        UserMetacriticScore = 0},
    new Game {
        Id = 3,
        Title = "UFO 50",
        Publisher = "",
        MetacriticScore = 91 ,
        UserMetacriticScore = 0},
    new Game {
        Id = 3,
        Title = "Animal Well",
        Publisher = "",
        MetacriticScore = 91 ,
        UserMetacriticScore = 0},
    new Game {
        Id = 4,
        Title = "Satisfactory",
        Publisher = "",
        MetacriticScore = 91 ,
        UserMetacriticScore = 0}
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

app.Run();

class Game
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public int MetacriticScore { get; set; }
    public double UserMetacriticScore { get; set; }
}
