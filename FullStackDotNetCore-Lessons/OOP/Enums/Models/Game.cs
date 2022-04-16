using Enums.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Models
{
    public class Game
    {
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
