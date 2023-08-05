namespace Maid.Manga.DB
{
	using LineageTools.Experience.DB.Models;
	using Microsoft.EntityFrameworkCore;

	public class ExperienceDbContext : DbContext, IExperienceDbContext
	{
		public ExperienceDbContext(DbContextOptions<ExperienceDbContext> options)
			: base(options) { }

		public DbSet<ExperienceToLevel> ExperienceToLevel { get; set; }
	}
}