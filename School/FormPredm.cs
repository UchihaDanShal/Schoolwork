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
    public partial class FormPredm : Form
    {
        public FormPredm()
        {
            InitializeComponent();
            ShowSubjects();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Predm subjectsSet = new Predm();
            subjectsSet.Name = textBoxN.Text;
            Program.sss.Predm.Add(subjectsSet);
            Program.sss.SaveChanges();
            ShowSubjects();
        }
        void ShowSubjects()
        {
            listViewSub.Items.Clear();
            foreach (Predm subjectsSet in Program.sss.Predm)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    subjectsSet.Id.ToString(), subjectsSet.Name
                });
                item.Tag = subjectsSet;
                listViewSub.Items.Add(item);
            }
            listViewSub.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSub.SelectedItems.Count == 1)
            {
                Predm subjectsSet = listViewSub.SelectedItems[0].Tag as Predm;
                textBoxN.Text = subjectsSet.Name;
            }
            else
            {
                textBoxN.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSub.SelectedItems.Count == 1)
                {
                    Predm subjectsSet = listViewSub.SelectedItems[0].Tag as Predm;
                    Program.sss.Predm.Remove(subjectsSet);
                    Program.sss.SaveChanges();
                    ShowSubjects();
                }
                textBoxN.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
