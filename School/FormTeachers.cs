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
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
            ShowTeatchrs();
            ShowPredm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPredm.SelectedItem != null && textBoxS.Text != "" && textBoxN.Text != "" && textBoxP.Text != "")
            {
                Teachers teachersSet = new Teachers();
                teachersSet.MiddleName = textBoxS.Text;
                teachersSet.LastName = textBoxN.Text;                
                teachersSet.Phone = textBoxP.Text;
                teachersSet.IdPredm = Convert.ToInt32(comboBoxPredm.SelectedItem.ToString().Split('.')[0]);
                Program.sss.Teachers.Add(teachersSet);
                Program.sss.SaveChanges();
                ShowTeatchrs();
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
        void ShowTeatchrs()
        {
            listViewTeach.Items.Clear();
            foreach (Teachers teachersSet in Program.sss.Teachers)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    teachersSet.Id.ToString(), teachersSet.MiddleName, teachersSet.LastName, teachersSet.Phone, teachersSet.Predm.Name
                });
                item.Tag = teachersSet;
                listViewTeach.Items.Add(item);
                listViewTeach.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

    }
}
