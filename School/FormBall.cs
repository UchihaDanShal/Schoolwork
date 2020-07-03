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
    public partial class FormBall : Form
    {
        public FormBall()
        {
            InitializeComponent();
            ShowPredm();
            ShowStudents();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBoxPredm.SelectedItem != null && textBoxN.Text != "" && textBoxN.Text != "")
            {
                Ball ballSet = new Ball();
                ballSet.Ball1 = textBoxN.Text;
                ballSet.IdPredm = Convert.ToInt32(comboBoxPredm.SelectedItem.ToString().Split('.')[0]);
                Program.sss.Ball.Add(ballSet);
                Program.sss.SaveChanges();                
            }
        }
        void ShowPredm()
        {
            comboBoxPredm.Items.Clear();
            foreach (Predm subjectsSet in Program.sss.Predm)
            {
                string[] item = { subjectsSet.Id.ToString() + ".", subjectsSet.Name };
                comboBoxPredm.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStudents()
        {
            comboBox1.Items.Clear();
            foreach (Stud subjectsSet in Program.sss.Stud)
            {
                string[] item = { subjectsSet.Id.ToString() + ".", subjectsSet.MiddleName };
                comboBox1.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewBall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBall.SelectedItems.Count == 1)
            {
                Ball ballSet = listViewBall.SelectedItems[0].Tag as Ball;
                textBoxN.Text = ballSet.Ball1;
            }
            else
            {                
                textBoxN.Text = "";                              
            }
        }
    }
}
