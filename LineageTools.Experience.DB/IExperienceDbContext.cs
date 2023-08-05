using LineageTools.Experience.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace Maid.Manga.DB
{
	public interface IExperienceDbContext
	{
		DbSet<ExperienceToLevel> ExperienceToLevel { get; set; }

	}
}