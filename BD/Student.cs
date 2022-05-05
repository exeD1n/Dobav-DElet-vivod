using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp48.BD
{
    class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
