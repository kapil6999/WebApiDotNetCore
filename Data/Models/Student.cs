using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAdd { get; set; }
    }
}
