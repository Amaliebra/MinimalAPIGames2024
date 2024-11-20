using MinimalAPI.Data;

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

List<Game> games = LoadGameData();

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

app.MapPost("/game", (Game newGame) =>
{
    if (games.Any(g => g.Id == newGame.Id))
    {
        return Results.BadRequest("A game with that ID already exists");
    }

    newGame.Id = games.Count() + 1;

    games.Add(newGame);
    return Results.Created($"/game/{newGame.Id}", newGame);
});

app.MapPut("/game/{id}", (Game updatedGame,int id) =>
{
    var game = games.Find(g => g.Id == id);
    if (game is null)
        return Results.NotFound("Game was not found");

    game.Title = updatedGame.Title;
    game.Publisher = updatedGame.Publisher;
    game.MetacriticScore = updatedGame.MetacriticScore;
    game.UserMetacriticScore = updatedGame.UserMetacriticScore;

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


List<Game> LoadGameData()
{
    return games;
}