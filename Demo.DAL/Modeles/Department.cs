using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Modeles
{
    public class Department
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code Is Required")]

        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
