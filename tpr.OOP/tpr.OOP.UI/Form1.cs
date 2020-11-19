using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpr.OOP.UI
{
    public partial class Form1 : Form
    {
        private Timer tmrDate = new Timer();

        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region PacManStuff
            /*
            PacMan pac = new PacMan();

            pac.Move();

            Ghost[] ghosts = new Ghost[4];

            for (int i=0; i <= ghosts.GetUpperBound(0); i++)
            ghosts[i] = new Ghost();

            ghosts[0].Color = Color.Pink;
            ghosts[1].Color = Color.Cyan;
            ghosts[2].Color = Color.Red;
            ghosts[3].Color = Color.Orange;
    */
            #endregion

            rebindstudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.FirstName = txtFirstName.Text;
            s.LastName = txtLastName.Text;
            s.DOB = dtpDOB.Value;

            students.Add(s);

            rebindstudents();
            

        }

        private void rebindstudents()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
            lstStudents.DisplayMember = "DisplayName";
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = lstStudents.SelectedItem as Student;
            if (s != null)
                MessageBox.Show(s.age.ToString());
        }
    }
}
