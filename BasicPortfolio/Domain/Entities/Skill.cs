﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Skill
	{
        public int SkillId { get; set; }
        public string? Title { get; set; }
        public int Value { get; set; }
    }
}
