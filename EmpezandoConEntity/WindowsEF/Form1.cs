using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.EF;

namespace WindowsEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //using genera un ambito ejecutable (no confundir con el using de la importacion 
            //de namespaces)

            //Creamos una instancia de entity framework:
            SchoolContext db = new SchoolContext();

            //Standard:
            Standard objStandard = new Standard() { StandardName = "A" };
            db.Standards.Add(objStandard);
            db.SaveChanges();
            //Instancia de alumno:
            Student objStudent = new Student() { StudentName = "Anna" , Standard=objStandard};

            //Agregar objStudent a la coleccion de Students
            db.Students.Add(objStudent);
            db.SaveChanges();

        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void TraerTodos()
        {
            SchoolContext sc = new SchoolContext();
            //Esto es LINQ : 
            List<Student> listaStudents = (
                from est in sc.Students
                select est
                ).ToList();
            dgvAlumnos.DataSource = listaStudents;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchoolContext sc = new SchoolContext();
            Student objStudent = TraerAlumno(sc);
            MessageBox.Show("Objeto student. Id: " + objStudent.SID.ToString() + " Nombre: " + objStudent.StudentName);
        }

        private Student TraerAlumno(SchoolContext sc)
        {
            Student objStudent = (from est in sc.Students
                                  where est.SID == 2
                                  select est).SingleOrDefault();
            return objStudent;
        }

        private void btnAlumnoIdNombre_Click(object sender, EventArgs e)
        {
            SchoolContext sc = new SchoolContext();
            var objAnonimo = (from est in sc.Students
                                  where est.SID==2
                                  select new
                                  {
                                      IdAlumno = est.SID,
                                      NombreAlumno = est.StudentName
                                  }).SingleOrDefault();
            MessageBox.Show("Tipo Anonimo. Id: " + objAnonimo.IdAlumno + " Nombre: " + objAnonimo.NombreAlumno);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SchoolContext sc = new SchoolContext();
            Student alumnoMod = TraerAlumno(sc);
            alumnoMod.StudentName = "Pedrito";
            alumnoMod.Age = 16;
            sc.SaveChanges();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SchoolContext sc = new SchoolContext();
            Student alumnoEliminar = TraerAlumno(sc);
            sc.Students.Remove(alumnoEliminar);
            sc.SaveChanges();
        }
    }
}
