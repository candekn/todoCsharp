using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.EF
{
    [Table("StudentInfo")]
    public class Student
    {
        public Student() { }

        [Key]
        public int SID { get; set; }

        [Column("Name", TypeName = "varchar")]
        [MaxLength(50)]
        public string StudentName { get; set; }   //Los strings aceptan null por defecto, los int no.

        [NotMapped] //Significa No crees esa columna
        public int? Age { get; set; }  //Signo de interrogacion significa que acepta null


        public int StdId { get; set; } //Primero creamos propiedad con el mismo nombre de la fk

        [ForeignKey("StdId")] //La foreign key se va a llamar asi
        public virtual Standard Standard { get; set; }


    }
}
