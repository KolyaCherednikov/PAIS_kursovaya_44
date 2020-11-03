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
    public partial class PAdd : Form
    {
        public PAdd()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Passport". При необходимости она может быть перемещена или удалена.
            this.passportTableAdapter.Fill(this.treeDBDataSet.Passport);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (код_паспортаTextBox.Text.Length == 9)
            {
                try
                {
                    passportTableAdapter.Insert(код_паспортаTextBox.Text, фИО_владельцаTextBox.Text, дата_рожденияDateTimePicker.Value, Gender);
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

        private void PAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
