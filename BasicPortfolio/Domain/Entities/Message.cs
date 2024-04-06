using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Message
	{
        public int MessageId { get; set; }
        public string? NameSurname { get; set; }
        public string? Subject { get; set; }
        public string? Email { get; set; }
        public string? MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
