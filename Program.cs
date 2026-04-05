namespace Minimal_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/shirts", () =>
            {
                return "Reading all the shirts";
            });

            app.MapGet("/shirts/{id}", (int id) =>
            {
                return $"Reading shirt with ID: {id}";
            });

            app.MapPost("/shirt", () =>
            {
                return "Creating a shirt";
            });

            app.MapPut("/shirts/{id}", (int id) =>
            {
                return $"Updating shirt {id}";
            });

            app.MapDelete("/shirts/{id}", (int id) =>
            {
                return $"Deleting shirt with ID: {id}";
            });

            app.Run();
        }
    }
}
