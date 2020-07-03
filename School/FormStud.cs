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
    public partial class FormStud : Form
    {
        public FormStud()
        {
            InitializeComponent();
            ShowStudents();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Stud studSet = new Stud();
            studSet.FirstName = textBoxS.Text;
            studSet.MiddleName = textBoxN.Text;
            studSet.LastName = textBoxM.Text;
            studSet.Class = textBoxC.Text;
            Program.sss.Stud.Add(studSet);
            Program.sss.SaveChanges();
            ShowStudents();
        }
        void ShowStudents()
        {
            listViewStud.Items.Clear();
            foreach (Stud studSet in Program.sss.Stud)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    studSet.Id.ToString(), studSet.FirstName, studSet.MiddleName, studSet.LastName, studSet.Class
                });
                item.Tag = studSet;
                listViewStud.Items.Add(item);
            }
            listViewStud.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStud.SelectedItems.Count == 1)
            {
                Stud studentsSet = listViewStud.SelectedItems[0].Tag as Stud;
                studentsSet.FirstName = textBoxS.Text;
                studentsSet.MiddleName = textBoxN.Text;
                studentsSet.LastName = textBoxM.Text;
                studentsSet.Class = textBoxC.Text;
                Program.sss.SaveChanges();
                ShowStudents();
            }
        }

        private void listViewStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStud.SelectedItems.Count == 1)
            {
                Stud studentsSet = listViewStud.SelectedItems[0].Tag as Stud;
                textBoxS.Text = studentsSet.FirstName;
                textBoxN.Text = studentsSet.MiddleName;
                textBoxM.Text = studentsSet.LastName;
                textBoxC.Text = studentsSet.Class;
            }
            else
            {
                textBoxS.Text = "";
                textBoxN.Text = "";
                textBoxM.Text = "";
                textBoxC.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStud.SelectedItems.Count == 1)
                {
                    Stud studentsSet = listViewStud.SelectedItems[0].Tag as Stud;
                    Program.sss.Stud.Remove(studentsSet);
                    Program.sss.SaveChanges();
                    ShowStudents();
                }
                textBoxS.Text = "";
                textBoxN.Text = "";
                textBoxM.Text = "";
                textBoxC.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
