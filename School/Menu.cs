using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonStud_Click(object sender, EventArgs e)
        {
            Form formStud = new FormStud();
            formStud.Show();
        }

        private void buttonPredm_Click(object sender, EventArgs e)
        {
            Form formSubjects = new FormPredm();
            formSubjects.Show();
        }

        private void buttonTeatch_Click(object sender, EventArgs e)
        {
            Form formTeachers = new FormTeachers();
            formTeachers.Show();
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            Form formBall = new FormBall();
            formBall.Show();
        }
    }
}
