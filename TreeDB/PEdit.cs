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
    public partial class PEdit : Form
    {
        public PEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int64.Parse(код_паспортаTextBox.Text);
                if (код_паспортаTextBox.TextLength != 9)
                    MessageBox.Show("Код пасспорта не равно 9 символов");
                else
                {
                    if (MessageBox.Show("Вы действительно хотите подтвердить изменения ?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        passportBindingSource.EndEdit();
                        passportTableAdapter.Update(treeDBDataSet);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не цифры");
            }
        }

        private void PEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Passport". При необходимости она может быть перемещена или удалена.
            this.passportTableAdapter.Fill(this.treeDBDataSet.Passport);

        }
    }
}
