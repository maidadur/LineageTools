using LineageTools.Experience.DB;

namespace LineageTools
{
	public class Program
	{
		public static void Main(string[] args) {
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var connection = builder.Configuration["Experience_ConnectionString"];
			LineageExperieceStartup.SetupDB(builder.Services, connection);

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment()) {
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseCors();
			app.UseHttpsRedirection();
			app.UseAuthorization();
			app.MapControllers();
			app.Run();
		}
	}
}