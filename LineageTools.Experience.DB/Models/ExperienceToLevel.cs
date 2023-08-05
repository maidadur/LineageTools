using Maid.Core;

namespace LineageTools.Experience.DB.Models
{
	public class ExperienceToLevel : BaseEntity
	{
		public int Level { get; set; }
		public int ExpCount { get; set; }
	}
}