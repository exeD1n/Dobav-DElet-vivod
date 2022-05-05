using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp48.BD
{
    class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            return GroupName;
        }
    }
}
