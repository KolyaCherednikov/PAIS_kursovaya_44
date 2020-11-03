using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeDB
{
    public partial class MAdd : Form
    {
        public MAdd()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Passport". При необходимости она может быть перемещена или удалена.
            this.passportTableAdapter.Fill(this.treeDBDataSet.Passport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Family". При необходимости она может быть перемещена или удалена.
            this.familyTableAdapter.Fill(this.treeDBDataSet.Family);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Member". При необходимости она может быть перемещена или удалена.
            this.memberTableAdapter.Fill(this.treeDBDataSet.Member);
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (comboBox1.SelectedIndex == 0)
            {
                Gender = "М";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Gender = "Ж";
            }
            if (textBox1.Text.Length == 9)
            {
                try
                {
                    memberTableAdapter.Insert(фИОTextBox.Text, Gender, textBox1.Text, Convert.ToInt32(textBox2.Text));
                }
                catch
                {
                    AlertForm af = new AlertForm("Ошибка с пасспортными данными");
                    af.ShowDialog();
                }
                this.Close();
            }
            else
            {
                AlertForm af = new AlertForm("Код пасспорта должен быть равен 9 цифрам");
                af.ShowDialog();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
