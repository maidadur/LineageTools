using LineageTools.Experience.DB;
using Maid.Core;

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

			if (app.Environment.IsDevelopment()) {
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			var uiOrigin = builder.Configuration["UIOrigin"];
			if (uiOrigin.IsNotEmpty()) {
				builder.Services.AddCors(options =>
				{
					options.AddDefaultPolicy(
						policy => {
							policy.WithOrigins(uiOrigin);
						});
				});
			}
			app.UseCors();

			app.UseHttpsRedirection();
			app.MapControllers();
			app.Run();
		}
	}
}