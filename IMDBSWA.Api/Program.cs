using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Concrete;
using IMDBSWA.Core.Abstract;
using IMDBSWA.Core.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMovieService, MovieManager>();
builder.Services.AddScoped<IMovie, EfMovie>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUser, EfUser>();
builder.Services.AddScoped<ITvSeriesService, TvSeriesManager>();
builder.Services.AddScoped<ITvSeries, EfTvSeries>();
builder.Services.AddScoped<IFavoriteListService, FavoriteListManager>();
builder.Services.AddScoped<IFavoriteList, EfFavoriteList>();
builder.Services.AddScoped<ILikedListService,LikedListManager>();
builder.Services.AddScoped<ILikedList, EfLikedList>();
builder.Services.AddScoped<ICommentedListService, CommentedListManager>();
builder.Services.AddScoped<ICommentedList, EfCommentedList>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
