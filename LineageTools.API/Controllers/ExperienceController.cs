using LineageTools.Experience.DB.Models;
using Maid.Core;
using Maid.Core.DB;
using Microsoft.AspNetCore.Mvc;

namespace LineageTools.Controllers
{
	[ApiController]
	[Route("experience")]
	public class ExperienceController : BaseApiController<ExperienceToLevel>
	{
		public ExperienceController(IEntityRepository<ExperienceToLevel> entityRepository) : base(entityRepository) {
		}
	}
}