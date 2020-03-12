using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WindowsEF.EF
{
    public class Standard
    {
        [Key] //DataAnnotacion: esta anotacion le dice que el campo StdId es ID
        public int StdId { get; set; }
        public string StandardName { get; set; }

        public List<Student> Students { get; set; }


    }
}