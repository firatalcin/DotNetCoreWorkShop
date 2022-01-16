using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Homework_5.Entities
{
    internal class Gamer
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
