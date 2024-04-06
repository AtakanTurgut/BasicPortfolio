using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Experience
	{
        public int ExperienceId { get; set; }
        public string? Head { get; set; }
        public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Date { get; set; }
	}
}
