using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class About
	{
        public int AboutId { get; set; }
        public string? Title { get; set; }
        public string? SubDescription { get; set; }
		public string? DetailsTitle { get; set; }
		public string? Details { get; set; }
	}
}
