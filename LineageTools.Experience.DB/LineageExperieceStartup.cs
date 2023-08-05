using LineageTools.Experience.DB.Models;
using Maid.Core.DB;
using Maid.Manga.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LineageTools.Experience.DB
{
	public class LineageExperieceStartup
	{
		public static void SetupDB(IServiceCollection services, string connectionString) {
			services.AddDbContext<ExperienceDbContext>(options =>
				options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
			);
			services.AddScoped<DbContext, ExperienceDbContext>();
			services.AddTransient<IEntityRepository<ExperienceToLevel>, EntityRepository<ExperienceToLevel>>();
		}
	}
}
